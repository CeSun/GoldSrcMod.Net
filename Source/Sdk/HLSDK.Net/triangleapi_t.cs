namespace GoldSrc.HLSDK.Native;

public unsafe struct triangleapi_t
{
    public int version;
    public delegate* unmanaged[Cdecl]<int, void> RenderMode;
    public delegate* unmanaged[Cdecl]<int, void> Begin;
    public delegate* unmanaged[Cdecl]<void> End;


    public delegate* unmanaged[Cdecl]<float, float, float, float, void> Color4f;
    public delegate* unmanaged[Cdecl]<byte, byte, byte, byte, void> Color4ub;
    public delegate* unmanaged[Cdecl]<float*, void> Vertex3fv;
    public delegate* unmanaged[Cdecl]<float, float, float, void> Vertex3f;
    public delegate* unmanaged[Cdecl]<float, void> Brightness;
    public delegate* unmanaged[Cdecl]<TRICULLSTYLE, void> CullFace;
    public delegate* unmanaged[Cdecl]<model_t*, int, void> SpriteTexture;
    public delegate* unmanaged[Cdecl]<float*, float*, int> WorldToScreen;
    public delegate* unmanaged[Cdecl]<float*, float, float, float> Fog;
    public delegate* unmanaged[Cdecl]<float*, float*, void> ScreenToWorld;

    public delegate* unmanaged[Cdecl]<int, float*, void> GetMatrix;
    public delegate* unmanaged[Cdecl]<float*, float*, void> BoxInPVS;
    public delegate* unmanaged[Cdecl]<float*, float*, void> LightAtPoint;

    public delegate* unmanaged[Cdecl]<float, float, float, float, int, void> Color4fRendermode;
    public delegate* unmanaged[Cdecl]<float, int, void> FogParams;

}

public enum TRICULLSTYLE
{
    TRI_FRONT = 0,
    TRI_NONE = 1,
}