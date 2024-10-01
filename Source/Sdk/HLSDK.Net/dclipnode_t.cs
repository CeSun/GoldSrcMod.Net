using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct dclipnode_t
{
    public int planenum;
    public fixed short children[2];	// negative numbers are contents
}
