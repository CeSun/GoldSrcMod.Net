using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct r_studio_interface_t
{
    public int version;
    public delegate* unmanaged[Cdecl]<int, int> StudioDrawModel;
    public delegate* unmanaged[Cdecl]<int, entity_state_t*, int> StudioDrawPlayer;

}
