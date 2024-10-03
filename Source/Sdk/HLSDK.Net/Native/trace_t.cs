using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct trace_t
{
    public qboolean allsolid;        // if true, plane is not valid
    public qboolean startsolid;          // if true, the initial point was in a solid area
    public qboolean inopen, inwater;  // End point is in empty space or in water
    public float fraction;       // time completed, 1.0 = didn't hit anything
    public vec3_t endpos;            // final position
    public pmplane_t plane;              // surface normal at impact
    public int ent;              // entity at impact
    public vec3_t deltavelocity;    // Change in player's velocity caused by impact.  
                                    // Only run on server.
    public int hitgroup;
}
