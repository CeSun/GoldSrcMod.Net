namespace GoldSrc.Metahook.Native;

public struct metahook_api_t
{
    public nint UnHook;
    public nint InlineHook;
    public nint VFTHook;
    public nint IATHook;
    public nint GetClassFuncAddr;
    public nint GetModuleBase;
    public nint GetModuleSize;
    public nint GetEngineModule;
    public nint GetEngineBase;
    public nint GetEngineSize;
    public nint SearchPattern;
    public nint WriteDWORD;
    public nint ReadDWORD;
    public nint WriteMemory;
    public nint ReadMemory;
    public nint GetVideoMode;
    public nint GetEngineBuildnum;
    public nint GetEngineFactory;
    public nint GetNextCallAddr;
    public nint WriteBYTE;
    public nint ReadBYTE;
    public nint WriteNOP;
}
