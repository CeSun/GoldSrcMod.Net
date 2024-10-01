using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct medge_t
{
    public fixed ushort v[2];
    public uint cachededgeoffset;
}
