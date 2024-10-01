﻿namespace GoldSrc.HLSDK.Native;

public unsafe struct entity_state_t
{
    public int entityType;
    public int number;
    public float msg_time;
    public int messagenum;
    public vec3_t origin;
    public vec3_t angles;

    public int modelindex;
    public int sequence;
    public float frame;
    public int colormap;
    public short skin;
    public short solid;
    public int effects;
    public float scale;
    public byte eflags;
    public int rendermode;
    public int renderamt;
    public color24 rendercolor;
    public int renderfx;
    public int movetype;
    public float animtime;
    public float framerate;
    public int body;
    public fixed byte controller[4];
    public fixed byte blending[4];
    public vec3_t velocity;
    public vec3_t mins;
    public vec3_t maxs;
    public int aiment;
    public int owner;
    public float friction;
    public float gravity;
    public int team;
    public int playerclass;
    public int health;
    public int spectator;
    public int weaponmodel;
    public int gaitsequence;
    public vec3_t basevelocity;
    public int usehull;
    public int oldbuttons;
    public int onground;
    public int iStepLeft;
    public float flFallVelocity;
    public float fov;
    public int weaponanim;
    public vec3_t startpos;
    public vec3_t endpos;
    public float impacttime;
    public float starttime;
    public int iuser1;
    public int iuser2;
    public int iuser3;
    public int iuser4;
    public float fuser1;
    public float fuser2;
    public float fuser3;
    public float fuser4;
    public vec3_t vuser1;
    public vec3_t vuser2;
    public vec3_t vuser3;
    public vec3_t vuser4;
}
