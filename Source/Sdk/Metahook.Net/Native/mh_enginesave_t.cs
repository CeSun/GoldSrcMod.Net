using GoldSrc.HLSDK.Native;

namespace GoldSrc.Metahook.Native;

public unsafe struct mh_enginesave_t
{
    public cl_exportfuncs_t* pExportFuncs;
    public cl_enginefunc_t* pEngineFuncs;
}
