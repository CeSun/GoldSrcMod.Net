namespace GoldSrc.HLSDK.Native;
public unsafe struct BEAM
{
    public BEAM* next;
    public int type;
    public int flags;
    public vec3_t source;
    public vec3_t target;
    public vec3_t delta;
    public float t;        // 0 .. 1 over lifetime of beam
    public float freq;
    public float die;
    public float width;
    public float amplitude;
    public float r, g, b;
    public float brightness;
    public float speed;
    public float frameRate;
    public float frame;
    public int segments;
    public int startEntity;
    public int endEntity;
    public int modelIndex;
    public int frameCount;
    public model_t      *pFollowModel;
    public particle_t   *particles;
}
