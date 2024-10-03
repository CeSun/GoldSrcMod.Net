namespace GoldSrc.MetaMod.Native;
public unsafe struct meta_globals_t
{
    public META_RES mres;          // writable; plugin's return flag
    public META_RES prev_mres;     // readable; return flag of the previous plugin called
    public META_RES status;        // readable; "highest" return flag so far
    public void* orig_ret;         // readable; return value from "real" function
    public void* override_ret;		// readable; return value from overriding/superceding plugin
}
