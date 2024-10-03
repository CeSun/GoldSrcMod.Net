using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct sequenceCommandLine_t
{
    public int commandType;        // Specifies the type of command
    public client_textmessage_t clientMessage;     // Text HUD message struct
    public sbyte* speakerName;      // Targetname of speaking entity
    public sbyte* listenerName;     // Targetname of entity being spoken to
    public sbyte* soundFileName;        // Name of sound file to play
    public sbyte* sentenceName;     // Name of sentences.txt to play
    public sbyte* fireTargetNames;  // List of targetnames to fire
    public sbyte* killTargetNames;  // List of targetnames to remove
    public float delay;                // Seconds 'till next command
    public int repeatCount;        // If nonzero, reset execution pointer to top of block (N times, -1 = infinite)
    public int textChannel;        // Display channel on which text message is sent
    public int modifierBitField;   // Bit field to specify what clientmessage fields are valid
    public sequenceCommandLine_t* nextCommandLine;	// Next command (linked list)
}
