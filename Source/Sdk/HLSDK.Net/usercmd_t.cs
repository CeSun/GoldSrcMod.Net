using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct usercmd_t
{
    public short lerp_msec;      // Interpolation time on client
    public byte msec;           // Duration in ms of command
    public vec3_t viewangles;     // Command view angles.

    // intended velocities
    public float forwardmove;    // Forward velocity.
    public float sidemove;       // Sideways velocity.
    public float upmove;         // Upward velocity.
    public byte lightlevel;     // Light level at spot where we are standing.
    public ushort buttons;  // Attack buttons
    public byte impulse;          // Impulse command issued.
    public byte weaponselect;   // Current weapon id

    // Experimental player impact stuff.
    public int impact_index;
    public vec3_t impact_position;
}
