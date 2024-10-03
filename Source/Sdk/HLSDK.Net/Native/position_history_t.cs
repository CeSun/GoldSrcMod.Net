using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct position_history_t
{
    public float animtime;

    public vec3_t origin;
    public vec3_t angle;
}
