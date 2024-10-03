using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct dlight_t
{
    public vec3_t origin;
    public float radius;
    public color24 color;
    public float die;              // stop lighting after this time
    public float decay;                // drop this each second
    public float minlight;         // don't add when contributing less
    public int key;
    public qboolean dark;			// subtracts light instead of adding
}
