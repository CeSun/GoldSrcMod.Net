using GoldSrc.HLSDK.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Plugin.Global;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Plugin;
public unsafe static class Exportfuncs
{
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static int Initialize(cl_enginefunc_t *pEnginefuncs, int iVersion)
    {
        var s = sizeof(cl_enginefunc_t);

        gEngfuncs = *pEnginefuncs;
        return gExportfuncs.Initialize(pEnginefuncs, iVersion);
    }
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static void HUD_Init()
    {
        gExportfuncs.HUD_Init();
    }
    static int count = 0;
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static int HUD_Redraw(float time, int intermission)
    {
        if (count < 10)
        {
            using var str = $"Hello World!!!!!(hit:{count + 1})\n".GetNativeString();
            gEngfuncs.Con_Printf(str);
            count++;
        }
        return gExportfuncs.HUD_Redraw(time, intermission);
    }
}


public static class StringHelper
{
    public unsafe static NativeString GetNativeString(this string s) => new NativeString() {  c_str = (sbyte*)Marshal.StringToHGlobalAnsi(s) };

}

public unsafe struct NativeString : IDisposable
{
    internal sbyte* c_str;
    public void Dispose() => Marshal.FreeHGlobal((nint)c_str);
    public static implicit operator sbyte*(NativeString d) => d.c_str;
    public static implicit operator byte*(NativeString d) => (byte*)d.c_str;
    public static implicit operator nint(NativeString d) => (nint)d.c_str;
}