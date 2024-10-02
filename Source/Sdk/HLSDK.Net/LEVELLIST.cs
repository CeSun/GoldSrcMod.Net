using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct LEVELLIST
{
    public fixed sbyte mapName[32];
    public fixed sbyte landmarkName[32];
    public edict_t* pentLandmark;
    public vec3_t vecLandmarkOrigin;
}
