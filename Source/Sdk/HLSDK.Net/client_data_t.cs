using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;

public unsafe struct client_data_t
{
	public vec3_t origin;
	public vec3_t viewangles;
	public int		iWeaponBits;
	public float	fov;	// field of view
}
