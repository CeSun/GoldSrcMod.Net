using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckWorld.HLSDK.Native;

public struct IVoiceTweak
{
    public nint StartVoiceTweakMode;
    public nint EndVoiceTweakMode;
    public nint SetControlFloat;
    public nint GetControlFloat;
    public nint GetSpeakingVolume;
}
