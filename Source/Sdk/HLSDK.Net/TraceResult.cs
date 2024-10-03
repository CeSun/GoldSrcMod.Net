using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct  TraceResult
{
    public int fAllSolid;          // if true, plane is not valid
    public int fStartSolid;        // if true, the initial point was in a solid area
    public int fInOpen;
    public int fInWater;
    public float flFraction;           // time completed, 1.0 = didn't hit anything
    public vec3_t vecEndPos;           // final position
    public float flPlaneDist;
    public vec3_t vecPlaneNormal;      // surface normal at impact
    public edict_t* pHit;              // entity the surface is on
    public int iHitgroup;			// 0 == generic, non zero is specific body part
}
