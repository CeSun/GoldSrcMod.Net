using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.Amxmodx.Native;

public unsafe struct amxx_module_info_t
{
    public sbyte* name;
    public sbyte* author;
    public sbyte* version;
    public int reload;             // reload on mapchange when nonzero
    public sbyte* logtag;     // added in version 2
    public sbyte* library;    // added in version 4
    public sbyte* libclass;	// added in version 4
}
