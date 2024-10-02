using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct NEW_DLL_FUNCTIONS
{
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnOnFreeEntPrivateData;
    public delegate* unmanaged[Cdecl]<void> pfnGameShutdown;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*, int> pfnShouldCollide;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, void> pfnCvarValue;
    public delegate* unmanaged[Cdecl]<edict_t*, int, sbyte*, sbyte*, void> pfnCvarValue2;
}
