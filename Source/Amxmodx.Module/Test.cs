using GoldSrc.Amxmodx.Framework.Attributes;

namespace Module;

public static class Test
{
    // 自动注册
    [AmxxNative]
    public static int AddInt(int a, int b) => a + b;

    [AmxxNative]
    public static float AddFloat(float a, float b) => a + b; 
}

