using GoldSrc.Amxmodx.Native;
using GoldSrc.HLSDK;
using GoldSrc.HLSDK.Native;
using GoldSrc.MetaMod;
using GoldSrc.MetaMod.Native;
using System.Runtime.InteropServices;
#pragma warning disable CS8981
using cell = int;
#pragma warning restore CS8981
using size_t = uint;

namespace Module;


public unsafe static class Global
{
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
        Plugin_info->ifvers = MetaModInfo.META_INTERFACE_VERSION.GetNativeString();
        Plugin_info->name = ModuleConfig.Name.GetNativeString();
        Plugin_info->version = ModuleConfig.Name.GetNativeString();
        Plugin_info->date = DateTime.Now.ToString().GetNativeString();
        Plugin_info->author = ModuleConfig.Author.GetNativeString();
        Plugin_info->url = ModuleConfig.Url.GetNativeString();
        Plugin_info->logtag = ModuleConfig.Name.GetNativeString();
        Plugin_info->loadable = PLUG_LOADTIME.PT_ANYTIME;
        Plugin_info->unloadable = PLUG_LOADTIME.PT_ANYTIME;

        g_ModuleInfo.name = Plugin_info->name;
        g_ModuleInfo.author = Plugin_info->author;
        g_ModuleInfo.version = Plugin_info->version;
        g_ModuleInfo.reload = 1;
        g_ModuleInfo.library = ModuleConfig.Name.GetNativeString();
        g_ModuleInfo.libclass = "".GetNativeString();

    }


    public const int False = 0;
    public const int True = 1;

    public const int AMXX_OK = 0;           /* no error */
    public const int AMXX_IFVERS = 1;       /* interface version */
    public const int AMXX_PARAM = 2;        /* Invalid parameter */
    public const int AMXX_FUNC_NOT_PRESENT = 3;     /* Function not present */


    public const int AMXX_GAME_OK = 0;          /* This module can load on the current game mod. */
    public const int AMXX_GAME_BAD = 1;         /* This module can not load on the current game mod. */



    // amxx api
    public static delegate* unmanaged[Cdecl]<AMX_NATIVE_INFO*, int> g_fn_AddNatives;
    public static delegate* unmanaged[Cdecl]<AMX_NATIVE_INFO*, int> g_fn_AddNewNatives;
    public static delegate* unmanaged[Cdecl]<sbyte*, sbyte*> g_fn_BuildPathname;
    public static delegate* unmanaged[Cdecl]<sbyte*, size_t, sbyte*, sbyte*> g_fn_BuildPathnameR;
    public static delegate* unmanaged[Cdecl]<AMX*, cell, cell*> g_fn_GetAmxAddr;
    public static delegate* unmanaged[Cdecl]<sbyte*, void> g_fn_PrintSrvConsole;
    public static delegate* unmanaged[Cdecl]<sbyte*> g_fn_GetModname;
    public static delegate* unmanaged[Cdecl]<int, sbyte*> g_fn_GetAmxScriptName;
    public static delegate* unmanaged[Cdecl]<int, AMX*> g_fn_GetAmxScript;
    public static delegate* unmanaged[Cdecl]<AMX*, int> g_fn_FindAmxScriptByAmx;
    public static delegate* unmanaged[Cdecl]<sbyte*, int> g_fn_FindAmxScriptByName;
    public static delegate* unmanaged[Cdecl]<AMX*, cell, sbyte*, int, int> g_fn_SetAmxString;
    public static delegate* unmanaged[Cdecl]<AMX*, cell, int, int*, sbyte*> g_fn_GetAmxString;
    public static delegate* unmanaged[Cdecl]<cell*, int> g_fn_GetAmxStringLen;
    public static delegate* unmanaged[Cdecl]<AMX*, cell*, int, int*, sbyte*> g_fn_FormatAmxString;
    public static delegate* unmanaged[Cdecl]<cell*, cell*, int, void> g_fn_CopyAmxMemory;
    public static delegate* unmanaged[Cdecl]<sbyte*, void> g_fn_Log;
    public static delegate* unmanaged[Cdecl]<AMX*, int, sbyte*, void> g_fn_LogErrorFunc;
    public static delegate* unmanaged[Cdecl]<AMX*, int, int> g_fn_RaiseAmxError;
    public static delegate* unmanaged[Cdecl]<sbyte*, ForwardExecType, int> g_fn_RegisterForward;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_ExecuteForward;
    public static delegate* unmanaged[Cdecl]<cell*, uint, cell> g_fn_PrepareCellArray;
    public static delegate* unmanaged[Cdecl]<sbyte*, uint, cell> g_fn_PrepareCharArray;
    public static delegate* unmanaged[Cdecl]<cell*, uint, bool, cell> g_fn_PrepareCellArrayA;
    public static delegate* unmanaged[Cdecl]<sbyte*, uint, bool, cell> g_fn_PrepareCharArrayA;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_IsPlayerValid;
    public static delegate* unmanaged[Cdecl]<int, sbyte*> g_fn_GetPlayerName;
    public static delegate* unmanaged[Cdecl]<int, sbyte*> g_fn_GetPlayerIP;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_IsPlayerIngame;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_IsPlayerBot;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_IsPlayerAuthorized;
    public static delegate* unmanaged[Cdecl]<int, float> g_fn_GetPlayerTime;
    public static delegate* unmanaged[Cdecl]<int, float> g_fn_GetPlayerPlayTime;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerFlags;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerCurweapon;
    public static delegate* unmanaged[Cdecl]<int, sbyte*> g_fn_GetPlayerTeam;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerTeamID;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerDeaths;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerMenu;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerKeys;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_IsPlayerAlive;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerFrags;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_IsPlayerConnecting;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_IsPlayerHLTV;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerArmor;
    public static delegate* unmanaged[Cdecl]<int, int> g_fn_GetPlayerHealth;
    public static delegate* unmanaged[Cdecl]<AMX*, cell*, int, int> g_fn_AmxExec;
    public static delegate* unmanaged[Cdecl]<AMX*, cell*, int, int, cell[], int> g_fn_AmxExecv;
    public static delegate* unmanaged[Cdecl]<AMX*, int, cell*, cell**, int> g_fn_AmxAllot;
    public static delegate* unmanaged[Cdecl]<AMX*, sbyte*, int*, int> g_fn_AmxFindPublic;
    public static delegate* unmanaged[Cdecl]<AMX*, sbyte*, int*, int> g_fn_AmxFindNative;
    public static delegate* unmanaged[Cdecl]<AMX*, void**, sbyte*, sbyte*, int, int> g_fn_LoadAmxScript;
    public static delegate* unmanaged[Cdecl]<AMX*, void**, int> g_fn_UnloadAmxScript;
    public static delegate* unmanaged[Cdecl]<float, cell> g_fn_RealToCell;
    public static delegate* unmanaged[Cdecl]<cell, float> g_fn_CellToReal;
    public static delegate* unmanaged[Cdecl]<AMX*, int, int> g_fn_RegisterSPForward;
    public static delegate* unmanaged[Cdecl]<AMX*, sbyte*, int> g_fn_RegisterSPForwardByName;
    public static delegate* unmanaged[Cdecl]<int, void> g_fn_UnregisterSPForward;
    public static delegate* unmanaged[Cdecl]<sbyte*, void> g_fn_MergeDefinition_File;
    public static delegate* unmanaged[Cdecl]<sbyte*, sbyte*> g_fn_Format;
    public static delegate* unmanaged[Cdecl]<void*, sbyte*, void> g_fn_RegisterFunction;
    public static delegate* unmanaged[Cdecl]<AMX*, cell, int> g_fn_AmxPush;
    public static delegate* unmanaged[Cdecl]<int, int, sbyte*, int> g_fn_SetTeamInfo;
    public static delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<int, sbyte*, void>, void> g_fn_RegAuthFunc;
    public static delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<int, sbyte*, void>, void> g_fn_UnregAuthFunc;
    public static delegate* unmanaged[Cdecl]<sbyte*, LibType, int> g_fn_FindLibrary;
    public static delegate* unmanaged[Cdecl]<sbyte*, LibType, void*, size_t> g_fn_AddLibraries;
    public static delegate* unmanaged[Cdecl]<void*, size_t> g_fn_RemoveLibraries;
    public static delegate* unmanaged[Cdecl]<AMX_NATIVE_INFO*, sbyte*, void> g_fn_OverrideNatives;
    public static delegate* unmanaged[Cdecl]<sbyte*, sbyte*, sbyte*> g_fn_GetLocalInfo;
    public static delegate* unmanaged[Cdecl]<AMX*, AMX_NATIVE_INFO*, int, int> g_fn_AmxReRegister;
    public static delegate* unmanaged[Cdecl]<void*, sbyte*, void*> g_fn_RegisterFunctionEx;
    public static delegate* unmanaged[Cdecl]<int, int, int*, void> g_fn_MessageBlock;
    public static delegate* unmanaged[Cdecl]<int, edict_t*> g_fn_GetPlayerEdict;
    public static delegate* unmanaged[Cdecl]<int, int, void*> g_fn_PlayerPropAddr;
}
