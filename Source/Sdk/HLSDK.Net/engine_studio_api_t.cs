using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GoldSrc.HLSDK.Native;

public unsafe struct engine_studio_api_t
{
    // Allocate number*size bytes and zero it
	public delegate* unmanaged[Cdecl]<int, uint, void> Mem_Calloc;
	// Check to see if pointer is in the cache
	public delegate* unmanaged[Cdecl]<cache_user_t*, void> Cache_Check;
	// Load file into cache ( can be swapped out on demand )
	public delegate* unmanaged[Cdecl]<sbyte*, cache_user_t*, void> LoadCacheFile;
	// Retrieve model pointer for the named model
	public delegate* unmanaged[Cdecl]<sbyte*, int, model_t*> Mod_ForName;
	// Retrieve pointer to studio model data block from a model
	public delegate* unmanaged[Cdecl]<model_t*, void> Mod_Extradata;
	// Retrieve indexed model from client side model precache list
	public delegate* unmanaged[Cdecl]<int, model_t*> GetModelByIndex;
	// Get entity that is set for rendering
	public delegate* unmanaged[Cdecl]<cl_entity_t*> GetCurrentEntity;
	// Get referenced player_info_t
	public delegate* unmanaged[Cdecl]<int, player_info_t*> PlayerInfo;
	// Get most recently received player state data from network system
	public delegate* unmanaged[Cdecl]<int, entity_state_t*> GetPlayerState;
	// Get viewentity
	public delegate* unmanaged[Cdecl]<cl_entity_t*> GetViewEntity;
	// Get current frame count, and last two timestampes on client
	public delegate* unmanaged[Cdecl]<int*, double*, double*, void> GetTimes;
	// Get a pointer to a cvar by name
	public delegate* unmanaged[Cdecl]<sbyte*, cvar_t> GetCvar;
	// Get current render origin and view vectors ( up, right and vpn )
	public delegate* unmanaged[Cdecl]<float*, float*, float*, float*, void> GetViewInfo;
	// Get sprite model used for applying chrome effect
	public delegate* unmanaged[Cdecl]<model_t*> GetChromeSprite;
	// Get model counters so we can incement instrumentation
	public delegate* unmanaged[Cdecl]<int**, int**, void> GetModelCounters;
	// Get software scaling coefficients
	public delegate* unmanaged[Cdecl]<int**, int**, void> GetAliasScale;
	// Get bone, light, alias, and rotation matrices
	public delegate* unmanaged[Cdecl]<float****> StudioGetBoneTransform;
	public delegate* unmanaged[Cdecl]<float****> StudioGetLightTransform;
	public delegate* unmanaged[Cdecl]<float***> StudioGetAliasTransform;
	public delegate* unmanaged[Cdecl]<float***> StudioGetRotationMatrix;

	// Set up body part, and get submodel pointers
	public delegate* unmanaged[Cdecl]<int, void**, void**,void> StudioSetupModel;
	// Check if entity's bbox is in the view frustum
	public delegate* unmanaged[Cdecl]<int> StudioCheckBBox;
	// Apply lighting effects to model
	public delegate* unmanaged[Cdecl]<cl_entity_t*, alight_t*, void> StudioDynamicLight;
	public delegate* unmanaged[Cdecl]<alight_t*, void> StudioEntityLight;
	public delegate* unmanaged[Cdecl]<alight_t*, void> StudioSetupLighting;

	// Draw mesh vertices
	public delegate* unmanaged[Cdecl]<void> StudioDrawPoints;

	// Draw hulls around bones
	public delegate* unmanaged[Cdecl]<void> StudioDrawHulls;
	// Draw bbox around studio models
	public delegate* unmanaged[Cdecl]<void> StudioDrawAbsBBox;
	// Draws bones
	public delegate* unmanaged[Cdecl]<void> StudioDrawBones;
	// Loads in appropriate texture for model
	public delegate* unmanaged[Cdecl]<void*, int, void> StudioSetupSkin;
	// Sets up for remapped colors
	public delegate* unmanaged[Cdecl]<int, int, void> StudioSetRemapColors;
	// Set's player model and returns model pointer
	public delegate* unmanaged[Cdecl]<int, model_t*> SetupPlayerModel;
	// Fires any events embedded in animation
	public delegate* unmanaged[Cdecl]<void> StudioClientEvents;
	// Retrieve/set forced render effects flags
	public delegate* unmanaged[Cdecl]<int> GetForceFaceFlags;
	public delegate* unmanaged[Cdecl]<int, void> SetForceFaceFlags;
	// Tell engine the value of the studio model header
	public delegate* unmanaged[Cdecl]<void*, void> StudioSetHeader;
	// Tell engine which model_t * is being renderered
	public delegate* unmanaged[Cdecl]<model_t*, void> SetRenderModel;

	// Final state setup and restore for rendering
	public delegate* unmanaged[Cdecl]<int, void> SetupRenderer;
	public delegate* unmanaged[Cdecl]<void> RestoreRenderer;

	// Set render origin for applying chrome effect
	public delegate* unmanaged[Cdecl]<void> SetChromeOrigin;

	// True if using D3D/OpenGL
	public delegate* unmanaged[Cdecl]<int> IsHardware;
	
	// Only called by hardware interface
	public delegate* unmanaged[Cdecl]<void> GL_StudioDrawShadow;
	public delegate* unmanaged[Cdecl]<int, void> GL_SetRenderMode;

	public delegate* unmanaged[Cdecl]<int, void> StudioSetRenderamt;
	public delegate* unmanaged[Cdecl]<int, void> StudioSetCullState;
	public delegate* unmanaged[Cdecl]<int, float*, float*, float*, float*, void> StudioRenderShadow;
}
