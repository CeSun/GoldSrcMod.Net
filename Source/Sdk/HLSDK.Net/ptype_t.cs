using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public enum ptype_t
{
    pt_static,
    pt_grav,
    pt_slowgrav,
    pt_fire,
    pt_explode,
    pt_explode2,
    pt_blob,
    pt_blob2,
    pt_vox_slowgrav,
    pt_vox_grav,
    pt_clientcustom   // Must have callback function specified
}
