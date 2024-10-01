using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct edict_t
{
    public int free;
    public int serialnumber;
    public link_t area;                // linked to a division node or leaf

    public int headnode;           // -1 to use normal leaf check
    public int num_leafs;
    public fixed short leafnums[48];

    public float freetime;         // sv.time when the object was freed

    public void* pvPrivateData;		// Alloced and freed by engine, used by DLLs

    public entvars_t v;
}
