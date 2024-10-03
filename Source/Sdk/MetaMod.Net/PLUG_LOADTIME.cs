using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.MetaMod.Native;

public enum PLUG_LOADTIME
{
    PT_NEVER = 0,
    PT_STARTUP,         // should only be loaded/unloaded at initial hlds execution
    PT_CHANGELEVEL,     // can be loaded/unloaded between maps
    PT_ANYTIME,         // can be loaded/unloaded at any time
    PT_ANYPAUSE,		// can be loaded/unloaded at any time, and can be "paused" during a map
}