namespace GoldSrc.MetaMod.Native;
public enum PL_UNLOAD_REASON
{
    PNL_NULL = 0,
    PNL_INI_DELETED,        // was deleted from plugins.ini
    PNL_FILE_NEWER,         // file on disk is newer than last load
    PNL_COMMAND,            // requested by server/console command
    PNL_CMD_FORCED,         // forced by server/console command
    PNL_DELAYED,            // delayed from previous request; can't tell origin
                            //only used for 'real_reason' on MPlugin::unload()
    PNL_PLUGIN,             // requested by plugin function call
    PNL_PLG_FORCED,         // forced by plugin function call
    PNL_RELOAD,				// forced unload by reload()
}
