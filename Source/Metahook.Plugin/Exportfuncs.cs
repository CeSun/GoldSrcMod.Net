﻿using GoldSrc.HLSDK.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Plugin.Global;

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
            var str = $"Fuck World!!!!! (hit:{count})\n";
            var cstr = (sbyte*)Marshal.StringToHGlobalAnsi(str);
            gEngfuncs.Con_Printf(cstr);
            Marshal.FreeHGlobal((nint)cstr);
            count++;
        }
        return gExportfuncs.HUD_Redraw(time, intermission);
    }
}
