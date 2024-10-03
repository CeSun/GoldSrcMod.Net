

using GoldSrc.HLSDK.Native;

namespace GoldSrc.MetaMod.Native;

public unsafe struct mutil_funcs_t
{
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, void> pfnLogConsole;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, void> pfnLogMessage;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, void> pfnLogError;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, void> pfnLogDeveloper;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, void> pfnCenterSay;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, hudtextparms_t, sbyte*, void> pfnCenterSayParms;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, hudtextparms_t, sbyte*, sbyte*, void> pfnCenterSayVarargs;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, entvars_t*, qboolean> pfnCallGameEntity;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, int*, int> pfnGetUserMsgID;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, int, int*, sbyte*> pfnGetUserMsgName;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*> pfnGetPluginPath;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, ginfo_t, sbyte*> pfnGetGameInfo;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, PLUG_LOADTIME, void**, int> pfnLoadPlugin;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, sbyte*, PLUG_LOADTIME, PL_UNLOAD_REASON, int> pfnUnloadPlugin;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, void*, PLUG_LOADTIME, PL_UNLOAD_REASON, int> pfnUnloadPluginByHandle;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, edict_t*, sbyte*> pfnIsQueryingClientCvar;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, int> pfnMakeRequestId;
    public delegate* unmanaged[Cdecl]<plugin_info_t*, enginefuncs_t**, DLL_FUNCTIONS**, NEW_DLL_FUNCTIONS**, void> pfnGetHookTables;
}
