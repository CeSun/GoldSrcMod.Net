using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct mnode_t
{
    // common with leaf
    public int contents;       // 0, to differentiate from leafs
    public int visframe;       // node needs to be traversed if current

    public fixed short minmaxs[6];       // for bounding box culling

    public mnode_t  *parent;

    // node specific
    public mplane_t* plane;
    public mnode_t* children_0;
    public mnode_t* children_1;

    public ushort firstsurface;
    public ushort numsurfaces;
}
