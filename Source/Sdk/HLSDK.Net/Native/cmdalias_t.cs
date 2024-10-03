using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct cmdalias_t
{
    public cmdalias_t* next;
    public fixed sbyte name[32];
    public sbyte* value;
}
