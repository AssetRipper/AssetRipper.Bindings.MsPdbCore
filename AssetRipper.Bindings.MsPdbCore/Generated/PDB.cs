using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct PDB : PDB.Interface
{
    public void** lpVtbl;

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Open2W@PDB@@SAHPEB_WPEBDPEAJPEA_W_KPEAPEAU1@@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int Open2W([NativeTypeName("const wchar_t *")] char* wszPDB, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?OpenEx2W@PDB@@SAHPEB_WPEBDJPEAJPEA_W_KPEAPEAU1@@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int OpenEx2W([NativeTypeName("const wchar_t *")] char* wszPDB, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("long")] int cbPage, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?OpenValidate4@PDB@@SAHPEB_WPEBDPEBU_GUID@@KKPEAJPEA_W_KPEAPEAU1@@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int OpenValidate4([NativeTypeName("const wchar_t *")] char* wszPDB, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("PCSIG70")] _GUID* pcsig70, [NativeTypeName("SIG")] uint sig, [NativeTypeName("AGE")] uint age, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?OpenValidate5@PDB@@SAHPEB_W0PEAXP6AP6AHXZ1W4POVC@@@ZPEAJPEA_W_KPEAPEAU1@@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int OpenValidate5([NativeTypeName("const wchar_t *")] char* wszExecutable, [NativeTypeName("const wchar_t *")] char* wszSearchPath, void* pvClient, [NativeTypeName("PfnPDBQueryCallback")] delegate* unmanaged[Cdecl]<void*, POVC, delegate* unmanaged[Cdecl]<int>> pfnQueryCallback, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?OpenInStream@PDB@@SAHPEAUIStream@@PEBDPEAJPEA_W_KPEAPEAU1@@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int OpenInStream(IStream* pIStream, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?OpenNgenPdb@PDB@@SAHPEB_W0PEAJPEA_W_KPEAPEAU1@@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int OpenNgenPdb([NativeTypeName("const wchar_t *")] char* wszNgenImage, [NativeTypeName("const wchar_t *")] char* wszPdbPath, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ExportValidateInterface@PDB@@SAHK@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ExportValidateInterface([NativeTypeName("INTV")] uint intv);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ExportValidateImplementation@PDB@@SAHK@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ExportValidateImplementation([NativeTypeName("IMPV")] uint impv);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?QueryImplementationVersionStatic@PDB@@SAKXZ", ExactSpelling = true)]
    [return: NativeTypeName("IMPV")]
    public static extern uint QueryImplementationVersionStatic();

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?QueryInterfaceVersionStatic@PDB@@SAKXZ", ExactSpelling = true)]
    [return: NativeTypeName("INTV")]
    public static extern uint QueryInterfaceVersionStatic();

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetErrorHandlerAPI@PDB@@SAHP6APEAUIPDBError@@PEAU1@@Z@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int SetErrorHandlerAPI([NativeTypeName("PfnPDBErrorCreate")] delegate* unmanaged[Cdecl]<PDB*, IPDBError*> pfn);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetPDBCloseTimeout@PDB@@SAH_K@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int SetPDBCloseTimeout([NativeTypeName("DWORDLONG")] ulong t);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ShutDownTimeoutManager@PDB@@SAHXZ", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ShutDownTimeoutManager();

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?CloseAllTimeoutPDB@PDB@@SAHXZ", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int CloseAllTimeoutPDB();

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?RPC@PDB@@SAHXZ", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int RPC();

    public const int intv = (int)PDBINTV.PDBIntv;
    public const int intvVC80 = (int)PDBINTV.PDBIntv80;
    public const int intvVC70 = (int)PDBINTV.PDBIntv70;
    public const int intvVC70Dep = (int)PDBINTV.PDBIntv70Dep;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("INTV")]
    public uint QueryInterfaceVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, uint>)(lpVtbl[0]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("IMPV")]
    public uint QueryImplementationVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, uint>)(lpVtbl[1]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("EC")]
    public int QueryLastError([NativeTypeName("char[1024]")] sbyte* szError)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, int>)(lpVtbl[2]))((PDB*)Unsafe.AsPointer(ref this), szError);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("char *")]
    public sbyte* QueryPDBName([NativeTypeName("char[260]")] sbyte* szPDB)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, sbyte*>)(lpVtbl[3]))((PDB*)Unsafe.AsPointer(ref this), szPDB);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIG")]
    public uint QuerySignature()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, uint>)(lpVtbl[4]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("AGE")]
    public uint QueryAge()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, uint>)(lpVtbl[5]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int CreateDBI([NativeTypeName("const char *")] sbyte* szTarget, DBI** ppdbi)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, DBI**, int>)(lpVtbl[6]))((PDB*)Unsafe.AsPointer(ref this), szTarget, ppdbi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("BOOL")]
    public int OpenDBI([NativeTypeName("const char *")] sbyte* szTarget, [NativeTypeName("const char *")] sbyte* szMode, DBI** ppdbi)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, sbyte*, DBI**, int>)(lpVtbl[7]))((PDB*)Unsafe.AsPointer(ref this), szTarget, szMode, ppdbi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int OpenTpi([NativeTypeName("const char *")] sbyte* szMode, TPI** pptpi)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, TPI**, int>)(lpVtbl[8]))((PDB*)Unsafe.AsPointer(ref this), szMode, pptpi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("BOOL")]
    public int OpenIpi([NativeTypeName("const char *")] sbyte* szMode, TPI** pptpi)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, TPI**, int>)(lpVtbl[9]))((PDB*)Unsafe.AsPointer(ref this), szMode, pptpi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("BOOL")]
    public int Commit()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, int>)(lpVtbl[10]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("BOOL")]
    public int Close()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, int>)(lpVtbl[11]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("BOOL")]
    public int OpenStream([NativeTypeName("const char *")] sbyte* szStream, Stream** ppstream)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, Stream**, int>)(lpVtbl[12]))((PDB*)Unsafe.AsPointer(ref this), szStream, ppstream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("BOOL")]
    public int GetEnumStreamNameMap(Enum** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, Enum**, int>)(lpVtbl[13]))((PDB*)Unsafe.AsPointer(ref this), ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("BOOL")]
    public int GetRawBytes([NativeTypeName("PFNfReadPDBRawBytes")] delegate* unmanaged[Cdecl]<void*, int, int> pfnfSnarfRawBytes)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, delegate* unmanaged[Cdecl]<void*, int, int>, int>)(lpVtbl[14]))((PDB*)Unsafe.AsPointer(ref this), pfnfSnarfRawBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("IMPV")]
    public uint QueryPdbImplementationVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, uint>)(lpVtbl[15]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("BOOL")]
    public int OpenDBIEx([NativeTypeName("const char *")] sbyte* szTarget, [NativeTypeName("const char *")] sbyte* szMode, DBI** ppdbi, [NativeTypeName("PfnFindDebugInfoFile")] delegate* unmanaged[Stdcall]<_tagSEARCHDEBUGINFO*, int> pfn = null)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, sbyte*, DBI**, delegate* unmanaged[Stdcall]<_tagSEARCHDEBUGINFO*, int>, int>)(lpVtbl[16]))((PDB*)Unsafe.AsPointer(ref this), szTarget, szMode, ppdbi, pfn);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [return: NativeTypeName("BOOL")]
    public int CopyTo([NativeTypeName("const char *")] sbyte* szDst, [NativeTypeName("DWORD")] uint dwCopyFilter, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, uint, uint, int>)(lpVtbl[17]))((PDB*)Unsafe.AsPointer(ref this), szDst, dwCopyFilter, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("BOOL")]
    public int OpenSrc(Src** ppsrc)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, Src**, int>)(lpVtbl[18]))((PDB*)Unsafe.AsPointer(ref this), ppsrc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("EC")]
    public int QueryLastErrorExW([NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchMax)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, char*, nuint, int>)(lpVtbl[19]))((PDB*)Unsafe.AsPointer(ref this), wszError, cchMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("wchar_t *")]
    public char* QueryPDBNameExW([NativeTypeName("wchar_t *")] char* wszPDB, [NativeTypeName("size_t")] nuint cchMax)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, char*, nuint, char*>)(lpVtbl[20]))((PDB*)Unsafe.AsPointer(ref this), wszPDB, cchMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("BOOL")]
    public int QuerySignature2([NativeTypeName("PSIG70")] _GUID* psig70)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, _GUID*, int>)(lpVtbl[21]))((PDB*)Unsafe.AsPointer(ref this), psig70);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("BOOL")]
    public int CopyToW([NativeTypeName("const wchar_t *")] char* szDst, [NativeTypeName("DWORD")] uint dwCopyFilter, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, char*, uint, uint, int>)(lpVtbl[22]))((PDB*)Unsafe.AsPointer(ref this), szDst, dwCopyFilter, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("BOOL")]
    public int fIsSZPDB()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, int>)(lpVtbl[23]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [return: NativeTypeName("BOOL")]
    public int OpenStreamW([NativeTypeName("const wchar_t *")] char* szStream, Stream** ppstream)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, char*, Stream**, int>)(lpVtbl[24]))((PDB*)Unsafe.AsPointer(ref this), szStream, ppstream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [return: NativeTypeName("BOOL")]
    public int CopyToW2([NativeTypeName("const wchar_t *")] char* szDst, [NativeTypeName("DWORD")] uint dwCopyFilter, [NativeTypeName("PfnPDBCopyQueryCallback")] delegate* unmanaged[Cdecl]<void*, PCC, delegate* unmanaged[Cdecl]<int>> pfnCallBack, void* pvClientContext)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, char*, uint, delegate* unmanaged[Cdecl]<void*, PCC, delegate* unmanaged[Cdecl]<int>>, void*, int>)(lpVtbl[25]))((PDB*)Unsafe.AsPointer(ref this), szDst, dwCopyFilter, pfnCallBack, pvClientContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("BOOL")]
    public int OpenStreamEx([NativeTypeName("const char *")] sbyte* szStream, [NativeTypeName("const char *")] sbyte* szMode, Stream** ppStream)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, sbyte*, sbyte*, Stream**, int>)(lpVtbl[26]))((PDB*)Unsafe.AsPointer(ref this), szStream, szMode, ppStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [return: NativeTypeName("BOOL")]
    public int RegisterPDBMapping([NativeTypeName("const wchar_t *")] char* wszPDBFrom, [NativeTypeName("const wchar_t *")] char* wszPDBTo)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, char*, char*, int>)(lpVtbl[27]))((PDB*)Unsafe.AsPointer(ref this), wszPDBFrom, wszPDBTo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [return: NativeTypeName("BOOL")]
    public int EnablePrefetching()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, int>)(lpVtbl[28]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [return: NativeTypeName("BOOL")]
    public int FLazy()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, int>)(lpVtbl[29]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [return: NativeTypeName("BOOL")]
    public int FMinimal()
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, int>)(lpVtbl[30]))((PDB*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("BOOL")]
    public int ResetGUID(byte* pb, [NativeTypeName("DWORD")] uint cb)
    {
        return ((delegate* unmanaged[MemberFunction]<PDB*, byte*, uint, int>)(lpVtbl[31]))((PDB*)Unsafe.AsPointer(ref this), pb, cb);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("INTV")]
        uint QueryInterfaceVersion();

        [VtblIndex(1)]
        [return: NativeTypeName("IMPV")]
        uint QueryImplementationVersion();

        [VtblIndex(2)]
        [return: NativeTypeName("EC")]
        int QueryLastError([NativeTypeName("char[1024]")] sbyte* szError);

        [VtblIndex(3)]
        [return: NativeTypeName("char *")]
        sbyte* QueryPDBName([NativeTypeName("char[260]")] sbyte* szPDB);

        [VtblIndex(4)]
        [return: NativeTypeName("SIG")]
        uint QuerySignature();

        [VtblIndex(5)]
        [return: NativeTypeName("AGE")]
        uint QueryAge();

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int CreateDBI([NativeTypeName("const char *")] sbyte* szTarget, DBI** ppdbi);

        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        int OpenDBI([NativeTypeName("const char *")] sbyte* szTarget, [NativeTypeName("const char *")] sbyte* szMode, DBI** ppdbi);

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int OpenTpi([NativeTypeName("const char *")] sbyte* szMode, TPI** pptpi);

        [VtblIndex(9)]
        [return: NativeTypeName("BOOL")]
        int OpenIpi([NativeTypeName("const char *")] sbyte* szMode, TPI** pptpi);

        [VtblIndex(10)]
        [return: NativeTypeName("BOOL")]
        int Commit();

        [VtblIndex(11)]
        [return: NativeTypeName("BOOL")]
        int Close();

        [VtblIndex(12)]
        [return: NativeTypeName("BOOL")]
        int OpenStream([NativeTypeName("const char *")] sbyte* szStream, Stream** ppstream);

        [VtblIndex(13)]
        [return: NativeTypeName("BOOL")]
        int GetEnumStreamNameMap(Enum** ppenum);

        [VtblIndex(15)]
        [return: NativeTypeName("IMPV")]
        uint QueryPdbImplementationVersion();

        [VtblIndex(17)]
        [return: NativeTypeName("BOOL")]
        int CopyTo([NativeTypeName("const char *")] sbyte* szDst, [NativeTypeName("DWORD")] uint dwCopyFilter, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(18)]
        [return: NativeTypeName("BOOL")]
        int OpenSrc(Src** ppsrc);

        [VtblIndex(19)]
        [return: NativeTypeName("EC")]
        int QueryLastErrorExW([NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchMax);

        [VtblIndex(20)]
        [return: NativeTypeName("wchar_t *")]
        char* QueryPDBNameExW([NativeTypeName("wchar_t *")] char* wszPDB, [NativeTypeName("size_t")] nuint cchMax);

        [VtblIndex(21)]
        [return: NativeTypeName("BOOL")]
        int QuerySignature2([NativeTypeName("PSIG70")] _GUID* psig70);

        [VtblIndex(22)]
        [return: NativeTypeName("BOOL")]
        int CopyToW([NativeTypeName("const wchar_t *")] char* szDst, [NativeTypeName("DWORD")] uint dwCopyFilter, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(23)]
        [return: NativeTypeName("BOOL")]
        int fIsSZPDB();

        [VtblIndex(24)]
        [return: NativeTypeName("BOOL")]
        int OpenStreamW([NativeTypeName("const wchar_t *")] char* szStream, Stream** ppstream);

        [VtblIndex(26)]
        [return: NativeTypeName("BOOL")]
        int OpenStreamEx([NativeTypeName("const char *")] sbyte* szStream, [NativeTypeName("const char *")] sbyte* szMode, Stream** ppStream);

        [VtblIndex(27)]
        [return: NativeTypeName("BOOL")]
        int RegisterPDBMapping([NativeTypeName("const wchar_t *")] char* wszPDBFrom, [NativeTypeName("const wchar_t *")] char* wszPDBTo);

        [VtblIndex(28)]
        [return: NativeTypeName("BOOL")]
        int EnablePrefetching();

        [VtblIndex(29)]
        [return: NativeTypeName("BOOL")]
        int FLazy();

        [VtblIndex(30)]
        [return: NativeTypeName("BOOL")]
        int FMinimal();

        [VtblIndex(31)]
        [return: NativeTypeName("BOOL")]
        int ResetGUID(byte* pb, [NativeTypeName("DWORD")] uint cb);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("INTV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryInterfaceVersion;

        [NativeTypeName("IMPV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryImplementationVersion;

        [NativeTypeName("EC (char *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> QueryLastError;

        [NativeTypeName("char *(char *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, sbyte*> QueryPDBName;

        [NativeTypeName("SIG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QuerySignature;

        [NativeTypeName("AGE ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryAge;

        [NativeTypeName("BOOL (const char *, DBI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, DBI**, int> CreateDBI;

        [NativeTypeName("BOOL (const char *, const char *, DBI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, sbyte*, DBI**, int> OpenDBI;

        [NativeTypeName("BOOL (const char *, TPI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, TPI**, int> OpenTpi;

        [NativeTypeName("BOOL (const char *, TPI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, TPI**, int> OpenIpi;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Commit;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("BOOL (const char *, Stream **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, Stream**, int> OpenStream;

        [NativeTypeName("BOOL (Enum **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Enum**, int> GetEnumStreamNameMap;

        [NativeTypeName("BOOL (PFNfReadPDBRawBytes)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged[Cdecl]<void*, int, int>, int> GetRawBytes;

        [NativeTypeName("IMPV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryPdbImplementationVersion;

        [NativeTypeName("BOOL (const char *, const char *, DBI **, PfnFindDebugInfoFile)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, sbyte*, DBI**, delegate* unmanaged[Stdcall]<_tagSEARCHDEBUGINFO*, int>, int> OpenDBIEx;

        [NativeTypeName("BOOL (const char *, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, uint, uint, int> CopyTo;

        [NativeTypeName("BOOL (Src **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Src**, int> OpenSrc;

        [NativeTypeName("EC (wchar_t *, size_t)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, nuint, int> QueryLastErrorExW;

        [NativeTypeName("wchar_t *(wchar_t *, size_t)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, nuint, char*> QueryPDBNameExW;

        [NativeTypeName("BOOL (PSIG70)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, _GUID*, int> QuerySignature2;

        [NativeTypeName("BOOL (const wchar_t *, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, uint, int> CopyToW;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> fIsSZPDB;

        [NativeTypeName("BOOL (const wchar_t *, Stream **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Stream**, int> OpenStreamW;

        [NativeTypeName("BOOL (const wchar_t *, DWORD, PfnPDBCopyQueryCallback, void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, delegate* unmanaged[Cdecl]<void*, PCC, delegate* unmanaged[Cdecl]<int>>, void*, int> CopyToW2;

        [NativeTypeName("BOOL (const char *, const char *, Stream **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, sbyte*, Stream**, int> OpenStreamEx;

        [NativeTypeName("BOOL (const wchar_t *, const wchar_t *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> RegisterPDBMapping;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> EnablePrefetching;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> FLazy;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> FMinimal;

        [NativeTypeName("BOOL (BYTE *, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, int> ResetGUID;
    }
}
