using CRC32_t = uint;

namespace GoldSrc.HLSDK.Native;
public unsafe struct enginefuncs_t
{
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnPrecacheModel;
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnPrecacheSound;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, void> pfnSetModel;
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnModelIndex;
    public delegate* unmanaged[Cdecl]<int, int> pfnModelFrames;
    public delegate* unmanaged[Cdecl]<edict_t*, float*, float*, void> pfnSetSize;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, void> pfnChangeLevel;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnGetSpawnParms;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnSaveSpawnParms;
    public delegate* unmanaged[Cdecl]<float*, float> pfnVecToYaw;
    public delegate* unmanaged[Cdecl]<float*, float*, void> pfnVecToAngles;
    public delegate* unmanaged[Cdecl]<edict_t*, float*, float, int, void> pfnMoveToOrigin;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnChangeYaw;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnChangePitch;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, sbyte*, edict_t*> pfnFindEntityByString;
    public delegate* unmanaged[Cdecl]<edict_t*, int> pfnGetEntityIllum;
    public delegate* unmanaged[Cdecl]<edict_t*, float*, float, edict_t*> pfnFindEntityInSphere;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*> pfnFindClientInPVS;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*> pfnEntitiesInPVS;
    public delegate* unmanaged[Cdecl]<float*, void> pfnMakeVectors;
    public delegate* unmanaged[Cdecl]<float*, float*, float*, float*, void> pfnAngleVectors;
    public delegate* unmanaged[Cdecl]<edict_t*> pfnCreateEntity;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnRemoveEntity;
    public delegate* unmanaged[Cdecl]<int, edict_t*> pfnCreateNamedEntity;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnMakeStatic;
    public delegate* unmanaged[Cdecl]<edict_t*, int> pfnEntIsOnFloor;
    public delegate* unmanaged[Cdecl]<edict_t*, int> pfnDropToFloor;
    public delegate* unmanaged[Cdecl]<edict_t*, float, float, int, int> pfnWalkMove;
    public delegate* unmanaged[Cdecl]<edict_t*, float*, void> pfnSetOrigin;
    public delegate* unmanaged[Cdecl]<edict_t*, int, sbyte*, float, float, int, int, void> pfnEmitSound;
    public delegate* unmanaged[Cdecl]<edict_t*, float*, sbyte*, float, float, int, int, void> pfnEmitAmbientSound;
    public delegate* unmanaged[Cdecl]<float*, float*, int, edict_t*, TraceResult*, void> pfnTraceLine;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*, TraceResult*, void> pfnTraceToss;
    public delegate* unmanaged[Cdecl]<edict_t*, float*, float*, int, edict_t*, TraceResult*, int> pfnTraceMonsterHull;
    public delegate* unmanaged[Cdecl]<float*, float*, int, int, edict_t*, TraceResult*, void> pfnTraceHull;
    public delegate* unmanaged[Cdecl]<float*, float*, int, edict_t*, TraceResult*, void> pfnTraceModel;
    public delegate* unmanaged[Cdecl]<edict_t*, float*, float*, sbyte*> pfnTraceTexture;
    public delegate* unmanaged[Cdecl]<float*, float*, int, float, edict_t*, TraceResult*, void> pfnTraceSphere;
    public delegate* unmanaged[Cdecl]<edict_t*, float, float*, void> pfnGetAimVector;
    public delegate* unmanaged[Cdecl]<sbyte*, void> pfnServerCommand;
    public delegate* unmanaged[Cdecl]<void> pfnServerExecute;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, void> pfnClientCommand;
    public delegate* unmanaged[Cdecl]<float*, float*, float, float, void> pfnParticleEffect;
    public delegate* unmanaged[Cdecl]<int, sbyte*, void> pfnLightStyle;
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnDecalIndex;
    public delegate* unmanaged[Cdecl]<float*, int> pfnPointContents;
    public delegate* unmanaged[Cdecl]<int, int, float*, edict_t*, void> pfnMessageBegin;
    public delegate* unmanaged[Cdecl]<void> pfnMessageEnd;
    public delegate* unmanaged[Cdecl]<int, void> pfnWriteByte;
    public delegate* unmanaged[Cdecl]<int, void> pfnWriteChar;
    public delegate* unmanaged[Cdecl]<int, void> pfnWriteShort;
    public delegate* unmanaged[Cdecl]<int, void> pfnWriteLong;
    public delegate* unmanaged[Cdecl]<float, void> pfnWriteAngle;
    public delegate* unmanaged[Cdecl]<float, void> pfnWriteCoord;
    public delegate* unmanaged[Cdecl]<sbyte*, void> pfnWriteString;
    public delegate* unmanaged[Cdecl]<int, void> pfnWriteEntity;
    public delegate* unmanaged[Cdecl]<cvar_t*, void> pfnCVarRegister;
    public delegate* unmanaged[Cdecl]<sbyte*, float> pfnCVarGetFloat;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte*> pfnCVarGetString;
    public delegate* unmanaged[Cdecl]<sbyte*, float, void> pfnCVarSetFloat;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, void> pfnCVarSetString;
    public delegate* unmanaged[Cdecl]<ALERT_TYPE, sbyte*, void> pfnAlertMessage;
    public delegate* unmanaged[Cdecl]<void*, sbyte*, void> pfnEngineFprintf;
    public delegate* unmanaged[Cdecl]<edict_t*, int, void*> pfnPvAllocEntPrivateData;
    public delegate* unmanaged[Cdecl]<edict_t*, void*> pfnPvEntPrivateData;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnFreeEntPrivateData;
    public delegate* unmanaged[Cdecl]<int, sbyte*> pfnSzFromIndex;
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnAllocString;
    public delegate* unmanaged[Cdecl]<edict_t*, entvars_t*> pfnGetVarsOfEnt;
    public delegate* unmanaged[Cdecl]<int, edict_t*> pfnPEntityOfEntOffset;
    public delegate* unmanaged[Cdecl]<edict_t*, int> pfnEntOffsetOfPEntity;
    public delegate* unmanaged[Cdecl]<edict_t*, int> pfnIndexOfEdict;
    public delegate* unmanaged[Cdecl]<int, edict_t*> pfnPEntityOfEntIndex;
    public delegate* unmanaged[Cdecl]<entvars_t*, edict_t*> pfnFindEntityByVars;
    public delegate* unmanaged[Cdecl]<edict_t*, void*> pfnGetModelPtr;
    public delegate* unmanaged[Cdecl]<sbyte*, int, int> pfnRegUserMsg;
    public delegate* unmanaged[Cdecl]<edict_t*, float, void> pfnAnimationAutomove;
    public delegate* unmanaged[Cdecl]<edict_t*, int, float*, float*, void> pfnGetBonePosition;
    public delegate* unmanaged[Cdecl]<sbyte*, uint> pfnFunctionFromName;
    public delegate* unmanaged[Cdecl]<uint, sbyte*> pfnNameForFunction;
    public delegate* unmanaged[Cdecl]<edict_t*, PRINT_TYPE, sbyte*, void> pfnClientPrintf;
    public delegate* unmanaged[Cdecl]<sbyte*, void> pfnServerPrint;
    public delegate* unmanaged[Cdecl]<sbyte*> pfnCmd_Args;
    public delegate* unmanaged[Cdecl]<int, sbyte*> pfnCmd_Argv;
    public delegate* unmanaged[Cdecl]<int> pfnCmd_Argc;
    public delegate* unmanaged[Cdecl]<edict_t*, int, float*, float*, void> pfnGetAttachment;
    public delegate* unmanaged[Cdecl]<CRC32_t*, void> pfnCRC32_Init;
    public delegate* unmanaged[Cdecl]<CRC32_t*, void*, int, void> pfnCRC32_ProcessBuffer;
    public delegate* unmanaged[Cdecl]<CRC32_t*, byte, void> pfnCRC32_ProcessByte;
    public delegate* unmanaged[Cdecl]<CRC32_t, CRC32_t> pfnCRC32_Final;
    public delegate* unmanaged[Cdecl]<int, int, int> pfnRandomLong;
    public delegate* unmanaged[Cdecl]<float, float, float> pfnRandomFloat;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*, void> pfnSetView;
    public delegate* unmanaged[Cdecl]<float> pfnTime;
    public delegate* unmanaged[Cdecl]<edict_t*, float, float, void> pfnCrosshairAngle;
    public delegate* unmanaged[Cdecl]<sbyte*, int*, byte*> pfnLoadFileForMe;
    public delegate* unmanaged[Cdecl]<void*, void> pfnFreeFile;
    public delegate* unmanaged[Cdecl]<sbyte*, void> pfnEndSection;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, int*, int> pfnCompareFileTime;
    public delegate* unmanaged[Cdecl]<sbyte*, void> pfnGetGameDir;
    public delegate* unmanaged[Cdecl]<cvar_t*, void> pfnCvar_RegisterVariable;
    public delegate* unmanaged[Cdecl]<edict_t*, int, int, int, int, void> pfnFadeClientVolume;
    public delegate* unmanaged[Cdecl]<edict_t*, float, void> pfnSetClientMaxspeed;
    public delegate* unmanaged[Cdecl]<sbyte*, edict_t*> pfnCreateFakeClient;
    public delegate* unmanaged[Cdecl]<edict_t*, float*, float, float, float, ushort, byte, byte, void> pfnRunPlayerMove;
    public delegate* unmanaged[Cdecl]<int> pfnNumberOfEntities;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*> pfnGetInfoKeyBuffer;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, sbyte*> pfnInfoKeyValue;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, sbyte*, void> pfnSetKeyValue;
    public delegate* unmanaged[Cdecl]<int, sbyte*, sbyte*, sbyte*, void> pfnSetClientKeyValue;
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnIsMapValid;
    public delegate* unmanaged[Cdecl]<float*, int, int, int, void> pfnStaticDecal;
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnPrecacheGeneric;
    public delegate* unmanaged[Cdecl]<edict_t*, int> pfnGetPlayerUserId;
    public delegate* unmanaged[Cdecl]<edict_t*, int, sbyte*, float, float, int, int, int, int, float*, edict_t*, void> pfnBuildSoundMsg;
    public delegate* unmanaged[Cdecl]<int> pfnIsDedicatedServer;
    public delegate* unmanaged[Cdecl]<sbyte*, cvar_t*> pfnCVarGetPointer;
    public delegate* unmanaged[Cdecl]<edict_t*, uint> pfnGetPlayerWONId;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, void> pfnInfo_RemoveKey;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, sbyte*> pfnGetPhysicsKeyValue;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, sbyte*, void> pfnSetPhysicsKeyValue;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*> pfnGetPhysicsInfoString;
    public delegate* unmanaged[Cdecl]<int, sbyte*, ushort> pfnPrecacheEvent;
    public delegate* unmanaged[Cdecl]<int, edict_t*, ushort, float, float*, float*, float, float, int, int, int, int, void> pfnPlaybackEvent;
    public delegate* unmanaged[Cdecl]<float*, byte*> pfnSetFatPVS;
    public delegate* unmanaged[Cdecl]<float*, byte*> pfnSetFatPAS;
    public delegate* unmanaged[Cdecl]<edict_t*, byte*, int> pfnCheckVisibility;
    public delegate* unmanaged[Cdecl]<delta_t*, sbyte*, void> pfnDeltaSetField;
    public delegate* unmanaged[Cdecl]<delta_t*, sbyte*, void> pfnDeltaUnsetField;
    public delegate* unmanaged[Cdecl]<sbyte*, delegate* unmanaged[Cdecl]<delta_t*, byte*, byte*, void>, void> pfnDeltaAddEncoder;
    public delegate* unmanaged[Cdecl]<int> pfnGetCurrentPlayer;
    public delegate* unmanaged[Cdecl]<edict_t*, int> pfnCanSkipPlayer;
    public delegate* unmanaged[Cdecl]<delta_t*, sbyte*, int> pfnDeltaFindField;
    public delegate* unmanaged[Cdecl]<delta_t*, int, void> pfnDeltaSetFieldByIndex;
    public delegate* unmanaged[Cdecl]<delta_t*, int, void> pfnDeltaUnsetFieldByIndex;
    public delegate* unmanaged[Cdecl]<int, int, void> pfnSetGroupMask;
    public delegate* unmanaged[Cdecl]<int, entity_state_t*, int> pfnCreateInstancedBaseline;
    public delegate* unmanaged[Cdecl]<cvar_t*, sbyte*, void> pfnCvar_DirectSet;
    public delegate* unmanaged[Cdecl]<FORCE_TYPE, float*, float*, sbyte*, void> pfnForceUnmodified;
    public delegate* unmanaged[Cdecl]<edict_t*, int*, int*, void> pfnGetPlayerStats;
    public delegate* unmanaged[Cdecl]<sbyte*, delegate* unmanaged[Cdecl]<void>, void> pfnAddServerCommand;
    public delegate* unmanaged[Cdecl]<int, int, qboolean> pfnVoice_GetClientListening;
    public delegate* unmanaged[Cdecl]<int, int, qboolean, qboolean> pfnVoice_SetClientListening;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*> pfnGetPlayerAuthId;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte*, sequenceEntry_t*> pfnSequenceGet;
    public delegate* unmanaged[Cdecl]<sbyte*, int, int*, sentenceEntry_t*> pfnSequencePickSentence;
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnGetFileSize;
    public delegate* unmanaged[Cdecl]<sbyte*, uint> pfnGetApproxWavePlayLen;
    public delegate* unmanaged[Cdecl]<int> pfnIsCareerMatch;
    public delegate* unmanaged[Cdecl]<sbyte*, int> pfnGetLocalizedStringLength;
    public delegate* unmanaged[Cdecl]<int, void> pfnRegisterTutorMessageShown;
    public delegate* unmanaged[Cdecl]<int, int> pfnGetTimesTutorMessageShown;
    public delegate* unmanaged[Cdecl]<int*, int, void> pfnProcessTutorMessageDecayBuffer;
    public delegate* unmanaged[Cdecl]<int*, int, void> pfnConstructTutorMessageDecayBuffer;
    public delegate* unmanaged[Cdecl]<void> pfnResetTutorMessageDecayData;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, void> pfnQueryClientCvarValue;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, int, void> pfnQueryClientCvarValue2;
}
public enum ALERT_TYPE
{
    at_notice,
    at_console,     // same as at_notice, but forces a ConPrintf, not a message box
    at_aiconsole,   // same as at_console, but only shown if developer level is 2!
    at_warning,
    at_error,
    at_logged       // Server print to console ( only in multiplayer games ).
}

public enum PRINT_TYPE
{
    print_console,
    print_center,
    print_chat,
}

public enum FORCE_TYPE
{
    force_exactfile,                    // File on client must exactly match server's file
    force_model_samebounds,             // For model files only, the geometry must fit in the same bbox
    force_model_specifybounds,          // For model files only, the geometry must fit in the specified bbox
    force_model_specifybounds_if_avail,	// For Steam model files only, the geometry must fit in the specified bbox (if the file is available)
}