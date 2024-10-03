using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct particle_t
{
    // driver-usable fields
    public vec3_t org;
    public short color;
    public short packedColor;
    // drivers never touch the following fields
    public particle_t   *next;
    public vec3_t vel;
    public float ramp;
    public float die;
    public ptype_t type;

    public delegate* unmanaged[Cdecl]<particle_t*, void> deathfunc;
    // for pt_clientcusttom, we'll call this function each frame
    public delegate* unmanaged[Cdecl]<particle_t*, float, void> callback;


    // For deathfunc, etc.
    public byte context;
}
