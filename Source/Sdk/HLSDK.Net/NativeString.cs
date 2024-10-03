
using System.Runtime.InteropServices;

namespace GoldSrc.HLSDK;


public static class StringHelper
{
    public unsafe static NativeString GetNativeString(this string s) => new NativeString() { c_str = (sbyte*)Marshal.StringToHGlobalAnsi(s) };

}

public unsafe struct NativeString : IDisposable
{
    internal sbyte* c_str;
    public void Dispose() => Marshal.FreeHGlobal((nint)c_str);
    public static implicit operator sbyte*(NativeString d) => d.c_str;
    public static implicit operator byte*(NativeString d) => (byte*)d.c_str;
    public static implicit operator nint(NativeString d) => (nint)d.c_str;
}