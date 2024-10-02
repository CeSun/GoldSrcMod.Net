using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct SAVERESTOREDATA
{
    public sbyte* pBaseData;        // Start of all entity save data
    public sbyte* pCurrentData; // Current buffer pointer for sequential access
    public int size;           // Current data size
    public int bufferSize;     // Total space for data
    public int tokenSize;      // Size of the linear list of tokens
    public int tokenCount;     // Number of elements in the pTokens table
    public sbyte** pTokens;     // Hash table of entity strings (sparse)
    public int currentIndex;   // Holds a global entity table ID
    public int tableCount;     // Number of elements in the entity table
    public int connectionCount;// Number of elements in the levelList[]
    public ENTITYTABLE* pTable;        // Array of ENTITYTABLE elements (1 for each entity)
    public LEVELLIST levelList_0;     // List of connections from this level
    public LEVELLIST levelList_1;     // List of connections from this level
    public LEVELLIST levelList_2;     // List of connections from this level
    public LEVELLIST levelList_3;     // List of connections from this level
    public LEVELLIST levelList_4;     // List of connections from this level
    public LEVELLIST levelList_5;     // List of connections from this level
    public LEVELLIST levelList_6;     // List of connections from this level
    public LEVELLIST levelList_7;     // List of connections from this level
    public LEVELLIST levelList_8;     // List of connections from this level
    public LEVELLIST levelList_9;     // List of connections from this level
    public LEVELLIST levelList_10;     // List of connections from this level
    public LEVELLIST levelList_11;     // List of connections from this level
    public LEVELLIST levelList_12;     // List of connections from this level
    public LEVELLIST levelList_13;     // List of connections from this level
    public LEVELLIST levelList_14;     // List of connections from this level
    public LEVELLIST levelList_15;     // List of connections from this level

    // smooth transition
    public int fUseLandmark;
    public fixed sbyte szLandmarkName[20];// landmark we'll spawn near in next level
    public vec3_t vecLandmarkOffset;// for landmark transitions
    public float time;
    public fixed sbyte szCurrentMapName[32];	// To check global entities
}
