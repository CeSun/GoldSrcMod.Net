namespace GoldSrc.Metahook.Native;

public unsafe struct ICommandLine
{
    public nint* VirtualTable;

    public void CreateCmdLine(sbyte* commandLine)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[0];
        
        fixed(void* p = &this)
        {
            f(p, commandLine);
        }
    }

    public sbyte* GetCmdLine()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*>)VirtualTable[1];

        fixed (void* p = &this)
        {
            return f(p);
        }
    }

    public sbyte* CheckParm(sbyte* osz, sbyte** ppszValue)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte**, sbyte*>)VirtualTable[2];

        fixed (void* p = &this)
        {
            return f(p, osz, ppszValue);
        }
    }


    public void RemoveParm(sbyte* parm)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[3];

        fixed (void* p = &this)
        {
            f(p, parm);
        }
    }

    public void AppendParm(sbyte* pszParm, sbyte* pszValues)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, void>)VirtualTable[4];

        fixed (void* p = &this)
        {
            f(p, pszParm, pszValues);
        }
    }
    public void SetParm(sbyte* pszParm, sbyte* pszValues)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, void>)VirtualTable[5];

        fixed (void* p = &this)
        {
            f(p, pszParm, pszValues);
        }
    }
    public void SetParm(sbyte* pszParm, int iValue)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int, void>)VirtualTable[6];

        fixed (void* p = &this)
        {
            f(p, pszParm, iValue);
        }
    }
}
