using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct TEMPENTITY
{
    public int flags;
    public float die;
    public float frameMax;
    public float x;
    public float y;
    public float z;
    public float fadeSpeed;
    public float bounceFactor;
    public int hitSound;
    public delegate* unmanaged[Cdecl]<tempent_t*, pmtrace_t*, void> hitcallback;
    public delegate* unmanaged[Cdecl]<tempent_t*, float, float, void> callback;
    public tempent_t    *next;
    public int priority;
    public short clientIndex;

    public vec3_t tentOffset;
    public cl_entity_t entity;

}
