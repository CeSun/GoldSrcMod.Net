namespace FuckWorld.Metahook.Native;

public struct cl_exportfuncs_t
{
    public nint Initialize;
    public nint HUD_Init;
    public nint HUD_VidInit;
    public nint HUD_Redraw;
    public nint HUD_UpdateClientData;
    public nint HUD_Reset;
    public nint HUD_PlayerMove;
    public nint HUD_PlayerMoveInit;
    public nint HUD_PlayerMoveTexture;
    public nint IN_ActivateMouse;
    public nint IN_DeactivateMouse;
    public nint IN_MouseEvent;
    public nint IN_ClearStates;
    public nint IN_Accumulate;
    public nint CL_CreateMove;
    public nint CL_IsThirdPerson;
    public nint CL_CameraOffset;
    public nint KB_Find;
    public nint CAM_Think;
    public nint V_CalcRefdef;
    public nint HUD_AddEntity;
    public nint HUD_CreateEntities;
    public nint HUD_DrawNormalTriangles;
    public nint HUD_DrawTransparentTriangles;
    public nint HUD_StudioEvent;
    public nint HUD_PostRunCmd;
    public nint HUD_Shutdown;
    public nint HUD_TxferLocalOverrides;
    public nint HUD_ProcessPlayerState;
    public nint HUD_TxferPredictionData;
    public nint Demo_ReadBuffer;
    public nint HUD_ConnectionlessPacket;
    public nint HUD_GetHullBounds;
    public nint HUD_Frame;
    public nint HUD_Key_Event;
    public nint HUD_TempEntUpdate;
    public nint HUD_GetUserEntity;
    public nint HUD_VoiceStatus;
    public nint HUD_DirectorMessage;
    public nint HUD_GetStudioModelInterface;
    public nint HUD_ChatInputPosition;
    public nint HUD_GetPlayerTeam;
    public nint ClientFactory;
}
