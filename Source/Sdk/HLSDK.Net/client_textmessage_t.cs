using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct client_textmessage_t
{
    public int effect;
    public byte r1, g1, b1, a1;
    public byte r2, g2, b2, a2;
    public float x;
    public float y;
    public float fadein;
    public float fadeout;
    public float holdtime;
    public float fxtime;
    public sbyte* pName;
    public sbyte* pMessage;
}
