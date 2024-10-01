using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct dmodel_t
{
    public fixed float mins[3];
    public fixed float maxs[3];
    public fixed float origin[3];
    public fixed int headnode[4];
    public int visleafs;       // not including the solid leaf 0
    public int firstface, numfaces;
}
