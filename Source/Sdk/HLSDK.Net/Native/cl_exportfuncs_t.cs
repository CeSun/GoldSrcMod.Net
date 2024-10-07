using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct cl_exportfuncs_t
{
    public delegate* unmanaged[Cdecl]<cl_enginefuncs_t*, int, int> Initialize;
    public delegate* unmanaged[Cdecl]<void> HUD_Init;
    public delegate* unmanaged[Cdecl]<int> HUD_VidInit;
    public delegate* unmanaged[Cdecl]<float, int, int> HUD_Redraw;
    public delegate* unmanaged[Cdecl]<client_data_t*, float, int> HUD_UpdateClientData;
    public delegate* unmanaged[Cdecl]<void> HUD_Reset;
    public delegate* unmanaged[Cdecl]<playermove_t*, qboolean, void> HUD_PlayerMove;
    public delegate* unmanaged[Cdecl]<playermove_t*, void> HUD_PlayerMoveInit;
    public delegate* unmanaged[Cdecl]<sbyte*, sbyte> HUD_PlayerMoveTexture;
    public delegate* unmanaged[Cdecl]<void> IN_ActivateMouse;
    public delegate* unmanaged[Cdecl]<void> IN_DeactivateMouse;
    public delegate* unmanaged[Cdecl]<int, void> IN_MouseEvent;
    public delegate* unmanaged[Cdecl]<void> IN_ClearStates;
    public delegate* unmanaged[Cdecl]<void> IN_Accumulate;
    public delegate* unmanaged[Cdecl]<float, usercmd_t*, int, void> CL_CreateMove;
    public delegate* unmanaged[Cdecl]<int> CL_IsThirdPerson;
    public delegate* unmanaged[Cdecl]<float*, void> CL_CameraOffset;
    public delegate* unmanaged[Cdecl]<sbyte*, kbutton_t*> KB_Find;
    public delegate* unmanaged[Cdecl]<void> CAM_Think;
    public delegate* unmanaged[Cdecl]<ref_params_t*, void> V_CalcRefdef;
    public delegate* unmanaged[Cdecl]<int, cl_entity_t*, sbyte*, int, int> HUD_AddEntity;
    public delegate* unmanaged[Cdecl]<void> HUD_CreateEntities;
    public delegate* unmanaged[Cdecl]<void> HUD_DrawNormalTriangles;
    public delegate* unmanaged[Cdecl]<void> HUD_DrawTransparentTriangles;
    public delegate* unmanaged[Cdecl]<mstudioevent_t*, cl_entity_t*, void> HUD_StudioEvent;
    public delegate* unmanaged[Cdecl]<local_state_t*, local_state_t*, usercmd_t*, int, double, uint, void> HUD_PostRunCmd;
    public delegate* unmanaged[Cdecl]<void> HUD_Shutdown;
    public delegate* unmanaged[Cdecl]<entity_state_t*, clientdata_t*, void> HUD_TxferLocalOverrides;
    public delegate* unmanaged[Cdecl]<entity_state_t*, entity_state_t*, void> HUD_ProcessPlayerState;
    public delegate* unmanaged[Cdecl]<entity_state_t*, entity_state_t*, clientdata_t*, clientdata_t*, weapon_data_t*, weapon_data_t*, void> HUD_TxferPredictionData;
    public delegate* unmanaged[Cdecl]<int, byte*, void> Demo_ReadBuffer;
    public delegate* unmanaged[Cdecl]<netadr_t*, sbyte*, sbyte*, int*, int> HUD_ConnectionlessPacket;
    public delegate* unmanaged[Cdecl]<int, float*, float*, int> HUD_GetHullBounds;
    public delegate* unmanaged[Cdecl]<double, void> HUD_Frame;
    public delegate* unmanaged[Cdecl]<int, int, sbyte*, int> HUD_Key_Event;
    public delegate* unmanaged[Cdecl]<double, double, double, tempent_t**, tempent_t**, delegate* unmanaged[Cdecl]<cl_entity_t*, int>, delegate* unmanaged[Cdecl]<tempent_t*, float, void>, void> HUD_TempEntUpdate;

    public delegate* unmanaged[Cdecl]<int, cl_entity_t*> HUD_GetUserEntity;
    public delegate* unmanaged[Cdecl]<int, qboolean, void> HUD_VoiceStatus;
    public delegate* unmanaged[Cdecl]<int, void*, void> HUD_DirectorMessage;
    public delegate* unmanaged[Cdecl]<int, r_studio_interface_t*, engine_studio_api_t*, int> HUD_GetStudioModelInterface;
    public delegate* unmanaged[Cdecl]<int*, int*, void> HUD_ChatInputPosition;
    public delegate* unmanaged[Cdecl]<int, int> HUD_GetPlayerTeam;
    public delegate* unmanaged[Cdecl]<void*> ClientFactory;
}
