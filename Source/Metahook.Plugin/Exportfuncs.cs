using GoldSrc.HLSDK;
using GoldSrc.HLSDK.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Plugin.Global;

namespace Plugin;
public unsafe static class Exportfuncs
{
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static int Initialize(cl_enginefuncs_t *pEnginefuncs, int iVersion)
    {
        var s = sizeof(cl_enginefuncs_t);

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
            using var str = $"Fuck World!!!!! 哈哈哈(hit:{count})\n".GetNativeString();
            gEngfuncs.Con_Printf(str);
            count++;
        }
        return gExportfuncs.HUD_Redraw(time, intermission);
    }
}

