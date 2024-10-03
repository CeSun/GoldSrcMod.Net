using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct resource_t
{
    public fixed sbyte szFileName[64]; // File name to download/precache.
    public resourcetype_t type;                // t_sound, t_skin, t_model, t_decal.
    public int nIndex;              // For t_decals
    public int nDownloadSize;       // Size in Bytes if this must be downloaded.
    public byte ucFlags;

    // For handling client to client resource propagation
    public fixed byte rgucMD5_hash[16];    // To determine if we already have it.
    public byte playernum;           // Which player index this resource is associated with, if it's a custom resource.

    public fixed byte rguc_reserved[32]; // For future expansion
    public resource_t* pNext;              // Next in chain.
    public resource_t* pPrev;
}
public enum resourcetype_t
{
    t_sound = 0,
    t_skin,
    t_model,
    t_decal,
    t_generic,
    t_eventscript,
    t_world,		// Fake type for world, is really t_model
};