using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;
public unsafe struct mstudioevent_t
{
    public int frame;
    public int @event;
    public int type;
    public fixed sbyte options[64];
}
