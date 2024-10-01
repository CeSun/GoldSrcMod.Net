using GoldSrc.Metahook.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Plugin;

public class PluginV2
{
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void Init(nint self, metahook_api_t* pAPI, mh_interface_t* pInterface, mh_enginesave_t* pSave)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void LoadEngine(nint self)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void LoadClient(nint self, cl_exportfuncs_t* pExportFunc)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void ExitGame(nint self, int iResult)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void Shutdown(nint self)
    {

    }


    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvThiscall)])]
    public static unsafe void Destructor(nint self)
    {

    }
}
