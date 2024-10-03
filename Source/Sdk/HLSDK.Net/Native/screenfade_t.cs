using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public struct screenfade_t
{
    public float fadeSpeed;        // How fast to fade (tics / second) (+ fade in, - fade out)
    public float fadeEnd;      // When the fading hits maximum
    public float fadeTotalEnd; // Total End Time of the fade (used for FFADE_OUT)
    public float fadeReset;        // When to reset to not fading (for fadeout and hold)
    public byte fader, fadeg, fadeb, fadealpha;    // Fade color
    public int fadeFlags;		// Fading flags
}
