using System.Reflection.Metadata;
using System.Runtime.InteropServices;

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

    public string CheckParm(string osz, out string ppszValue)
    {
        sbyte* outValue = null;
        sbyte* oszPtr = (sbyte*)Marshal.StringToHGlobalAnsi(osz);

        var rtl = CheckParm(oszPtr, &outValue);
        Marshal.FreeHGlobal((nint)oszPtr);

        if (outValue == null)
        {
            ppszValue = "";
        }
        else
        {
            ppszValue = Marshal.PtrToStringAnsi((nint)outValue) ?? "";
        }
        return Marshal.PtrToStringAnsi((nint)rtl) ?? "";
    }


    public sbyte* CheckParm(sbyte* osz, sbyte** ppszValue)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte**, sbyte*>)VirtualTable[2];

        fixed (void* p = &this)
        {
            return f(p, osz, ppszValue);
        }
    }


    public void RemoveParm(string parm)
    {
        sbyte* outValue = null;
        sbyte* parmPtr = (sbyte*)Marshal.StringToHGlobalAnsi(parm);
        RemoveParm(parmPtr);
        Marshal.FreeHGlobal((nint)parmPtr);
    }

    public void RemoveParm(sbyte* parm)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[3];

        fixed (void* p = &this)
        {
            f(p, parm);
        }
    }

    public void AppendParm(string parm, string value)
    {
        sbyte* outValue = null;
        sbyte* parmPtr = (sbyte*)Marshal.StringToHGlobalAnsi(parm);
        sbyte* valuePtr = (sbyte*)Marshal.StringToHGlobalAnsi(value);
        AppendParm(parmPtr, valuePtr);
        Marshal.FreeHGlobal((nint)parmPtr);
        Marshal.FreeHGlobal((nint)valuePtr);
    }


    public void AppendParm(sbyte* pszParm, sbyte* pszValues)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, void>)VirtualTable[4];

        fixed (void* p = &this)
        {
            f(p, pszParm, pszValues);
        }
    }


    public void SetParm(string parm, string value)
    {
        sbyte* outValue = null;
        sbyte* parmPtr = (sbyte*)Marshal.StringToHGlobalAnsi(parm);
        sbyte* valuePtr = (sbyte*)Marshal.StringToHGlobalAnsi(value);
        SetParm(parmPtr, valuePtr);
        Marshal.FreeHGlobal((nint)parmPtr);
        Marshal.FreeHGlobal((nint)valuePtr);
    }
    public void SetParm(sbyte* pszParm, sbyte* pszValues)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, void>)VirtualTable[5];

        fixed (void* p = &this)
        {
            f(p, pszParm, pszValues);
        }
    }
    public void SetParm(string parm, int value)
    {
        sbyte* outValue = null;
        sbyte* parmPtr = (sbyte*)Marshal.StringToHGlobalAnsi(parm);
        SetParm(parmPtr, value);
        Marshal.FreeHGlobal((nint)parmPtr);
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
