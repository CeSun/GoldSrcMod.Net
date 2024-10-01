using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct sequenceEntry_t
{
    public sbyte* fileName;     // Name of sequence file without .SEQ extension
    public sbyte* entryName;        // Name of entry label in file
    public sequenceCommandLine_t* firstCommand;    // Linked list of commands in entry
    public sequenceEntry_t* nextEntry;     // Next loaded entry
    public int isGlobal;		// Is entry retained over level transitions?
}
