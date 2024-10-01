using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct client_sprite_t
{
    public fixed sbyte szName[64];
    public fixed sbyte szSprite[64];
    public int hspr;
    public int iRes;
    public wrect_t rc;
}
