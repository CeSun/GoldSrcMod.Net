using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct TYPEDESCRIPTION
{
    public FIELDTYPE fieldType;
    public sbyte* fieldName;
    public int fieldOffset;
    public short fieldSize;
    public short flags;
}
public enum FIELDTYPE
{
    FIELD_FLOAT = 0,        // Any floating point value
    FIELD_STRING,           // A string ID (return from ALLOC_STRING)
    FIELD_ENTITY,           // An entity offset (EOFFSET)
    FIELD_CLASSPTR,         // CBaseEntity *
    FIELD_EHANDLE,          // Entity handle
    FIELD_EVARS,            // EVARS *
    FIELD_EDICT,            // edict_t *, or edict_t *  (same thing)
    FIELD_VECTOR,           // Any vector
    FIELD_POSITION_VECTOR,  // A world coordinate (these are fixed up across level transitions automagically)
    FIELD_POINTER,          // Arbitrary data pointer... to be removed, use an array of FIELD_CHARACTER
    FIELD_INTEGER,          // Any integer or enum
    FIELD_FUNCTION,         // A class function pointer (Think, Use, etc)
    FIELD_BOOLEAN,          // boolean, implemented as an int, I may use this as a hint for compression
    FIELD_SHORT,            // 2 byte integer
    FIELD_CHARACTER,        // a byte
    FIELD_TIME,             // a floating point time (these are fixed up automatically too!)
    FIELD_MODELNAME,        // Engine string that is a model name (needs precache)
    FIELD_SOUNDNAME,        // Engine string that is a sound name (needs precache)

    FIELD_TYPECOUNT,		// MUST BE LAST
}