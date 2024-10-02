namespace GoldSrc.Metahook.Native;

public unsafe struct mh_interface_t
{
    public ICommandLine* CommandLine;
    public IFileSystem* FileSystem;
    public IRegistry* Registry;
}
