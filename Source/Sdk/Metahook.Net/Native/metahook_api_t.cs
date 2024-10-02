namespace GoldSrc.Metahook.Native;

public unsafe struct metahook_api_t
{
    public delegate* unmanaged[Cdecl]<hook_t*, int> UnHook;
    public delegate* unmanaged[Cdecl]<void*, void*, void**, hook_t*> InlineHook;
    public delegate* unmanaged[Cdecl]<void*, int, int, void*, void**, hook_t*> VFTHook;
    public delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, void*, void**, hook_t*>IATHook;
    public delegate* unmanaged[Cdecl]<void*> GetClassFuncAddr;      // 有些问题
    public delegate* unmanaged[Cdecl]<void*, uint> GetModuleBase;
    public delegate* unmanaged[Cdecl]<void*, uint> GetModuleSize;
    public delegate* unmanaged[Cdecl]<void*> GetEngineModule;
    public delegate* unmanaged[Cdecl]<uint> GetEngineBase;
    public delegate* unmanaged[Cdecl]<uint> GetEngineSize;
    public delegate* unmanaged[Cdecl]<void*, uint, sbyte*, uint, void*> SearchPattern;
    public delegate* unmanaged[Cdecl]<void*, uint, void> WriteDWORD;
    public delegate* unmanaged[Cdecl]<void*, uint> ReadDWORD;
    public delegate* unmanaged[Cdecl]<void*, byte*, uint, uint> WriteMemory;
    public delegate* unmanaged[Cdecl]<void*, byte*, uint, uint> ReadMemory;
    public delegate* unmanaged[Cdecl]<int*, int*, int*, bool*, uint> GetVideoMode;
    public delegate* unmanaged[Cdecl]<uint> GetEngineBuildnum;
    public delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<sbyte*, int*, nint>> GetEngineFactory;
    public delegate* unmanaged[Cdecl]<void*, uint, uint> GetNextCallAddr;
    public delegate* unmanaged[Cdecl]<void*, byte, void> WriteBYTE;
    public delegate* unmanaged[Cdecl]<void*, byte> ReadBYTE;
    public delegate* unmanaged[Cdecl]<void*, uint, void> WriteNOP;
}
