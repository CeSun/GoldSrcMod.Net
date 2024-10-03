using GoldSrc.HLSDK.Native;
using GoldSrc.MetaMod.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Module;


public unsafe static class Global
{

    public const int INTERFACE_VERSION = 140;
    public const int NEW_DLL_FUNCTIONS_VERSION = 1;
    public const int ENGINE_INTERFACE_VERSION = 1; // todo

    public static DLL_FUNCTIONS g_EntityAPI_Table;
    public static DLL_FUNCTIONS* g_pFunctionTable;

    public static DLL_FUNCTIONS g_EntityAPI_Post_Table;
    public static DLL_FUNCTIONS* g_pFunctionTable_Post;

    public static NEW_DLL_FUNCTIONS g_NewFuncs_Table;
    public static NEW_DLL_FUNCTIONS* g_pNewFunctionsTable;

    public static NEW_DLL_FUNCTIONS g_NewFuncs_Post_Table;
    public static NEW_DLL_FUNCTIONS* g_pNewFunctionsTable_Post;

    public static enginefuncs_t g_EngineFuncs_Table;
    public static enginefuncs_t* g_pengfuncsTable;

    public static enginefuncs_t g_EngineFuncs_Post_Table;
    public static enginefuncs_t* g_pEngineFuncs_Post;

    public static enginefuncs_t g_engfuncs;

    public static mutil_funcs_t* gpMetaUtilFuncs;

    public static plugin_info_t* Plugin_info; // todo


    static Global()
    {
        Plugin_info = (plugin_info_t*)Marshal.AllocHGlobal(sizeof(mutil_funcs_t));
    }
    public const int False = 0;
    public const int True = 1;
}
