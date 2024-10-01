using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct cl_entity_t
{
    public int index;
    public int player;
    public entity_state_t baseline;
    public entity_state_t prevstate;
    public entity_state_t curstate;
    public int current_position;
    #region ph_array
    public position_history_t ph_0;
    public position_history_t ph_1;
    public position_history_t ph_2;
    public position_history_t ph_3;
    public position_history_t ph_4;
    public position_history_t ph_5;
    public position_history_t ph_6;
    public position_history_t ph_7;
    public position_history_t ph_8;
    public position_history_t ph_9;
    public position_history_t ph_10;
    public position_history_t ph_11;
    public position_history_t ph_12;
    public position_history_t ph_13;
    public position_history_t ph_14;
    public position_history_t ph_15;
    public position_history_t ph_16;
    public position_history_t ph_17;
    public position_history_t ph_18;
    public position_history_t ph_19;
    public position_history_t ph_20;
    public position_history_t ph_21;
    public position_history_t ph_22;
    public position_history_t ph_23;
    public position_history_t ph_24;
    public position_history_t ph_25;
    public position_history_t ph_26;
    public position_history_t ph_27;
    public position_history_t ph_28;
    public position_history_t ph_29;
    public position_history_t ph_30;
    public position_history_t ph_31;
    public position_history_t ph_32;
    public position_history_t ph_33;
    public position_history_t ph_34;
    public position_history_t ph_35;
    public position_history_t ph_36;
    public position_history_t ph_37;
    public position_history_t ph_38;
    public position_history_t ph_39;
    public position_history_t ph_40;
    public position_history_t ph_41;
    public position_history_t ph_42;
    public position_history_t ph_43;
    public position_history_t ph_44;
    public position_history_t ph_45;
    public position_history_t ph_46;
    public position_history_t ph_47;
    public position_history_t ph_48;
    public position_history_t ph_49;
    public position_history_t ph_50;
    public position_history_t ph_51;
    public position_history_t ph_52;
    public position_history_t ph_53;
    public position_history_t ph_54;
    public position_history_t ph_55;
    public position_history_t ph_56;
    public position_history_t ph_57;
    public position_history_t ph_58;
    public position_history_t ph_59;
    public position_history_t ph_60;
    public position_history_t ph_61;
    public position_history_t ph_62;
    public position_history_t ph_63;
    #endregion
    public mouth_t mouth;
    public latchedvars_t latched;
    public float lastmove;
    public fixed float origin[3];
    public fixed float angles[3];
    public fixed float attachment[3 * 4];
    public int trivial_accept;

    public nint model;      // todo
    public nint efrag;      // todo
    public nint topnode;      // todo

    public float syncbase;     // for client-side animations -- used by obsolete alias animation system, remove?
    public int visframe;
    public colorVec cvFloorColor;
}
