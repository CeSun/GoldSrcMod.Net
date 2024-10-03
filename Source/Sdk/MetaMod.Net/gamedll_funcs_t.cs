using GoldSrc.HLSDK.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.MetaMod.Native;

public unsafe struct gamedll_funcs_t
{
    public DLL_FUNCTIONS* dllapi_table;
    public NEW_DLL_FUNCTIONS* newapi_table;
}
