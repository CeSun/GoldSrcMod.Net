using GoldSrc.HLSDK.Native;
using GoldSrc.Metahook.Native;

namespace Plugin;

public unsafe static class Global
{
    public static cl_exportfuncs_t gExportfuncs;
    public static mh_interface_t* g_pInterface;
    public static metahook_api_t* g_pMetaHookAPI;
    public static mh_enginesave_t* g_pMetaSave;
    public static cl_enginefuncs_t gEngfuncs;
}
