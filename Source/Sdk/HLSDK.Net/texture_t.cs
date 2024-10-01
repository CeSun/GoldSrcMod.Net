using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct texture_t
{
    public fixed sbyte name[16];
    public uint width, height;
    public int anim_total;             // total tenths in sequence ( 0 = no)
    public int anim_min, anim_max;     // time for this frame min <=time< max
    public texture_t* anim_next;        // in the animation sequence
    public texture_t* alternate_anims;  // bmodels in frame 1 use these
    public fixed uint offsets[4];        // four mip maps stored
    public uint paloffset;

}
