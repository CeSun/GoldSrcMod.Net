namespace GoldSrc.HLSDK.Native;

public unsafe struct IVoiceTweak
{
    public delegate* unmanaged[Cdecl]<int> StartVoiceTweakMode;
    public delegate* unmanaged[Cdecl]<void> EndVoiceTweakMode;
    public delegate* unmanaged[Cdecl]<VoiceTweakControl, float, void> SetControlFloat;
    public delegate* unmanaged[Cdecl]<VoiceTweakControl, float> GetControlFloat;
    public delegate* unmanaged[Cdecl]<int> GetSpeakingVolume;
}
public enum VoiceTweakControl
{
    MicrophoneVolume = 0,           // values 0-1.
    OtherSpeakerScale,          // values 0-1. Scales how loud other players are.
    MicBoost,					// 20 db gain to voice input
};