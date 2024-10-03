using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct ENTITYTABLE
{
    public int id;             // Ordinal ID of this entity (used for entity <--> pointer conversions)
    public edict_t* pent;          // Pointer to the in-game entity

    public int location;       // Offset from the base data of this entity
    public int size;           // Byte size of this entity's data
    public int flags;          // This could be a short -- bit mask of transitions that this entity is in the PVS of
    public string_t classname;
}
