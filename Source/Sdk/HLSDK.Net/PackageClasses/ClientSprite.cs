using GoldSrc.HLSDK.Native;
using System.Runtime.InteropServices;
using System.Text;

namespace GoldSrc.HLSDK.PackageClasses;

public unsafe class ClientSprite : NativePackageClass<client_sprite_t>
{
    public ClientSprite(client_sprite_t* nativePointer) : base(nativePointer) {}

    public ClientSprite(ref client_sprite_t clientSprite) : base(ref clientSprite) {}

    public string Name
    {
        get => Marshal.PtrToStringAnsi((nint)NativePointer->szName)??"";
        set => Encoding.Default.GetBytes(value, new Span<byte>(NativePointer->szName, 64));
    }

    public string Sprite
    {
        get => Marshal.PtrToStringAnsi((nint)NativePointer->szSprite) ?? "";
        set => Encoding.Default.GetBytes(value, new Span<byte>(NativePointer->szSprite, 64));
    }

    public int HSpr
    {
        get => NativePointer->hspr;
        set => NativePointer->hspr = value;
    }
    public int Res
    {
        get => NativePointer->iRes;
        set => NativePointer->iRes = value;
    }

    public wrect_t Rect
    {
        get => NativePointer->rc; 
        set => NativePointer->rc = value;
    }
}
