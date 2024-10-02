using GoldSrc.Metahook.Native;
using GoldSrc.Metahook;
using GoldSrc.HLSDK.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Plugin;

public static class Register
{
    static Dictionary<string, Func<string, (nint, int)>> RegisterDictionary = [];

    [UnmanagedCallersOnly(EntryPoint = "CreateInterface", CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe nint CreateInterface(nint ptr, int* num)
    {
        string? frameworkVersion = Marshal.PtrToStringAnsi(ptr);

        if (frameworkVersion == null)
            return IntPtr.Zero;
        nint pPlugin = IntPtr.Zero;
        int result = 1;
        switch (frameworkVersion)
        {
            case PluginConst.METAHOOK_PLUGIN_API_VERSION_V2:
                (pPlugin, result) = GetV2PluginInstance(frameworkVersion);
                break;
            case PluginConst.METAHOOK_PLUGIN_API_VERSION_V1:
                (pPlugin, result) = GetV1PluginInstance(frameworkVersion);
                break;
        }
        return ptr;
    }


    public static unsafe (nint, int) GetV1PluginInstance(string version)
    {
        var ptr = Marshal.AllocHGlobal(sizeof(PluginValueType));
        ref var plugin = ref Unsafe.AsRef<PluginValueType>((void*)ptr);
        var functionTable = Marshal.AllocHGlobal(sizeof(nint) * 3);
        Span<nint> functions = new Span<nint>((void*)functionTable, 3);
        functions[0] = (nint)(delegate* unmanaged[Thiscall]<nint, void>)&PluginV1.Destructor;
        functions[1] = (nint)(delegate* unmanaged[Thiscall]<nint, cl_exportfuncs_t*, void>)&PluginV1.Init;
        functions[2] = (nint)(delegate* unmanaged[Thiscall]<nint, int, void>)&PluginV1.Shutdown;
        plugin = new PluginValueType
        {
            VirtualFunctionTable = functionTable
        };
        return (ptr, 0);
    }


    public static unsafe (nint, int) GetV2PluginInstance(string version)
    {
        var ptr = Marshal.AllocHGlobal(sizeof(PluginValueType));
        ref var plugin = ref Unsafe.AsRef<PluginValueType>((void*)ptr);
        var functionTable = Marshal.AllocHGlobal(sizeof(nint) * 6);
        Span<nint> functions = new Span<nint>((void*)functionTable, 6);
        functions[0] = (nint)(delegate* unmanaged[Thiscall]<nint, void>)&PluginV2.Destructor;
        functions[1] = (nint)(delegate* unmanaged[Thiscall]<nint, metahook_api_t*, mh_interface_t*, mh_enginesave_t*, void>)&PluginV2.Init;
        functions[2] = (nint)(delegate* unmanaged[Thiscall]<nint, void>)&PluginV2.Shutdown;
        functions[3] = (nint)(delegate* unmanaged[Thiscall]<nint, void>)&PluginV2.LoadEngine;
        functions[4] = (nint)(delegate* unmanaged[Thiscall]<nint, cl_exportfuncs_t*, void>)&PluginV2.LoadClient;
        functions[5] = (nint)(delegate* unmanaged[Thiscall]<nint, int, void>)&PluginV2.ExitGame;
        plugin = new PluginValueType
        {
            VirtualFunctionTable = functionTable
        };
        return (ptr, 0);
    }

    struct PluginValueType
    {
        public nint VirtualFunctionTable;
    }

}

