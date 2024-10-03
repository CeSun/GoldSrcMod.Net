using GoldSrc.HLSDK;
using GoldSrc.HLSDK.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Module.Global;

namespace Module;

public unsafe class Test
{
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static void Think(edict_t* pEntityc)
    {
        using var s = "Hello Think\n".GetNativeString();
        g_engfuncs.pfnServerPrint(s);
    }
}
