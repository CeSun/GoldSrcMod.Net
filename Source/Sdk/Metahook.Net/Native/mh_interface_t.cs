namespace GoldSrc.Metahook.Native;

public unsafe struct mh_interface_t
{
    public ICommandLine* CommandLine;
    public nint FileSystem; //todo
    public IRegistry* Registry;
}
