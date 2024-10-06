using GoldSrc.Amxmodx.Native;
using GoldSrc.HLSDK;
using GoldSrc.HLSDK.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Module.Global;
#pragma warning disable CS8981
using cell = int;
#pragma warning restore CS8981


namespace Module;

public unsafe class Plugin
{

    public static List<AMX_NATIVE_INFO> AmxNativeInfoList = [];
    static Plugin()
    {
        AmxNativeInfoList.Add(new AMX_NATIVE_INFO
        {
            name = "TestHelloModule".GetNativeString(),
            func = (nint)(delegate* unmanaged[Cdecl]<AMX*, int*, int>)&Plugin.TestHelloModule,
        });
    }

    public static void FN_META_QUERY()
    {

    }

    public static void FN_META_ATTACH()
    {

    }

    public static void FN_META_DETACH()
    {

    }

    public static void FN_AMXX_QUERY()
    {

    }

    public static int FN_AMXX_CHECKGAME(sbyte* game)
    {
        return AMXX_GAME_OK;
    }

    public static void FN_AMXX_ATTACH()
    {
    }

    public static void FN_AMXX_DETACH()
    {
    }

    public static void FN_AMXX_PLUGINSLOADED()
    {
    }

    public static void FN_AMXX_PLUGINSUNLOADING()
    {

    }
    public static void FN_AMXX_PLUGINSUNLOADED()
    {

    }



    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static cell TestHelloModule(AMX* amx, cell* @params)
    {
        using var s = "TestHelloModule\n".GetNativeString();
        g_engfuncs.pfnServerPrint(s);
        return 1;
    }
}
