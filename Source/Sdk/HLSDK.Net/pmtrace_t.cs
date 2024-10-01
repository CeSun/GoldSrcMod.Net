using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct pmtrace_t
{
    public int allsolid;        // if true, plane is not valid
    public int startsolid;          // if true, the initial point was in a solid area
    public int inopen, inwater;  // End point is in empty space or in water
    public float fraction;       // time completed, 1.0 = didn't hit anything
    public fixed float endpos[3];            // final position
    public pmplane_t plane;              // surface normal at impact
    public int ent;              // entity at impact
    public fixed float deltavelocity[3];   // Change in player's velocity caused by impact.  
                                           // Only run on server.
    public int hitgroup;
}
