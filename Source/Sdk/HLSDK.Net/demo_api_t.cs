namespace GoldSrc.HLSDK.Native;

public unsafe struct demo_api_t
{
    public delegate* unmanaged[Cdecl]<int> IsRecording;
    public delegate* unmanaged[Cdecl]<int> IsPlayingback;
    public delegate* unmanaged[Cdecl]<int> IsTimeDemo;
    public delegate* unmanaged[Cdecl]<int, byte, void> WriteBuffer;
}
