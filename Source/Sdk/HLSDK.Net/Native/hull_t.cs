using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct hull_t
{
    public dclipnode_t* clipnodes;
    public mplane_t* planes;
    public int firstclipnode;
    public int lastclipnode;
    public vec3_t clip_mins;
    public vec3_t clip_maxs;
}
