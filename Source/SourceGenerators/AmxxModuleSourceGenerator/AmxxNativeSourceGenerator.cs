using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmxxModuleSourceGenerator
{
    [Generator]
    public class AmxxNativeSourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var list = context.Compilation.SyntaxTrees
                .SelectMany(tree => tree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>()
                .SelectMany(Class => Class.Members.OfType<MethodDeclarationSyntax>()
                    .Where(method => method.Modifiers.ToList().Any(modifier => modifier.ToString() == "static"))))
                    .Where(method => method.AttributeLists.Any(attributeList => attributeList.Attributes.Any(attribute => attribute.Name.ToString() == "AmxxNative")))
                .ToList();
            List<string> methodSourceBlocks = new List<string>();
            List<string> registerMethodSourceBlocks = new List<string>();
            foreach (var method in list)
            {
                var attribute = method.AttributeLists.Select(attributeList => attributeList.Attributes.Where(attr => attr.Name.ToString() == "AmxxNative").Select(attr => attr).First()).First();
                var exportName = $"\"{method.Identifier.ToString()}\"";
                if (attribute.ArgumentList != null && attribute.ArgumentList.Arguments != null && attribute.ArgumentList.Arguments.Count > 0)
                {
                    foreach (var argument in attribute.ArgumentList.Arguments)
                    {
                        exportName = argument.Expression.ToString();
                    }
                }
                var Class = method.Parent as ClassDeclarationSyntax;
                var className = Class.Identifier.ToString();
                var methodName = method.Identifier.ToString();
                var classNamespace = Class.GetFullNamespace();
                var methodSource = "\t[UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]\n" +
                                    $"\tpublic unsafe static cell Export_{exportName.Trim().Replace("\"", "")}(AMX* amx, cell* @params) \n \t{{\n";
                int paramNum = 0;
                if (method.ParameterList != null && method.ParameterList.Parameters != null)
                {
                    List<string> paramsSource = new List<string>();
                    foreach (var paramter in method.ParameterList.Parameters)
                    {
                        paramNum++;
                        var typeName = paramter.Type.ToString();
                        var paramSourceCode = "";
                        if (typeName == "int")
                        {
                            paramSourceCode = $"\t\tint param{paramNum} = @params[{paramNum}];";
                        }
                        else if (typeName == "float")
                        {
                            paramSourceCode = $"\t\tfloat param{paramNum} = *(float*)(@params + {paramNum});";
                        }
                        else if (typeName == "bool")
                        {
                            paramSourceCode = $"\t\tint param{paramNum} = @params[{paramNum}] == 0 ? false : true;";
                        }
                        else if (typeName == "string") 
                        {
                            paramSourceCode = $"\t\tvar param{paramNum} = Marshal.PtrToStringAnsi((nint)g_fn_GetAmxString(amx, @params[{paramNum}], 0, null));";
                        }
                        paramsSource.Add(paramSourceCode);
                    }
                    methodSource = methodSource + string.Join("\n", paramsSource);
                }

                var str = method.ReturnType.ToString();
                if (str == "void")
                    methodSource = methodSource + $"\n\t\t";
                else
                    methodSource = methodSource + $"\n\t\tvar rtv = ";
                if (paramNum == 0)
                {
                    methodSource += $"global::{classNamespace}.{className}.{methodName}();";
                }
                else
                {
                    methodSource += $"global::{classNamespace}.{className}.{methodName}(";
                    for(int i = 1; i <= paramNum; i++)
                    {
                        if (i > 1)
                            methodSource += ", ";
                        methodSource += "param" + i;
                    }
                    methodSource += ");\n";
                }

                if (str == "void")
                    methodSource += "\t\treturn 1;\n";
                else if (str == "int")
                    methodSource += "\t\treturn rtv;\n";
                else if (str == "bool")
                    methodSource += "\t\treturn rtv?1:0;\n";
                else if (str == "float")
                    methodSource += "\t\treturn g_fn_RealToCell(rtv);\n";
                methodSource += "\t}";
                methodSourceBlocks.Add(methodSource);
                registerMethodSourceBlocks.Add($@"		list.Add(new () 
		{{
		name={exportName}.GetNativeString(),
		func=(nint)(delegate* unmanaged[Cdecl]<AMX*, int*, int>)&Export_{exportName.Trim().Replace("\"", "")}
		}});");
            }
            var fileSource = @"using GoldSrc.MetaMod.Native;
using GoldSrc.Amxmodx.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GoldSrc.HLSDK;
using static Module.Global;
#pragma warning disable CS8981
using cell = int;
#pragma warning restore CS8981
";
            fileSource += "namespace Module;\n";

            fileSource += "public static class NativeFunctionRegister {\n";
            fileSource += "\t public static unsafe void RegisterFunction(List<AMX_NATIVE_INFO> list)\n";
            fileSource += "\t{\n";
            fileSource += string.Join("\n", registerMethodSourceBlocks);
            fileSource += "\n\t}\n";

            fileSource += string.Join("\n", methodSourceBlocks);
            fileSource += "\n}";

            context.AddSource("NativeFunctionRegister.gen.cs", fileSource);
        }

        public void Initialize(GeneratorInitializationContext context)
        {

        }
    }


    public static class ClassDeclarationSyntaxExt
    {
        public static string GetFullNamespace(this ClassDeclarationSyntax classDeclarationSyntax)
        {
            if (classDeclarationSyntax.Parent is BaseNamespaceDeclarationSyntax @namespace)
                return @namespace.GetFullNamespace();
            return "";
        }
        public static string GetFullNamespace(this BaseNamespaceDeclarationSyntax Syntax)
        {
            if (Syntax.Parent is BaseNamespaceDeclarationSyntax baseNamespaceDeclarationSyntax == false)
            {
                return Syntax.Name.ToString().Trim();
            }

            return baseNamespaceDeclarationSyntax.GetFullNamespace() + "." + Syntax.Name;
        }
    }
}
