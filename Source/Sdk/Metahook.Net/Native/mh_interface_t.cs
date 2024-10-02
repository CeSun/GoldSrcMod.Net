namespace GoldSrc.Metahook.Native;

public struct mh_interface_t
{
    public ICommandLine CommandLine;
    public nint FileSystem; //todo
    public IRegistry Registry;
}
