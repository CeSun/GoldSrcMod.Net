using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct mtexinfo_t
{
    public fixed float vecs[2 * 4];     // [s/t] unit vectors in world space. 
                                        // [i][3] is the s/t offset relative to the origin.
                                        // s or t = dot(3Dpoint,vecs[i])+vecs[i][3]
    public float mipadjust;        // ?? mipmap limits for very small surfaces
    public texture_t* texture;
    public int flags;
}
