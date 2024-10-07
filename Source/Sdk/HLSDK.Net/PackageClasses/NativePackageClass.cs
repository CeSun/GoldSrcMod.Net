using System.Runtime.InteropServices;

namespace GoldSrc.HLSDK.PackageClasses;

public unsafe class NativePackageClass<T> where T : unmanaged
{
    public T* NativePointer;

    bool selfManageMemory = false;

    public NativePackageClass(T* nativePointer)
    {
        NativePointer = nativePointer;
        selfManageMemory = false;
    }

    public NativePackageClass(ref T value)
    {
        selfManageMemory = true;
        this.NativePointer = (T*)Marshal.AllocHGlobal(sizeof(T));
    }

    ~NativePackageClass()
    {
        if (selfManageMemory)
        {
            Marshal.FreeHGlobal((nint)NativePointer);
        }
    }
}
