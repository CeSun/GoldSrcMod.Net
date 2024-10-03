namespace GoldSrc.HLSDK.Native;

public unsafe struct event_api_t
{
    public int version;
    public delegate* unmanaged[Cdecl]<int, float*, int, sbyte*, float, float, int, int, void> EV_PlaySound;
    public delegate* unmanaged[Cdecl]<int, int, sbyte*, void> EV_StopSound;
    public delegate* unmanaged[Cdecl]<sbyte*, int> EV_FindModelIndex;
    public delegate* unmanaged[Cdecl]<int, int> EV_IsLocal;
    public delegate* unmanaged[Cdecl]<int> EV_LocalPlayerDucking;
    public delegate* unmanaged[Cdecl]<float*, void> EV_LocalPlayerViewheight;
    public delegate* unmanaged[Cdecl]<int, float*, float*, void> EV_LocalPlayerBounds;
    public delegate* unmanaged[Cdecl]<pmtrace_t*, int> EV_IndexFromTrace;
    public delegate* unmanaged[Cdecl]<int, physent_t*> EV_GetPhysent;
    public delegate* unmanaged[Cdecl]<int, int, void> EV_SetUpPlayerPrediction;
    public delegate* unmanaged[Cdecl]<void> EV_PushPMStates;
    public delegate* unmanaged[Cdecl]<void> EV_PopPMStates;
    public delegate* unmanaged[Cdecl]<int, void> EV_SetSolidPlayers;
    public delegate* unmanaged[Cdecl]<int, void> EV_SetTraceHull;
    public delegate* unmanaged[Cdecl]<float*, float*, int, int, pmtrace_t*, void> EV_PlayerTrace;
    public delegate* unmanaged[Cdecl]<int, int, void> EV_WeaponAnimation;
    public delegate* unmanaged[Cdecl]<int, sbyte*, ushort> EV_PrecacheEvent;
    public delegate* unmanaged[Cdecl]<int, edict_t *, ushort, float, float*, float*, float, float, int, int, int, int, void> EV_PlaybackEvent;
    public delegate* unmanaged[Cdecl]<int, float*, float*, sbyte*> EV_TraceTexture;
    public delegate* unmanaged[Cdecl]<int, int, void> EV_StopAllSounds;
    public delegate* unmanaged[Cdecl]<int, sbyte*, void> EV_KillEvents;

}
