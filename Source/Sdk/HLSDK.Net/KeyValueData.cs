using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct KeyValueData
{
    public sbyte* szClassName;  // in: entity classname
    public sbyte* szKeyName;        // in: name of key
    public sbyte* szValue;      // in: value of key
    public int fHandled;		// out: DLL sets to true if key-value pair was understood
}
