using System.Runtime.InteropServices;

namespace GoldSrc.Amxmodx.Native;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AMX_NATIVE_INFO
{
    public sbyte* name;
    public nint func;
}
