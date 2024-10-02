using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct cl_exportfuncs_t
{
    public delegate* unmanaged[Cdecl]<cl_enginefunc_t*, int, int> Initialize;
    public delegate* unmanaged[Cdecl]<void> HudInit;
    public delegate* unmanaged[Cdecl]<int> HudVidIni;
    public delegate* unmanaged[Cdecl]<float, int, int> HudReDraw;
    public delegate* unmanaged[Cdecl]<client_data_t*, float, int> HudUpdateClientData;
    public delegate* unmanaged[Cdecl]<void> HudReset;
    public delegate* unmanaged[Cdecl]<playermove_t*, int, void> HudPlayerMove;
    public delegate* unmanaged[Cdecl]<playermove_t*, void> HudPlayerMoveInit;
    public delegate* unmanaged[Cdecl]<byte*, byte> HudPlayerMoveTexture;
    public delegate* unmanaged[Cdecl]<void> InActivateMouse;
    public delegate* unmanaged[Cdecl]<void> InDeactivateMouse;
    public delegate* unmanaged[Cdecl]<int, void> InMouseEvent;
    public delegate* unmanaged[Cdecl]<void> InClearStates;
    public delegate* unmanaged[Cdecl]<void> InAccumulate;
    public delegate* unmanaged[Cdecl]<float, usercmd_t*, int, void> ClCreateMove;
    public delegate* unmanaged[Cdecl]<int> IsThridPerson;
    public delegate* unmanaged[Cdecl]<float*, void> ClCameraOffset;
    public delegate* unmanaged[Cdecl]<byte*, kbutton_t*> KbFind;
    public delegate* unmanaged[Cdecl]<void> CamThink;
    public delegate* unmanaged[Cdecl]<ref_params_t*, void> VCalcRefDef;
    public delegate* unmanaged[Cdecl]<int, cl_entity_t*, byte*, int> HudAddEntity;
    public delegate* unmanaged[Cdecl]<void> HudCreateEntities;
    public delegate* unmanaged[Cdecl]<void> HudDrawNormalTriangles;
    public delegate* unmanaged[Cdecl]<void> HudDrawTransparentTrianges;
    public delegate* unmanaged[Cdecl]<mstudioevent_t*, cl_entity_t*, void> HudStudioEvent;
    public delegate* unmanaged[Cdecl]<local_state_t*, local_state_t*, usercmd_t*, int, double, uint, void> HudPostRunCmd;
    public delegate* unmanaged[Cdecl]<void> HudShutDown;
    public delegate* unmanaged[Cdecl]<entity_state_t*, clientdata_t*, void> HudTxferLocalOverrides;
    public delegate* unmanaged[Cdecl]<entity_state_t*, entity_state_t*, void> HudProcessPlayerState;
    public delegate* unmanaged[Cdecl]<entity_state_t*, entity_state_t*, clientdata_t*, clientdata_t*, weapon_data_t*, weapon_data_t*, void> HudTxferPredictionData;
    public delegate* unmanaged[Cdecl]<int, byte*, void> DemoReadBuffer;
    public delegate* unmanaged[Cdecl]<netadr_t*, byte*, byte*, int*, int> HudConnectionlessPack;
    public delegate* unmanaged[Cdecl]<int, float*, float*, int> HudGetHullBounds;
    public delegate* unmanaged[Cdecl]<double, void> HudFrame;
    public delegate* unmanaged[Cdecl]<int, int, byte*, int> HudKeyEvent;
    public delegate* unmanaged[Cdecl]<double, double, double, tempent_t**, tempent_t**, delegate* unmanaged[Cdecl]<cl_entity_t*, int>, delegate* unmanaged[Cdecl]<tempent_t*, float, void>, void> HudTempEntUpdate;
    public delegate* unmanaged[Cdecl]<int, cl_entity_t*> HudGetUserEntity;
    public delegate* unmanaged[Cdecl]<int, int, void> HudVoiceStatus;
    public delegate* unmanaged[Cdecl]<int, void*, void> HudDirectorMessage;
    public delegate* unmanaged[Cdecl]<int, r_studio_interface_t**, engine_studio_api_t*, int> HudGetStudioModelInterface;
    public delegate* unmanaged[Cdecl]<int*, int*, void> HudChatInputPosition;
    public delegate* unmanaged[Cdecl]<int, int> HudGetPayerTeam;
    public delegate* unmanaged[Cdecl]<void*> ClientFactory;
}
