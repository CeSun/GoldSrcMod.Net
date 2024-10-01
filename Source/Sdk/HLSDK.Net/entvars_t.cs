using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct entvars_t
{
    public uint classname;
    public uint globalname;

    public fixed float origin[3];
    public fixed float oldorigin[3];
    public fixed float velocity[3];
    public fixed float basevelocity[3];
    public fixed float clbasevelocity[3];  // Base velocity that was passed in to server physics so 
                                           //  client can predict conveyors correctly.  Server zeroes it, so we need to store here, too.
    public fixed float movedir[3];

    public fixed float angles[3];          // Model angles
    public fixed float avelocity[3];       // angle velocity (degrees per second)
    public fixed float punchangle[3];      // auto-decaying view angle adjustment
    public fixed float v_angle[3];     // Viewing angle (player only)

    // For parametric entities
    public fixed float endpos[3];
    public fixed float startpos[3];
    public float impacttime;
    public float starttime;

    public int fixangle;       // 0:nothing, 1:force view angles, 2:add avelocity
    public float idealpitch;
    public float pitch_speed;
    public float ideal_yaw;
    public float yaw_speed;

    public int modelindex;
    public uint model;

    public int viewmodel;      // player's viewmodel
    public int weaponmodel;    // what other players see

    public fixed float absmin[3];      // BB max translated to world coord
    public fixed float absmax[3];      // BB max translated to world coord
    public fixed float mins[3];       // local BB min
    public fixed float maxs[3];       // local BB max
    public fixed float size[3];        // maxs - mins

    public float ltime;
    public float nextthink;

    public int movetype;
    public int solid;

    public int skin;
    public int body;           // sub-model selection for studiomodels
    public int effects;

    public float gravity;      // % of "normal" gravity
    public float friction;     // inverse elasticity of MOVETYPE_BOUNCE

    public int light_level;

    public int sequence;       // animation sequence
    public int gaitsequence;   // movement animation sequence for player (0 for none)
    public float frame;            // % playback position in animation sequences (0..255)
    public float animtime;     // world time when frame was set
    public float framerate;        // animation playback rate (-8x to 8x)
    public fixed byte controller[4]; // bone controller setting (0..255)
    public fixed byte blending[2];   // blending amount between sub-sequences (0..255)

    public float scale;            // sprite rendering scale (0..255)

    public int rendermode;
    public float renderamt;
    public fixed float rendercolor[3];
    public int renderfx;

    public float health;
    public float frags;
    public int weapons;  // bit mask for available weapons
    public float takedamage;

    public int deadflag;
    public fixed float view_ofsr[3];   // eye position

    public int button;
    public int impulse;

    public edict_t* chain;         // Entity pointer when linked into a linked list
    public edict_t* dmg_inflictor;
    public edict_t* enemy;
    public edict_t* aiment;        // entity pointer when MOVETYPE_FOLLOW
    public edict_t* owner;
    public edict_t* groundentity;

    public int spawnflags;
    public int flags;

    public int colormap;       // lowbyte topcolor, highbyte bottomcolor
    public int team;

    public float max_health;
    public float teleport_time;
    public float armortype;
    public float armorvalue;
    public int waterlevel;
    public int watertype;

    public uint target;
    public uint targetname;
    public uint netname;
    public uint message;

    public float dmg_take;
    public float dmg_save;
    public float dmg;
    public float dmgtime;

    public uint noise;
    public uint noise1;
    public uint noise2;
    public uint noise3;

    public float speed;
    public float air_finished;
    public float pain_finished;
    public float radsuit_finished;

    public edict_t* pContainingEntity;

    public int playerclass;
    public float maxspeed;

    public float fov;
    public int weaponanim;

    public int pushmsec;

    public int bInDuck;
    public int flTimeStepSound;
    public int flSwimTime;
    public int flDuckTime;
    public int iStepLeft;
    public float flFallVelocity;

    public int gamestate;

    public int oldbuttons;

    public int groupinfo;

    // For mods
    public int iuser1;
    public int iuser2;
    public int iuser3;
    public int iuser4;
    public float fuser1;
    public float fuser2;
    public float fuser3;
    public float fuser4;
    public fixed float vuser1[3];
    public fixed float vuser2[3];
    public fixed float vuser3[3];
    public fixed float vuser4[3];
    public edict_t* euser1;
    public edict_t* euser2;
    public edict_t* euser3;
    public edict_t* euser4;
}
