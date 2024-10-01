using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public struct mouth_t
{
    public byte mouthopen;     // 0 = mouth closed, 255 = mouth agape
    public byte sndcount;      // counter for running average
    public int sndavg;			// running average
}
