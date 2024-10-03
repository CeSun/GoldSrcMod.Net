using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct mplane_t
{
    public vec3_t normal;          // surface normal
    public float dist;         // closest appoach to origin
    public byte type;          // for texture axis selection and fast side tests
    public byte signbits;      // signx + signy<<1 + signz<<1
    public fixed byte pad[2];
}
