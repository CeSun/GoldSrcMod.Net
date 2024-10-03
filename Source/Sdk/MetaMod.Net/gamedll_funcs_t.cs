using GoldSrc.HLSDK.Native;

namespace GoldSrc.MetaMod.Native;
public unsafe struct gamedll_funcs_t
{
    public DLL_FUNCTIONS* dllapi_table;
    public NEW_DLL_FUNCTIONS* newapi_table;
}
