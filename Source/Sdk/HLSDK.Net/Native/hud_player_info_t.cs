using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct hud_player_info_t
{
    public byte* name;
    public short ping;
    public byte thisplayer;
    public byte spectator;
    public byte packetloss;
    public byte* model;
    public short topcolor;
    public short bottomcolor;
    public ulong m_nSteamID;
}
