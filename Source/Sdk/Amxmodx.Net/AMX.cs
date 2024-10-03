using System.Runtime.InteropServices;
#pragma warning disable CS8981
using cell = int;
#pragma warning restore CS8981

namespace GoldSrc.Amxmodx.Native;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct  AMX
{
    public byte* @base;
    public byte* data;
    public delegate* unmanaged[Cdecl]<AMX*, cell, cell*, cell*, void> callback;
    public delegate* unmanaged[Cdecl]<AMX*, int> debug;
    public cell cip;
    public cell frm;
    public cell hea;
    public cell hlw;
    public cell stk;
    public cell stp;
    public int flags;
    public fixed int usertags[4];
    public void* userdata_0;
    public void* userdata_1;
    public void* userdata_2;
    public void* userdata_3;
    public int error;
    public int paramcount;
    public cell pri;
    public cell alt;
    public cell reset_stk;
    public cell reset_hea;
    public cell sysreq_d;
    public int reloc_size;
    public int code_size;
}
