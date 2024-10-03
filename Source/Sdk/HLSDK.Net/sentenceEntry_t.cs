using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct sentenceEntry_t
{
    public sbyte* data;         // sentence data (ie "We have hostiles" )
    public sentenceEntry_t* nextEntry;     // Next loaded entry
    public qboolean isGlobal;      // Is entry retained over level transitions?
    public uint index;			// this entry's position in the file.
}
