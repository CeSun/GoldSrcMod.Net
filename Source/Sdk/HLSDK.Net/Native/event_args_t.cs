using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct event_args_t
{
    public int flags;

    // Transmitted
    public int entindex;

    public fixed float origin[3];
    public fixed float angles[3];
    public fixed float velocity[3];

    public int ducking;

    public float fparam1;
    public float fparam2;

    public int iparam1;
    public int iparam2;

    public int bparam1;
    public int bparam2;
}
