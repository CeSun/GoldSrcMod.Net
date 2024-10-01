using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct SCREENINFO
{
    public int iSize;
    public int iWidth;
    public int iHeight;
    public int iFlags;
    public int iCharHeight;
    public fixed short charWidths[256];
}
