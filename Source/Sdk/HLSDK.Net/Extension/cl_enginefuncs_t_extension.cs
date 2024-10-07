using GoldSrc.HLSDK.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoldSrc.HLSDK.Extension;

public delegate int pfnUserMsgHook(string pszName, Span<byte> msg);
public unsafe static class cl_enginefuncs_t_extension
{
    public static int SPR_Load(this ref cl_enginefunc_t enginefuncs, string picName)
    {
        using (var nativeStr = picName.GetNativeString())
        {
            return enginefuncs.pfnSPR_Load(nativeStr);
        }
    }

    public static Span<client_sprite_t> SPR_GetList(this ref cl_enginefunc_t enginefuncs, string sz)
    {
        using (var nativeStr = sz.GetNativeString())
        {
            int count = 0;
            client_sprite_t* p = enginefuncs.pfnSPR_GetList(nativeStr, &count);
            Span<client_sprite_t> memory = new Span<client_sprite_t>(p, count);
            return memory;
        }
    }

    public static SCREENINFO GetScreenInfo(this ref cl_enginefunc_t enginefuncs)
    {
        SCREENINFO screeninfo = default;
        screeninfo.iSize = sizeof(SCREENINFO);
        enginefuncs.pfnGetScreenInfo(&screeninfo);
        return screeninfo;
    }

    public static cvar_t* RegisterVariable(this ref cl_enginefunc_t enginefuncs, string szName, string szValue, int flag)
    {
        using var szNameNativeStr = szName.GetNativeString();
        using var szValueNativeStr = szValue.GetNativeString();
        return enginefuncs.pfnRegisterVariable(szNameNativeStr, szValueNativeStr, flag);
    }

    public static float GetCvarFloat(this ref cl_enginefunc_t enginefuncs, string szName)
    {
        using var szNameNativeStr = szName.GetNativeString();
        return enginefuncs.pfnGetCvarFloat(szNameNativeStr);
    }

    public static string GetCvarString(this ref cl_enginefunc_t enginefuncs, string szName)
    {
        using var szNameNativeStr = szName.GetNativeString();
        nint p = (nint)enginefuncs.pfnGetCvarString(szNameNativeStr);
        return Marshal.PtrToStringAnsi(p) ?? "";
    }

    public static int AddCommand(this ref cl_enginefunc_t enginefuncs, string cmd_name, Action action)
    {
        var ptr = Marshal.GetFunctionPointerForDelegate(action);
        using var cmd_nameNativeStr = cmd_name.GetNativeString();
        return enginefuncs.pfnAddCommand(cmd_nameNativeStr, (delegate* unmanaged[Cdecl]<void>)ptr);
    }

    public static int HookUserMsg(this ref cl_enginefunc_t enginefuncs, string szMsgName, pfnUserMsgHook pfn)
    {
        var lambda = (sbyte* pszName, int iSize, void* pbuf) =>
        {
            var Name = Marshal.PtrToStringAnsi((nint)pszName) ?? "";
            Span<byte> buffer = new Span<byte>(pbuf, iSize);
            return pfn.Invoke(Name, buffer);
        };

        var funPtr = Marshal.GetFunctionPointerForDelegate(lambda);
        using (var szMsgNameNativeString = szMsgName.GetNativeString())
        {
            return enginefuncs.pfnHookUserMsg(szMsgNameNativeString, (delegate* unmanaged[Cdecl]<sbyte*, int, void*, int>)funPtr);
        }
    }

    public static int ServerCmd(this ref cl_enginefunc_t enginefuncs, string szCmdString)
    {
        using (var szCmdStringNativeString = szCmdString.GetNativeString())
        {
            return enginefuncs.pfnServerCmd(szCmdStringNativeString);
        }
    }

    public static int ClientCmd(this ref cl_enginefunc_t enginefuncs, string szCmdString)
    {
        using (var szCmdStringNativeString = szCmdString.GetNativeString())
        {
            return enginefuncs.pfnClientCmd(szCmdStringNativeString);
        }
    }

    public static void PlaySoundByName(this ref cl_enginefunc_t enginefuncs, string szSound, float volume)
    {
        using (var szSoundNativeString = szSound.GetNativeString())
        {
             enginefuncs.pfnPlaySoundByName(szSoundNativeString, volume);
        }
    }



}
