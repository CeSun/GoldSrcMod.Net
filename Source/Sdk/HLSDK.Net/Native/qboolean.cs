using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GoldSrc.HLSDK.Native;

#pragma warning disable CS8981 // 该类型名称仅包含小写 ascii 字符。此类名称可能会成为该语言的保留值。
public struct qboolean
#pragma warning restore CS8981 // 该类型名称仅包含小写 ascii 字符。此类名称可能会成为该语言的保留值。
{
    public int value;

    public static bool operator==(qboolean left, bool right)
    {
        var realBoolValue = (left.value != 0);

        return realBoolValue == right;
    }

    public static bool operator !=(qboolean left, bool right) => !(left == right);
    public static bool operator ==(bool left, qboolean right) => right == left;
    public static bool operator !=(bool left, qboolean right) => !(left == right);


    public static bool operator ==(qboolean left, qboolean right) => ((bool)left == (bool)right);
    public static bool operator !=(qboolean left, qboolean right) => !(left == right);

    public static implicit operator int(qboolean d) => d.value;

    public static implicit operator bool(qboolean d) => d.value != 0;

    public override readonly bool Equals(object? obj)
    {
        if (obj == null)
            return false;
        if (obj is qboolean qboolean)
            return this == qboolean;
        if (obj is bool b)
            return this == b;
        if (obj is int i)
            return value == i;
        return false;
    }

    public override int GetHashCode()
    {
        return ((bool)this).GetHashCode();
    }
}
