using GoldSrc.HLSDK.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct customization_t
{
    public qboolean bInUse;     // Is this customization in use;
    public resource_t resource; // The resource_t for this customization
    public qboolean bTranslated; // Has the raw data been translated into a useable format?  
                                 //  (e.g., raw decal .wad make into texture_t *)
    public int nUserData1; // Customization specific data
    public int nUserData2; // Customization specific data
    public void* pInfo;          // Buffer that holds the data structure that references the data (e.g., the cachewad_t)
    public void* pBuffer;       // Buffer that holds the data for the customization (the raw .wad data)
    public customization_t* pNext; // Next in chain
}
