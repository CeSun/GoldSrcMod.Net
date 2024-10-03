using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct cvar_t
{
    public sbyte* name;
    public sbyte* @string;
    public int flags;
    public float value;
    public cvar_t* next;
}
