namespace GoldSrc.Amxmodx.Native;
public enum ForwardExecType
{
    ET_IGNORE = 0,                  // Ignore return vaue
    ET_STOP,                        // Stop on PLUGIN_HANDLED
    ET_STOP2,                       // Stop on PLUGIN_HANDLED, continue on other values, return biggest return value
    ET_CONTINUE,					// Continue; return biggest return value
}
