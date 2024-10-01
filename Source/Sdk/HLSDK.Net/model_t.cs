using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct model_t
{
    public fixed sbyte name[64];
    public int needload;      // bmodels and sprites don't cache normally

    public modtype_t type;
    public int numframes;
    public synctype_t synctype;

    public int flags;

    //
    // volume occupied by the model
    //		
    public vec3_t mins, maxs;
    public float radius;

    //
    // brush model
    //
    public int firstmodelsurface, nummodelsurfaces;

    public int numsubmodels;
    public dmodel_t* submodels;

    public int numplanes;
    public mplane_t* planes;

    public int numleafs;       // number of visible leafs, not counting 0
    public mleaf_t *leafs;

    public int numvertexes;
    public mvertex_t* vertexes;

    public int numedges;
    public medge_t* edges;

    public int numnodes;
    public mnode_t* nodes;

    public int numtexinfo;
    public mtexinfo_t* texinfo;

    public int numsurfaces;
    public msurface_t* surfaces;

    public int numsurfedges;
    public int* surfedges;

    public int numclipnodes;
    public dclipnode_t* clipnodes;

    public int nummarksurfaces;
    public msurface_t** marksurfaces;

    public hull_t hulls_0;
    public hull_t hulls_1;

    public int numtextures;
    public texture_t** textures;

    public byte* visdata;

    public color24* lightdata;

    public sbyte* entities;

    //
    // additional model data
    //
    public cache_user_t cache;		// only access through Mod_Extradata
}
