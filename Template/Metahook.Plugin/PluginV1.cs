using GoldSrc.HLSDK.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Plugin;

public class PluginV1
{
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void Init(nint self, cl_exportfuncs_t* pSave)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void Shutdown(nint self, int restart)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void Destructor(nint self)
    {

    }
}
