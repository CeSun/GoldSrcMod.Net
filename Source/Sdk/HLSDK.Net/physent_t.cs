using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct physent_t
{
    public fixed sbyte name[32];             // Name of model, or "player" or "world".
    public int player;
    public vec3_t origin;               // Model's origin in world coordinates.
    public model_t  *model;               // only for bsp models
    public model_t  *studiomodel;         // SOLID_BBOX, but studio clip intersections.
    public vec3_t mins, maxs;            // only for non-bsp models
    public int info;                 // For client or server to use to identify (index into edicts or cl_entities)
    public vec3_t angles;               // rotated entities need this info for hull testing to work.

    public int solid;                // Triggers and func_door type WATER brushes are SOLID_NOT
    public int skin;                 // BSP Contents for such things like fun_door water brushes.
    public int rendermode;           // So we can ignore glass

    // Complex collision detection.
    public float frame;
    public int sequence;
    public fixed byte controller[4];
    public fixed byte blending[2];

    public int movetype;
    public int takedamage;
    public int blooddecal;
    public int team;
    public int classnumber;

    // For mods
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
