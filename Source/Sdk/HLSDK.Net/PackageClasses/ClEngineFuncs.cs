using GoldSrc.HLSDK.Native;
using System.Runtime.InteropServices;

namespace GoldSrc.HLSDK.PackageClasses;

public unsafe class ClEngineFuncs : NativePackageClass<cl_enginefuncs_t>
{
    
    public ClEngineFuncs(ref cl_enginefuncs_t enginefuncs) : base(ref enginefuncs)
    {
    }

    public ClEngineFuncs(cl_enginefuncs_t* enginefuncs) : base(enginefuncs)
    {

    }

    public int pfnSPR_Load( string szPicName)
    {
        using (var str = szPicName.GetNativeString())
        {
            return NativePointer->pfnSPR_Load(str);
        }
    }

    public unsafe List<ClientSprite> pfnSPR_GetList(string psz)
    {
        int count = 0;
        using (var str = psz.GetNativeString())
        {
            client_sprite_t* p = NativePointer->pfnSPR_GetList(str, &count);
            List<ClientSprite> list =  new List<ClientSprite>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new ClientSprite(ref p[i]));
            }
            return list;
        }
    }
}
