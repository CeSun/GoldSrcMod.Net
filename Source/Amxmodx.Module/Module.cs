using GoldSrc.Amxmodx;
using GoldSrc.Amxmodx.Native;
using GoldSrc.HLSDK;
using GoldSrc.HLSDK.Native;
using GoldSrc.MetaMod;
using GoldSrc.MetaMod.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Module.Global;

namespace Module;

public unsafe static class Module
{
    static Module()
    {
        g_MetaFunctions_Table.pfnGetEntityAPI2 = &GetEntityAPI2;
        g_MetaFunctions_Table.pfnGetEntityAPI2_Post = &GetEntityAPI2_Post;
        g_MetaFunctions_Table.pfnGetNewDLLFunctions = &GetNewDLLFunctions;
        g_MetaFunctions_Table.pfnGetNewDLLFunctions_Post = &GetNewDLLFunctions_Post;
        g_MetaFunctions_Table.pfnGetEngineFunctions = &GetEngineFunctions;
        g_MetaFunctions_Table.pfnGetEngineFunctions_Post = &GetEngineFunctions_Post;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEntityAPI2(DLL_FUNCTIONS* pFunctionTable, int* interfaceVersion)
    {
        if (pFunctionTable == null)
            return False;
        if (*interfaceVersion != HLSDKInfo.INTERFACE_VERSION)
        {
            *interfaceVersion = HLSDKInfo.INTERFACE_VERSION;
            return False;
        }
        *pFunctionTable = g_EntityAPI_Table;
        g_pFunctionTable = pFunctionTable;
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2_Post", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEntityAPI2_Post(DLL_FUNCTIONS* pFunctionTable, int* interfaceVersion)
    {
        if (pFunctionTable == null)
            return False;
        if (*interfaceVersion != HLSDKInfo.INTERFACE_VERSION)
        {
            *interfaceVersion = HLSDKInfo.INTERFACE_VERSION;
            return False;
        }
        *pFunctionTable = g_EntityAPI_Post_Table;
        g_pFunctionTable_Post = pFunctionTable;
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEngineFunctions(enginefuncs_t* pengfuncsFromEngine, int* interfaceVersion)
    {
        if (pengfuncsFromEngine == null)
            return False;
        if (*interfaceVersion != MetaModInfo.ENGINE_INTERFACE_VERSION)
        {
            *interfaceVersion = MetaModInfo.ENGINE_INTERFACE_VERSION;
            return False;
        }
        *pengfuncsFromEngine = g_EngineFuncs_Table;
        g_pengfuncsTable = pengfuncsFromEngine;
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEngineFunctions_Post(enginefuncs_t* pengfuncsFromEngine, int* interfaceVersion)
    {
        if (pengfuncsFromEngine == null)
            return False;
        if (*interfaceVersion != MetaModInfo.ENGINE_INTERFACE_VERSION)
        {
            *interfaceVersion = MetaModInfo.ENGINE_INTERFACE_VERSION;
            return False;
        }
        *pengfuncsFromEngine = g_EngineFuncs_Post_Table;
        g_pEngineFuncs_Post = pengfuncsFromEngine;
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetNewDLLFunctions(NEW_DLL_FUNCTIONS* pNewFunctionTable, int* interfaceVersion)
    {
        if (pNewFunctionTable == null)
            return False;
        if (*interfaceVersion != HLSDKInfo.NEW_DLL_FUNCTIONS_VERSION)
        {
            *interfaceVersion = HLSDKInfo.NEW_DLL_FUNCTIONS_VERSION;
            return False;
        }
        *pNewFunctionTable = g_NewFuncs_Table;
        g_pNewFunctionsTable = pNewFunctionTable;
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetNewDLLFunctions_Post(NEW_DLL_FUNCTIONS* pNewFunctionTable, int* interfaceVersion)
    {
        if (pNewFunctionTable == null)
            return False;
        if (*interfaceVersion != HLSDKInfo.NEW_DLL_FUNCTIONS_VERSION)
        {
            *interfaceVersion = HLSDKInfo.NEW_DLL_FUNCTIONS_VERSION;
            return False;
        }
        *pNewFunctionTable = g_NewFuncs_Post_Table;
        g_pNewFunctionsTable_Post = pNewFunctionTable;
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
    public static int Meta_Query(sbyte* ifvers, plugin_info_t** pPlugInfo, mutil_funcs_t* pMetaUtilFuncs)
    {
        if (pMetaUtilFuncs == null)
        {
            return False;
        }
        gpMetaUtilFuncs = pMetaUtilFuncs;
        *pPlugInfo = Plugin_info;

        var frameVersion = Marshal.PtrToStringAnsi((nint)ifvers)!;
        var list = frameVersion.Split(":");
        var mmajor = int.Parse(list[0]);
        var mminor = int.Parse(list[1]);

        list = MetaModInfo.META_INTERFACE_VERSION.Split(":");
        var pmajor = int.Parse(list[0]);
        var pminor = int.Parse(list[1]);

        if (pmajor > mmajor || (pmajor == mmajor && pminor > mminor))
            return False;
        else if (pmajor < mmajor)
            return False;
        return True;
    }


    [UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
    public static int Meta_Attach(PLUG_LOADTIME now, META_FUNCTIONS* pFunctionTable, meta_globals_t* pMGlobals, gamedll_funcs_t* pGamedllFuncs)
    {
        if ((int)now > (int)Plugin_info->loadable)
            return False;
        if (pMGlobals == null)
            return False;
        gpMetaGlobals = pMGlobals;
        if (pFunctionTable == null)
            return False;
        *pFunctionTable = g_MetaFunctions_Table;
        gpGamedllFuncs = pGamedllFuncs;
        Plugin.FN_META_ATTACH();
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
    public static int Meta_Detach(PLUG_LOADTIME now, PL_UNLOAD_REASON reason)
    {
        if (now > Plugin_info->unloadable && reason != PL_UNLOAD_REASON.PNL_CMD_FORCED)
            return False;
        Plugin.FN_META_DETACH();
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "GiveFnptrsToDll", CallConvs = [typeof(CallConvStdcall)])]
    public static void GiveFnptrsToDll(enginefuncs_t* pengfuncsFromEngine, globalvars_t* pGlobals)
    {
        g_engfuncs = *pengfuncsFromEngine;
        gpGlobals = pGlobals;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_Query", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_Query(int* interfaceVersion, amxx_module_info_t* moduleInfo)
    {
        if (interfaceVersion == null || moduleInfo == null)
            return AMXX_PARAM;
        if (*interfaceVersion != AmxxInfo.AMXX_INTERFACE_VERSION)
        {
            *interfaceVersion = AmxxInfo.AMXX_INTERFACE_VERSION;
            return AMXX_IFVERS;
        }
        *moduleInfo = g_ModuleInfo;
        Plugin.FN_AMXX_QUERY();
        return AMXX_OK;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_CheckGame", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_CheckGame(nint game)
    {
        Plugin.FN_AMXX_CHECKGAME((sbyte*)game);
        return AMXX_GAME_OK;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_Attach", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_Attach(delegate* unmanaged[Cdecl]<sbyte*, void*> reqFnptrFunc)
    {
        if (reqFnptrFunc == null)
            return AMXX_PARAM;
        var size = sizeof(AMX);
        g_fn_RequestFunction = reqFnptrFunc;
        using (var funName = "BuildPathname".GetNativeString())
        {
            g_fn_BuildPathname = (delegate* unmanaged[Cdecl]<sbyte*, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "BuildPathnameR".GetNativeString())
        {
            g_fn_BuildPathnameR = (delegate* unmanaged[Cdecl]<sbyte*, uint, sbyte*, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "PrintSrvConsole".GetNativeString())
        {
            g_fn_PrintSrvConsole = (delegate* unmanaged[Cdecl]<sbyte*, void>)reqFnptrFunc(funName);
        }
        using (var funName = "GetModname".GetNativeString())
        {
            g_fn_GetModname = (delegate* unmanaged[Cdecl]<sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "Log".GetNativeString())
        {
            g_fn_Log = (delegate* unmanaged[Cdecl]<sbyte*, void>)reqFnptrFunc(funName);
        }
        using (var funName = "LogError".GetNativeString())
        {
            g_fn_LogErrorFunc = (delegate* unmanaged[Cdecl]<AMX*, int, sbyte*, void>)reqFnptrFunc(funName);
        }
        using (var funName = "MergeDefinitionFile".GetNativeString())
        {
            g_fn_MergeDefinition_File = (delegate* unmanaged[Cdecl]<sbyte*, void>)reqFnptrFunc(funName);
        }
        using (var funName = "Format".GetNativeString())
        {
            g_fn_Format = (delegate* unmanaged[Cdecl]<sbyte*, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "RegisterFunction".GetNativeString())
        {
            g_fn_RegisterFunction = (delegate* unmanaged[Cdecl]<void*, sbyte*, void>)reqFnptrFunc(funName);
        }
        using (var funName = "RegisterFunctionEx".GetNativeString())
        {
            g_fn_RegisterFunctionEx = (delegate* unmanaged[Cdecl]<void*, sbyte*, void*>)reqFnptrFunc(funName);
        }
        using (var funName = "GetAmxScript".GetNativeString())
        {
            g_fn_GetAmxScript = (delegate* unmanaged[Cdecl]<int, AMX*>)reqFnptrFunc(funName);
        }
        using (var funName = "FindAmxScriptByAmx".GetNativeString())
        {
            g_fn_FindAmxScriptByAmx = (delegate* unmanaged[Cdecl]<AMX*, int>)reqFnptrFunc(funName);
        }
        using (var funName = "FindAmxScriptByName".GetNativeString())
        {
            g_fn_FindAmxScriptByName = (delegate* unmanaged[Cdecl]<sbyte*, int>)reqFnptrFunc(funName);
        }
        using (var funName = "LoadAmxScript".GetNativeString())
        {
            g_fn_LoadAmxScript = (delegate* unmanaged[Cdecl]<AMX*, void**, sbyte*, sbyte*, int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "UnloadAmxScript".GetNativeString())
        {
            g_fn_UnloadAmxScript = (delegate* unmanaged[Cdecl]<AMX*, void**, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetAmxScriptName".GetNativeString())
        {
            g_fn_GetAmxScriptName = (delegate* unmanaged[Cdecl]<int, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "SetAmxString".GetNativeString())
        {
            g_fn_SetAmxString = (delegate* unmanaged[Cdecl]<AMX*, int, sbyte*, int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetAmxString".GetNativeString())
        {
            g_fn_GetAmxString = (delegate* unmanaged[Cdecl]<AMX*, int, int, int*, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "GetAmxStringLen".GetNativeString())
        {
            g_fn_GetAmxStringLen = (delegate* unmanaged[Cdecl]<int*, int>)reqFnptrFunc(funName);
        }
        using (var funName = "FormatAmxString".GetNativeString())
        {
            g_fn_FormatAmxString = (delegate* unmanaged[Cdecl]<AMX*, int*, int, int*, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "CopyAmxMemory".GetNativeString())
        {
            g_fn_CopyAmxMemory = (delegate* unmanaged[Cdecl]<int*, int*, int, void>)reqFnptrFunc(funName);
        }
        using (var funName = "GetAmxAddr".GetNativeString())
        {
            g_fn_GetAmxAddr = (delegate* unmanaged[Cdecl]<AMX*, int, int*>)reqFnptrFunc(funName);
        }
        using (var funName = "AddNatives".GetNativeString())
        {
            g_fn_AddNatives = (delegate* unmanaged[Cdecl]<AMX_NATIVE_INFO*, int>)reqFnptrFunc(funName);
        }
        using (var funName = "AddNewNatives".GetNativeString())
        {
            g_fn_AddNewNatives = (delegate* unmanaged[Cdecl]<AMX_NATIVE_INFO*, int>)reqFnptrFunc(funName);
        }
        using (var funName = "RaiseAmxError".GetNativeString())
        {
            g_fn_RaiseAmxError = (delegate* unmanaged[Cdecl]<AMX*, int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "RegisterForward".GetNativeString())
        {
            g_fn_RegisterForward = (delegate* unmanaged[Cdecl]<sbyte*, ForwardExecType, int>)reqFnptrFunc(funName);
        }
        using (var funName = "RegisterSPForward".GetNativeString())
        {
            g_fn_RegisterSPForward = (delegate* unmanaged[Cdecl]<AMX*, int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "RegisterSPForwardByName".GetNativeString())
        {
            g_fn_RegisterSPForwardByName = (delegate* unmanaged[Cdecl]<AMX*, sbyte*, int>)reqFnptrFunc(funName);
        }
        using (var funName = "UnregisterSPForward".GetNativeString())
        {
            g_fn_UnregisterSPForward = (delegate* unmanaged[Cdecl]<int, void>)reqFnptrFunc(funName);
        }
        using (var funName = "ExecuteForward".GetNativeString())
        {
            g_fn_ExecuteForward = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "PrepareCharArray".GetNativeString())
        {
            g_fn_PrepareCharArray = (delegate* unmanaged[Cdecl]<sbyte*, uint, int>)reqFnptrFunc(funName);
        }
        using (var funName = "PrepareCellArrayA".GetNativeString())
        {
            g_fn_PrepareCellArrayA = (delegate* unmanaged[Cdecl]<int*, uint, bool, int>)reqFnptrFunc(funName);
        }
        using (var funName = "PrepareCharArrayA".GetNativeString())
        {
            g_fn_PrepareCharArrayA = (delegate* unmanaged[Cdecl]<sbyte*, uint, bool, int>)reqFnptrFunc(funName);
        }
        using (var funName = "IsPlayerValid".GetNativeString())
        {
            g_fn_IsPlayerValid = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerName".GetNativeString())
        {
            g_fn_GetPlayerName = (delegate* unmanaged[Cdecl]<int, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerIP".GetNativeString())
        {
            g_fn_GetPlayerIP = (delegate* unmanaged[Cdecl]<int, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "IsPlayerInGame".GetNativeString())
        {
            g_fn_IsPlayerIngame = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "IsPlayerBot".GetNativeString())
        {
            g_fn_IsPlayerBot = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "IsPlayerAuthorized".GetNativeString())
        {
            g_fn_IsPlayerAuthorized = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerTime".GetNativeString())
        {
            g_fn_GetPlayerTime = (delegate* unmanaged[Cdecl]<int, float>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerPlayTime".GetNativeString())
        {
            g_fn_GetPlayerPlayTime = (delegate* unmanaged[Cdecl]<int, float>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerCurweapon".GetNativeString())
        {
            g_fn_GetPlayerCurweapon = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerTeam".GetNativeString())
        {
            g_fn_GetPlayerTeam = (delegate* unmanaged[Cdecl]<int, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerDeaths".GetNativeString())
        {
            g_fn_GetPlayerDeaths = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerMenu".GetNativeString())
        {
            g_fn_GetPlayerMenu = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerKeys".GetNativeString())
        {
            g_fn_GetPlayerKeys = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "IsPlayerAlive".GetNativeString())
        {
            g_fn_IsPlayerAlive = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerFrags".GetNativeString())
        {
            g_fn_GetPlayerFrags = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "IsPlayerConnecting".GetNativeString())
        {
            g_fn_IsPlayerConnecting = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "IsPlayerHLTV".GetNativeString())
        {
            g_fn_IsPlayerHLTV = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerArmor".GetNativeString())
        {
            g_fn_GetPlayerArmor = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerHealth".GetNativeString())
        {
            g_fn_GetPlayerHealth = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerFlags".GetNativeString())
        {
            g_fn_GetPlayerFlags = (delegate* unmanaged[Cdecl]<int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "GetPlayerEdict".GetNativeString())
        {
            g_fn_GetPlayerEdict = (delegate* unmanaged[Cdecl]<int, edict_t*>)reqFnptrFunc(funName);
        }
        using (var funName = "amx_Push".GetNativeString())
        {
            g_fn_AmxPush = (delegate* unmanaged[Cdecl]<AMX*, int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "SetPlayerTeamInfo".GetNativeString())
        {
            g_fn_SetTeamInfo = (delegate* unmanaged[Cdecl]<int, int, sbyte*, int>)reqFnptrFunc(funName);
        }
        using (var funName = "PlayerPropAddr".GetNativeString())
        {
            g_fn_PlayerPropAddr = (delegate* unmanaged[Cdecl]<int, int, void*>)reqFnptrFunc(funName);
        }
        using (var funName = "RegAuthFunc".GetNativeString())
        {
            g_fn_RegAuthFunc = (delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<int, sbyte*, void>, void>)reqFnptrFunc(funName);
        }
        using (var funName = "UnregAuthFunc".GetNativeString())
        {
            g_fn_UnregAuthFunc = (delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<int, sbyte*, void>, void>)reqFnptrFunc(funName);
        }
        using (var funName = "FindLibrary".GetNativeString())
        {
            g_fn_FindLibrary = (delegate* unmanaged[Cdecl]<sbyte*, LibType, int>)reqFnptrFunc(funName);
        }
        using (var funName = "AddLibraries".GetNativeString())
        {
            g_fn_AddLibraries = (delegate* unmanaged[Cdecl]<sbyte*, LibType, void*, uint>)reqFnptrFunc(funName);
        }
        using (var funName = "RemoveLibraries".GetNativeString())
        {
            g_fn_RemoveLibraries = (delegate* unmanaged[Cdecl]<void*, uint>)reqFnptrFunc(funName);
        }
        using (var funName = "OverrideNatives".GetNativeString())
        {
            g_fn_OverrideNatives = (delegate* unmanaged[Cdecl]<AMX_NATIVE_INFO*, sbyte*, void>)reqFnptrFunc(funName);
        }
        using (var funName = "GetLocalInfo".GetNativeString())
        {
            g_fn_GetLocalInfo = (delegate* unmanaged[Cdecl]<sbyte*, sbyte*, sbyte*>)reqFnptrFunc(funName);
        }
        using (var funName = "AmxReregister".GetNativeString())
        {
            g_fn_AmxReRegister = (delegate* unmanaged[Cdecl]<AMX*, AMX_NATIVE_INFO*, int, int>)reqFnptrFunc(funName);
        }
        using (var funName = "MessageBlock".GetNativeString())
        {
            g_fn_MessageBlock = (delegate* unmanaged[Cdecl]<int, int, int*, void>)reqFnptrFunc(funName);
        }
        Plugin.FN_AMXX_ATTACH();
        return AMXX_OK;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_Detach", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_Detach()
    {
        Plugin.FN_AMXX_DETACH();
        return AMXX_OK;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_PluginsLoaded", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_PluginsLoaded()
    {
        Plugin.FN_AMXX_PLUGINSLOADED();
        return AMXX_OK;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_PluginsUnloaded", CallConvs = [typeof(CallConvCdecl)])]
    public static void AMXX_PluginsUnloaded()
    {
        Plugin.FN_AMXX_PLUGINSUNLOADED();
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_PluginsUnloading", CallConvs = [typeof(CallConvCdecl)])]
    public static void AMXX_PluginsUnloading()
    {
        Plugin.FN_AMXX_PLUGINSUNLOADING();
    }

}
