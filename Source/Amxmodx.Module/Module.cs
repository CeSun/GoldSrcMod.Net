using GoldSrc.Amxmodx.Native;
using GoldSrc.HLSDK;
using GoldSrc.HLSDK.Native;
using GoldSrc.MetaMod.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Module.Global;

namespace Module;

public unsafe static class Module
{
    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEntityAPI2(DLL_FUNCTIONS* pFunctionTable, int* interfaceVersion)
    {
        if (pFunctionTable == null)
            return False;
        if (*interfaceVersion != INTERFACE_VERSION)
        {
            *interfaceVersion = INTERFACE_VERSION;
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
        if (*interfaceVersion != INTERFACE_VERSION)
        {
            *interfaceVersion = INTERFACE_VERSION;
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
        if (*interfaceVersion != ENGINE_INTERFACE_VERSION)
        {
            *interfaceVersion = ENGINE_INTERFACE_VERSION;
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
        if (*interfaceVersion != ENGINE_INTERFACE_VERSION)
        {
            *interfaceVersion = ENGINE_INTERFACE_VERSION;
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
        if (*interfaceVersion != NEW_DLL_FUNCTIONS_VERSION)
        {
            *interfaceVersion = NEW_DLL_FUNCTIONS_VERSION;
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
        if (*interfaceVersion != NEW_DLL_FUNCTIONS_VERSION)
        {
            *interfaceVersion = NEW_DLL_FUNCTIONS_VERSION;
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

        list = META_INTERFACE_VERSION.Split(":");
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
        return True;
    }

    [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
    public static int Meta_Detach(PLUG_LOADTIME now, PL_UNLOAD_REASON reason)
    {
        if (now > Plugin_info->unloadable && reason != PL_UNLOAD_REASON.PNL_CMD_FORCED)
            return False;
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
        if (*interfaceVersion != AMXX_INTERFACE_VERSION)
        {
            *interfaceVersion = AMXX_INTERFACE_VERSION;
            return AMXX_IFVERS;
        }
        *moduleInfo = g_ModuleInfo;

        return AMXX_OK;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_CheckGame", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_CheckGame(nint game)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_Attach", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_Attach(nint reqFnptrFunc)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_Detach", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_Detach()
    {
        return AMXX_OK;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_PluginsLoaded", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_PluginsLoaded()
    {
        return AMXX_OK;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_PluginsUnloaded", CallConvs = [typeof(CallConvCdecl)])]
    public static void AMXX_PluginsUnloaded()
    {
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_PluginsUnloading", CallConvs = [typeof(CallConvCdecl)])]
    public static void AMXX_PluginsUnloading()
    {

    }

}
