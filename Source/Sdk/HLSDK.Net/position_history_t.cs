using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct position_history_t
{
    public float animtime;

    public fixed float origin[3];
    public fixed float angle[3];
}
