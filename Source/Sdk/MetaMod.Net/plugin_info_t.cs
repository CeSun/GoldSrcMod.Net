namespace GoldSrc.MetaMod.Native;

public unsafe struct plugin_info_t
{
    public sbyte* ifvers;               // meta_interface version
    public sbyte* name;                 // full name of plugin
    public sbyte* version;              // version
    public sbyte* date;                 // date
    public sbyte* author;               // author name/email
    public sbyte* url;                  // URL
    public sbyte* logtag;               // log message prefix (unused right now)
    public PLUG_LOADTIME loadable;     // when loadable
    public PLUG_LOADTIME unloadable;	// when unloadable
}
