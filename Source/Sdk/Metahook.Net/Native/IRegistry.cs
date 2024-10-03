namespace GoldSrc.Metahook.Native;

public unsafe struct IRegistry
{
    public nint* VirtualTable;
    public void Init()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void>)VirtualTable[0];

        fixed (void* p = &this)
        {
            f(p);
        }
    }

    public void Shutdown()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void>)VirtualTable[1];

        fixed (void* p = &this)
        {
            f(p);
        }
    }

    public int ReadInt(sbyte* key, int defaultValue = 0)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int, int>)VirtualTable[2];

        fixed (void* p = &this)
        {
            return f(p, key, defaultValue);
        }
    }
    public void WriteInt(sbyte* key, int value)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int, void>)VirtualTable[3];

        fixed (void* p = &this)
        {
            f(p, key, value);
        }
    }

    public sbyte* ReadString(sbyte* key, sbyte* defaultValue = null)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, sbyte*>)VirtualTable[4];

        fixed (void* p = &this)
        {
            return f(p, key, defaultValue);
        }
    }
    public void WriteString(sbyte* key, sbyte* value)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, void>)VirtualTable[5];

        fixed (void* p = &this)
        {
            f(p, key, value);
        }
    }


}
