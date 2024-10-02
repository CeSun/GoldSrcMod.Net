using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Module;

public static class Module
{
    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEntityAPI2(nint pFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEntityAPI2_Post", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEntityAPI2_Post(nint pFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEngineFunctions(nint pFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetEngineFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetEngineFunctions_Post(nint pFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetNewDLLFunctions(nint pNewFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "GetNewDLLFunctions_Post", CallConvs = [typeof(CallConvCdecl)])]
    public static int GetNewDLLFunctions_Post(nint pNewFunctionTable, nint interfaceVersion)
    {
        return 1;
    }

    [UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
    public static int Meta_Query(nint ifvers, nint pPlugInfo, nint pMetaUtilFuncs)
    {
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