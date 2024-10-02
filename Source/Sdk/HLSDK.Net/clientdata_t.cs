using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct clientdata_t
{
    public vec3_t origin;
    public vec3_t velocity;

    public int viewmodel;
    public vec3_t punchangle;
    public int flags;
    public int waterlevel;
    public int watertype;
    public vec3_t view_ofs;
    public float health;

    public int bInDuck;

    public int weapons; // remove?

    public int flTimeStepSound;
    public int flDuckTime;
    public int flSwimTime;
    public int waterjumptime;

    public float maxspeed;

    public float fov;
    public int weaponanim;

    public int m_iId;
    public int ammo_shells;
    public int ammo_nails;
    public int ammo_cells;
    public int ammo_rockets;
    public float m_flNextAttack;

    public int tfstate;

    public int pushmsec;

    public int deadflag;

    public fixed sbyte physinfo[256];

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
