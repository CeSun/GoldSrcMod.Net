using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct hudtextparms_t
{
    public float x;
    public float y;
    public  int effect;
    public byte r1, g1, b1, a1;
    public byte r2, g2, b2, a2;
    public float fadeinTime;
    public float fadeoutTime;
    public float holdTime;
    public float fxTime;
    public int channel;
}
