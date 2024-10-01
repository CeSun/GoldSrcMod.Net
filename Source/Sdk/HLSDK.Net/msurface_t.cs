using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct msurface_t
{
    public int visframe;       // should be drawn when node is crossed

    public int dlightframe;    // last frame the surface was checked by an animated light
    public int dlightbits;     // dynamically generated. Indicates if the surface illumination 
                               // is modified by an animated light.

    public mplane_t* plane;            // pointer to shared plane			
    public int flags;          // see SURF_ #defines

    public int firstedge;  // look up in model->surfedges[], negative numbers
    public int numedges;   // are backwards edges

    // surface generation data
    public surfcache_t* cachespots_0;
    public surfcache_t* cachespots_1;
    public surfcache_t* cachespots_2;
    public surfcache_t* cachespots_3;

    public fixed short texturemins[2]; // smallest s/t position on the surface.
    public fixed short extents[2];       // ?? s/t texture size, 1..256 for all non-sky surfaces

    public mtexinfo_t* texinfo;

    // lighting info
    public fixed byte styles[4]; // index into d_lightstylevalue[] for animated lights 
                                      // no one surface can be effected by more than 4 
                                      // animated lights.
    public color24* samples;

    public decal_t* pdecals;
}
