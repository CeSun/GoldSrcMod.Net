using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct latchedvars_t
{
    public float prevanimtime;
    public float sequencetime;
    public fixed byte prevseqblending[2];
    public fixed float prevorigin[3];
    public fixed float prevangles[3];

    public int prevsequence;
    public float prevframe;

    public fixed byte prevcontroller[4];
    public fixed byte prevblending[2];
}
