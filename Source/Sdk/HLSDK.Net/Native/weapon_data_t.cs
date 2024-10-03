using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.HLSDK.Native;
public unsafe struct weapon_data_t
{
    public int m_iId;
    public int m_iClip;

    public float m_flNextPrimaryAttack;
    public float m_flNextSecondaryAttack;
    public float m_flTimeWeaponIdle;

    public int m_fInReload;
    public int m_fInSpecialReload;
    public float m_flNextReload;
    public float m_flPumpTime;
    public float m_fReloadTime;

    public float m_fAimedDamage;
    public float m_fNextAimBonus;
    public int m_fInZoom;
    public int m_iWeaponState;

    public int iuser1;
    public int iuser2;
    public int iuser3;
    public int iuser4;
    public float fuser1;
    public float fuser2;
    public float fuser3;
    public float fuser4;

}
