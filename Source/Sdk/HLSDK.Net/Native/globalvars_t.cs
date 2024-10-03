

namespace GoldSrc.HLSDK.Native;

public unsafe struct globalvars_t
{
    public float time;
    public float frametime;
    public float force_retouch;
    public string_t mapname;
    public string_t startspot;
    public float deathmatch;
    public float coop;
    public float teamplay;
    public float serverflags;
    public float found_secrets;
    public vec3_t v_forward;
    public vec3_t v_up;
    public vec3_t v_right;
    public float trace_allsolid;
    public float trace_startsolid;
    public float trace_fraction;
    public vec3_t trace_endpos;
    public vec3_t trace_plane_normal;
    public float trace_plane_dist;
    public edict_t* trace_ent;
    public float trace_inopen;
    public float trace_inwater;
    public int trace_hitgroup;
    public int trace_flags;
    public int msg_entity;
    public int cdAudioTrack;
    public int maxClients;
    public int maxEntities;
    public sbyte* pStringBase;
    public void* pSaveData;
    public vec3_t vecLandmarkOffset;
}
