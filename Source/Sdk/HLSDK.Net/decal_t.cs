using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct decal_t
{
    public decal_t* pnext;         // linked list for each surface
    public msurface_t* psurface;       // Surface id for persistence / unlinking
    public short dx;               // Offsets into surface texture (in texture coordinates, so we don't need floats)
    public short dy;
    public short texture;      // Decal texture
    public byte scale;         // Pixel scale
    public byte flags;         // Decal flags
    public short entityIndex;	// Entity this is attached to
}
