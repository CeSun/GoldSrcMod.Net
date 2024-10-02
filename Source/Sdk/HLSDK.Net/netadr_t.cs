using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;
public unsafe struct netadr_t
{
    public netadrtype_t	type;
	public fixed byte ip[4];
	public fixed byte	ipx[10];
	public ushort	port;
}
public enum netadrtype_t
{
	NA_UNUSED,
	NA_LOOPBACK,
	NA_BROADCAST,
	NA_IP,
	NA_IPX,
	NA_BROADCAST_IPX,
}