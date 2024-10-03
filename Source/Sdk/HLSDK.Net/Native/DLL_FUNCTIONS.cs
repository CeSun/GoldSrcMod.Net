using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct DLL_FUNCTIONS
{
    public delegate* unmanaged[Cdecl]<void> pfnGameInit;
    public delegate* unmanaged[Cdecl]<edict_t*, int> pfnSpawn;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnThink;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*, void> pfnUse;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*, void> pfnTouch;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*, void> pfnBlocked;
    public delegate* unmanaged[Cdecl]<edict_t*, KeyValueData*, void> pfnKeyValue;
    public delegate* unmanaged[Cdecl]<edict_t*, SAVERESTOREDATA*, void> pfnSave;
    public delegate* unmanaged[Cdecl]<edict_t*, SAVERESTOREDATA*, int, int> pfnRestore;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnSetAbsBox;

    public delegate* unmanaged[Cdecl]<SAVERESTOREDATA*, sbyte*, void*, TYPEDESCRIPTION*, int, void> pfnSaveWriteFields;
    public delegate* unmanaged[Cdecl]<SAVERESTOREDATA*, sbyte*, void*, TYPEDESCRIPTION*, int, void> pfnSaveReadFields;

    public delegate* unmanaged[Cdecl]<SAVERESTOREDATA*, void> pfnSaveGlobalState;
    public delegate* unmanaged[Cdecl]<SAVERESTOREDATA*, void> pfnRestoreGlobalState;
    public delegate* unmanaged[Cdecl]<void> pfnResetGlobalState;

    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, sbyte*, sbyte*, qboolean> pfnClientConnect;


    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnClientDisconnect;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnClientKill;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnClientPutInServer;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnClientCommand;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, void> pfnClientUserInfoChanged;


    public delegate* unmanaged[Cdecl]<edict_t*, int, int, void> pfnServerActivate;
    public delegate* unmanaged[Cdecl]<void> pfnServerDeactivate;

    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnPlayerPreThink;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnPlayerPostThink;


    public delegate* unmanaged[Cdecl]<void> pfnStartFrame;
    public delegate* unmanaged[Cdecl]<void> pfnParmsNewLevel;
    public delegate* unmanaged[Cdecl]<void> pfnParmsChangeLevel;

    public delegate* unmanaged[Cdecl]<sbyte*> pfnGetGameDescription;

    public delegate* unmanaged[Cdecl]<edict_t*, customization_t*, void> pfnPlayerCustomization;


    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnSpectatorConnect;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnSpectatorDisconnect;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnSpectatorThink;

    public delegate* unmanaged[Cdecl]<sbyte*, void> pfnSys_Error;

    public delegate* unmanaged[Cdecl]<playermove_t*, qboolean, void> pfnPM_Move;
    public delegate* unmanaged[Cdecl]<playermove_t*, void> pfnPM_Init;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte> pfnPM_FindTextureType;
    public delegate* unmanaged[Cdecl]<edict_t*, edict_t*, byte**, byte**, void> pfnSetupVisibility;
    public delegate* unmanaged[Cdecl]<edict_t*, int, clientdata_t*, void> pfnUpdateClientData;
    public delegate* unmanaged[Cdecl]<entity_state_t*, int, edict_t*, edict_t*, int, int, byte*, int> pfnAddToFullPack;
    public delegate* unmanaged[Cdecl]<int, int, entity_state_t*, edict_t*, int, vec3_t, vec3_t, void> pfnCreateBaseline;
    public delegate* unmanaged[Cdecl]<void> pfnRegisterEncoders;
    public delegate* unmanaged[Cdecl]<edict_t*, weapon_data_t*, int> pfnGetWeaponData;

    public delegate* unmanaged[Cdecl]<edict_t*, usercmd_t*, uint, void> pfnCmdStart;
    public delegate* unmanaged[Cdecl]<edict_t*, void> pfnCmdEnd;

    public delegate* unmanaged[Cdecl]<netadr_t*, sbyte*, sbyte*, int*, int> pfnConnectionlessPacket;
    public delegate* unmanaged[Cdecl]<int, float*, float*, int> pfnGetHullBounds;
    public delegate* unmanaged[Cdecl]<void> pfnCreateInstancedBaselines;
    public delegate* unmanaged[Cdecl]<edict_t*, sbyte*, sbyte*, int> pfnInconsistentFile;
    public delegate* unmanaged[Cdecl]<int> pfnAllowLagCompensation;

}
