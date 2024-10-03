using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct con_nprint_t
{
    public int index;          // Row #
    public float time_to_live; // # of seconds before it dissappears
    public fixed float color[3];		// RGB colors ( 0.0 -> 1.0 scale )
}
