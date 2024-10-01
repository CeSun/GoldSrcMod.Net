using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct efrag_t
{
    public mleaf_t *leaf;
    public efrag_t* leafnext;
    public cl_entity_t* entity;
    public efrag_t* entnext;
}
