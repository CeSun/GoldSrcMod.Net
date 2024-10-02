using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GoldSrc.Metahook.Native;
//todo
public unsafe struct IFileSystem
{
    public nint* VirtualTable;

    public void Mount()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void>)VirtualTable[1];
        fixed(void* p = &this)
        {
            f(p);
        }
    }

    public void Unmount()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void>)VirtualTable[2];
        fixed (void* p = &this)
        {
            f(p);
        }
    }
    public void RemoveAllSearchPaths()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void>)VirtualTable[3];
        fixed (void* p = &this)
        {
            f(p);
        }
    }
    public void AddSearchPath(sbyte* pPath, sbyte* pathID)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, void>)VirtualTable[4];
        fixed (void* p = &this)
        {
            f(p, pPath, pathID);
        }
    }
    public void RemoveSearchPath(sbyte* pPath)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[5];
        fixed (void* p = &this)
        {
            f(p, pPath);
        }
    }

    public void RemoveFile(sbyte* pRelativePath, sbyte* pathID)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, void>)VirtualTable[6];
        fixed (void* p = &this)
        {
            f(p, pRelativePath, pathID);
        }
    }


    public void CreateDirHierarchy(sbyte* pPath, sbyte* pathID)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, void>)VirtualTable[7];
        fixed (void* p = &this)
        {
            f(p, pPath, pathID);
        }
    }

    public void FileExists(sbyte* pFileName)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[8];
        fixed (void* p = &this)
        {
            f(p, pFileName);
        }
    }


    public void IsDirectory(sbyte* pFileName)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[9];
        fixed (void* p = &this)
        {
            f(p, pFileName);
        }
    }

    public nint Open(sbyte* pFileName, sbyte* pOptions, sbyte* pathID)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte *, sbyte *, nint>)VirtualTable[10];
        fixed (void* p = &this)
        {
            return f(p, pFileName, pOptions, pathID);
        }
    }


    public void Close(nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, void>)VirtualTable[11];
        fixed (void* p = &this)
        {
            f(p, file);
        }
    }

    public void Seek(nint file, int pos, FileSystemSeek_t seekType)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, int, FileSystemSeek_t, void>)VirtualTable[12];
        fixed (void* p = &this)
        {
            f(p, file, pos, seekType);
        }
    }

    public uint Tell(nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, uint>)VirtualTable[13];
        fixed (void* p = &this)
        {
            return f(p, file);
        }
    }

    public uint Size(nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, uint>)VirtualTable[14];
        fixed (void* p = &this)
        {
            return f(p, file);
        }
    }

    public uint Size(sbyte* pFileName)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, uint>)VirtualTable[15];
        fixed (void* p = &this)
        {
            return f(p, pFileName);
        }
    }

    public int GetFileTime(sbyte* pFileName)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int>)VirtualTable[16];
        fixed (void* p = &this)
        {
            return f(p, pFileName);
        }
    }
    public void FileTimeToString(sbyte* pFileName, int maxCharsIncludingTerminator, int fileTime)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int, int, void>)VirtualTable[17];
        fixed (void* p = &this)
        {
            f(p, pFileName, maxCharsIncludingTerminator, fileTime);
        }
    }
    public bool IsOk(nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, bool>)VirtualTable[18];
        fixed (void* p = &this)
        {
            return f(p, file);
        }
    }

    public void Flush(nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, void>)VirtualTable[19];
        fixed (void* p = &this)
        {
            f(p, file);
        }
    }

    public bool EndOfFile(nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, bool>)VirtualTable[20];
        fixed (void* p = &this)
        {
            return f(p, file);
        }
    }

    public int Read(void* pOutput, int size, nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void*, int, nint , int>)VirtualTable[21];
        fixed (void* p = &this)
        {
            return f(p, pOutput, size, file);
        }
    }

    public int Write(void* pInput, int size, nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void*, int, nint, int>)VirtualTable[22];
        fixed (void* p = &this)
        {
            return f(p, pInput, size, file);
        }
    }


    public sbyte* ReadLine(void* pOutput, int maxChars, nint file)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void*, int, nint, sbyte*>)VirtualTable[23];
        fixed (void* p = &this)
        {
            return f(p, pOutput, maxChars, file);
        }
    }

    public int FPrintf(nint file, sbyte* pFormat)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, sbyte*, int>)VirtualTable[24];
        fixed (void* p = &this)
        {
            return f(p, file, pFormat);
        }
    }

    public sbyte* GetReadBuffer(nint file, sbyte* pBuffer)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, sbyte*, sbyte*>)VirtualTable[25];
        fixed (void* p = &this)
        {
            return f(p, file, pBuffer);
        }
    }
    public void ReleaseReadBuffer(nint file, sbyte* pBuffer)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, sbyte*, void>)VirtualTable[26];
        fixed (void* p = &this)
        {
            f(p, file, pBuffer);
        }
    }

    public sbyte* FindFirst(sbyte* pWildCard, int pHandle, sbyte* pathID = null)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int, sbyte *, sbyte*>)VirtualTable[27];
        fixed (void* p = &this)
        {
            return f(p, pWildCard, pHandle, pathID);
        }
    }

    public sbyte* FindNext(int handle)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, int, sbyte*>)VirtualTable[28];
        fixed (void* p = &this)
        {
            return f(p, handle);
        }
    }

    public bool FindIsDirectory(int handle)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, int, bool>)VirtualTable[29];
        fixed (void* p = &this)
        {
            return f(p, handle);
        }
    }
    public void FindClose(int handle)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, int, void>)VirtualTable[30];
        fixed (void* p = &this)
        {
            f(p, handle);
        }
    }
    public void GetLocalCopy(sbyte* handle)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[31];
        fixed (void* p = &this)
        {
            f(p, handle);
        }
    }

    public sbyte* GetLocalPath(sbyte* pFileName, sbyte* pLocalPath, int maxLen)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte *, int, sbyte*>)VirtualTable[32];
        fixed (void* p = &this)
        {
            return f(p, pFileName, pLocalPath, maxLen);
        }
    }

    public sbyte* ParseFile(sbyte* data, sbyte* token, bool* wasquoted)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, bool*, sbyte*>)VirtualTable[33];
        fixed (void* p = &this)
        {
            return f(p, data, token, wasquoted);
        }
    }

    public bool FullPathToRelativePath(sbyte* pFullpath, sbyte* pRelative)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, bool>)VirtualTable[34];
        fixed (void* p = &this)
        {
            return f(p, pFullpath, pRelative);
        }
    }

    public bool GetCurrentDirectory(sbyte* pDirectory, int maxLen)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int, bool>)VirtualTable[35];
        fixed (void* p = &this)
        {
            return f(p, pDirectory, maxLen);
        }
    }

    public void PrintOpenedFiles()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void>)VirtualTable[36];
        fixed (void* p = &this)
        {
            f(p);
        }
    }

    public void SetWarningFunc(delegate* unmanaged[Cdecl]<sbyte*> pfwWarning)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, delegate* unmanaged[Cdecl] < sbyte *> , void >)VirtualTable[37];
        fixed (void* p = &this)
        {
            f(p, pfwWarning);
        }
    }


    public void SetWarningLevel(FileWarningLevel_t level)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, FileWarningLevel_t, void>)VirtualTable[38];
        fixed (void* p = &this)
        {
            f(p, level);
        }
    }

    public void LogLevelLoadStarted(sbyte* name)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[39];
        fixed (void* p = &this)
        {
            f(p, name);
        }
    }


    public void LogLevelLoadFinished(sbyte* name)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void>)VirtualTable[40];
        fixed (void* p = &this)
        {
            f(p, name);
        }
    }
    public int HintResourceNeed(sbyte* hintlist, int forgetEverything)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int, int>)VirtualTable[41];
        fixed (void* p = &this)
        {
            return f(p, hintlist, forgetEverything);
        }
    }

    public int PauseResourcePreloading()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, int>)VirtualTable[42];
        fixed (void* p = &this)
        {
            return f(p);
        }
    }
    public int ResumeResourcePreloading()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, int>)VirtualTable[43];
        fixed (void* p = &this)
        {
            return f(p);
        }
    }

    public int SetVBuf(nint stream, sbyte* buffer, int mode, int size)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, nint, sbyte*, int, int, int >)VirtualTable[44];
        fixed (void* p = &this)
        {
            return f(p, stream, buffer, mode, size);
        }
    }

    public void GetInterfaceVersion(sbyte* pp, int maxlen)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, int, void>)VirtualTable[45];
        fixed (void* p = &this)
        {
            f(p, pp, maxlen);
        }
    }

    public bool IsFileImmediatelyAvailable(sbyte* path)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, bool>)VirtualTable[46];
        fixed (void* p = &this)
        {
            return f(p, path);
        }
    }
    public void* WaitForResources(sbyte* path)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, void*>)VirtualTable[47];
        fixed (void* p = &this)
        {
            return f(p, path);
        }
    }

    public bool GetWaitForResourcesProgress(int handle, float* progress, bool *complete)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, int, float *, bool *, bool>)VirtualTable[48];
        fixed (void* p = &this)
        {
            return f(p, handle, progress, complete);
        }
    }

    public void CancelWaitForResources(int handle)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, int, void>)VirtualTable[49];
        fixed (void* p = &this)
        {
            f(p, handle);
        }
    }

    public void IsAppReadyForOfflinePlay()
    {
        var f = (delegate* unmanaged[Thiscall]<void*, void>)VirtualTable[50];
        fixed (void* p = &this)
        {
            f(p);
        }
    }

    public void AddPackFile(sbyte* pPath, sbyte* pathID)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte *, sbyte * ,void >)VirtualTable[51];
        fixed (void* p = &this)
        {
            f(p, pPath, pathID);
        }
    }

    public void* OpenFromCacheForRead(sbyte* pFileName, sbyte* pOptions, sbyte* pathID)
    {
        var f = (delegate* unmanaged[Thiscall]<void*, sbyte*, sbyte*, sbyte*, void*>)VirtualTable[52];
        fixed (void* p = &this)
        {
            return f(p, pFileName, pOptions, pathID);
        }
    }
}


public enum FileSystemSeek_t
{
    FILESYSTEM_SEEK_HEAD = 0,
    FILESYSTEM_SEEK_CURRENT,
    FILESYSTEM_SEEK_TAIL,
};

public enum FileWarningLevel_t
{
    FILESYSTEM_WARNING = -1,
    FILESYSTEM_WARNING_QUIET = 0,
    FILESYSTEM_WARNING_REPORTUNCLOSED,
    FILESYSTEM_WARNING_REPORTUSAGE,
    FILESYSTEM_WARNING_REPORTALLACCESSES,
    FILESYSTEM_WARNING_REPORTALLACCESSES_READ,
    FILESYSTEM_WARNING_REPORTALLACCESSES_READWRITE,
    FILESYSTEM_WARNING_REPORTALLACCESSES_ASYNC,
};