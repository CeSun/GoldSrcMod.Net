namespace GoldSrc.Metahook.Native;

public unsafe struct hook_t
{
    public void* pOldFuncAddr;
    public void* pNewFuncAddr;
    public void* pClass;
    public int iTableIndex;
    public int iFuncIndex;
    public nint hModule;
    public sbyte* pszModuleName;
    public sbyte* pszFuncName;
    public hook_t* pNext;
	public void* pInfo;

}
