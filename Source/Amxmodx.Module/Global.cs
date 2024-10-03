using GoldSrc.Amxmodx.Native;
using GoldSrc.HLSDK;
using GoldSrc.HLSDK.Native;
using GoldSrc.MetaMod.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Module;


public unsafe static class Global
{

    public const int INTERFACE_VERSION = 140;
    public const int NEW_DLL_FUNCTIONS_VERSION = 1;
    public const int ENGINE_INTERFACE_VERSION = 138;
    public const int AMXX_INTERFACE_VERSION = 4;
    public const string META_INTERFACE_VERSION = "5:13";

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
    public static globalvars_t* gpGlobals;

    public static meta_globals_t* gpMetaGlobals;      // metamod globals
    public static gamedll_funcs_t* gpGamedllFuncs;    // gameDLL function tables
    public static mutil_funcs_t* gpMetaUtilFuncs;

    public static plugin_info_t* Plugin_info;
    public static META_FUNCTIONS g_MetaFunctions_Table;

    public static amxx_module_info_t g_ModuleInfo;

    public static delegate* unmanaged[Cdecl]<sbyte*, void*> g_fn_RequestFunction;

    static Global()
    {
        Plugin_info = (plugin_info_t*)Marshal.AllocHGlobal(sizeof(mutil_funcs_t));
        Plugin_info->ifvers = META_INTERFACE_VERSION.GetNativeString();
        Plugin_info->name = "AmxxModule.Net".GetNativeString();
        Plugin_info->version = "1.0.0".GetNativeString();
        Plugin_info->date = DateTime.Now.ToString().GetNativeString();
        Plugin_info->author = "CeSun".GetNativeString();
        Plugin_info->url = "https://github.com/CeSun/GoldSrcMod.Net".GetNativeString();
        Plugin_info->logtag = "AmxxModule.Net".GetNativeString();
        Plugin_info->loadable = PLUG_LOADTIME.PT_ANYTIME;
        Plugin_info->unloadable = PLUG_LOADTIME.PT_ANYTIME;

        g_ModuleInfo.name = Plugin_info->name;
        g_ModuleInfo.author = Plugin_info->author;
        g_ModuleInfo.version = Plugin_info->version;
        g_ModuleInfo.reload = 1;
        g_ModuleInfo.library = "AmxxModule.Net".GetNativeString();
        g_ModuleInfo.libclass = "".GetNativeString();



    }
    public const int False = 0;
    public const int True = 1;

    public const int AMXX_OK = 0;           /* no error */
    public const int AMXX_IFVERS = 1;       /* interface version */
    public const int AMXX_PARAM = 2;        /* Invalid parameter */
    public const int AMXX_FUNC_NOT_PRESENT = 3;     /* Function not present */


    public const int AMXX_GAME_OK = 0;          /* This module can load on the current game mod. */
    public const int AMXX_GAME_BAD = 1;			/* This module can not load on the current game mod. */
}
