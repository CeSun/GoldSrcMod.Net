using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct mleaf_t
{// leaf specific
    public byte* compressed_vis;
    public efrag_t  *efrags;

    public msurface_t** firstmarksurface;
    public int nummarksurfaces;
    public int key;            // BSP sequence number for leaf's contents
    public fixed byte ambient_sound_level[4];
}
