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
        

        return 1;
    }


    [UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
    public static int Meta_Attach(PLUG_LOADTIME now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
    public static int Meta_Detach(PLUG_LOADTIME now, PL_UNLOAD_REASON reason)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GiveFnptrsToDll", CallConvs = [typeof(CallConvStdcall)])]
    public static void GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
    {

    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_Query", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_Query(nint interfaceVersion, nint moduleInfo)
    {
        return 1;
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
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "AMXX_PluginsLoaded", CallConvs = [typeof(CallConvCdecl)])]
    public static int AMXX_PluginsLoaded()
    {
        return 1;
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


public struct PLUG_LOADTIME
{

}

public struct PL_UNLOAD_REASON
{

}