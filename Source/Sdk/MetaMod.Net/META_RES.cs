using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.MetaMod.Native;

public enum META_RES
{
    MRES_UNSET = 0,
    MRES_IGNORED,       // plugin didn't take any action
    MRES_HANDLED,       // plugin did something, but real function should still be called
    MRES_OVERRIDE,      // call real function, but use my return value
    MRES_SUPERCEDE,		// skip real function; use my return value
}
