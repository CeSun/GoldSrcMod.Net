using GoldSrc.HLSDK.Native;

namespace GoldSrc.MetaMod.Native;
public unsafe struct META_FUNCTIONS
{
    public delegate* unmanaged[Cdecl]<DLL_FUNCTIONS*, int, int> pfnGetEntityAPI;
    public delegate* unmanaged[Cdecl]<DLL_FUNCTIONS*, int, int> pfnGetEntityAPI_Post;
    public delegate* unmanaged[Cdecl]<DLL_FUNCTIONS*, int*, int> pfnGetEntityAPI2;
    public delegate* unmanaged[Cdecl]<DLL_FUNCTIONS*, int*, int> pfnGetEntityAPI2_Post;
    public delegate* unmanaged[Cdecl]<NEW_DLL_FUNCTIONS*, int*, int> pfnGetNewDLLFunctions;
    public delegate* unmanaged[Cdecl]<NEW_DLL_FUNCTIONS*, int*, int> pfnGetNewDLLFunctions_Post;
    public delegate* unmanaged[Cdecl]<enginefuncs_t*, int*, int> pfnGetEngineFunctions;
    public delegate* unmanaged[Cdecl]<enginefuncs_t*, int*, int> pfnGetEngineFunctions_Post;
}
