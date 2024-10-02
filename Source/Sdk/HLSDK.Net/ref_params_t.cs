using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct ref_params_t
{
    // Output
    public fixed float vieworg[3];
    public fixed float viewangles[3];

    public fixed float forward[3];
    public fixed float right[3];
    public fixed float up[3];

    // Client frametime;
    public float frametime;
    // Client time
    public float time;

    // Misc
    public int intermission;
    public int paused;
    public int spectator;
    public int onground;
    public int waterlevel;

    public fixed float simvel[3];
    public fixed float simorg[3];

    public fixed float viewheight[3];
    public float idealpitch;

    public fixed float cl_viewangles[3];

    public int health;
    public fixed float crosshairangle[3];
    public float viewsize;

    public fixed float punchangle[3];
    public int maxclients;
    public int viewentity;
    public int playernum;
    public int max_entities;
    public int demoplayback;
    public int hardware;

    public int smoothing;

    // Last issued usercmd
    public usercmd_t* cmd;

    // Movevars
    public movevars_t* movevars;

    public fixed int viewport[4];        // the viewport coordinates x ,y , width, height

    public int nextView;           // the renderer calls ClientDLL_CalcRefdef() and Renderview
                                   // so long in cycles until this value is 0 (multiple views)
    public int onlyClientDraw;		// if !=0 nothing is drawn by the engine except clientDraw functions
}
