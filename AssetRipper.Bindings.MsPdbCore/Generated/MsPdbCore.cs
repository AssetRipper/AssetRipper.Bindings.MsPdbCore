using System;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.MsPdbCore;

public static unsafe partial class MsPdbCore
{
    public const int wtiSymsNB09 = 0;
    public const int wtiSymsNB10 = 1;

    public const int copyRemovePrivate = 0x00000001;
    public const int copyCreateNewSig = 0x00000002;
    public const int copyKeepAnnotation = 0x00000004;
    public const int copyKeepAnnotation2 = 0x00000008;
    public const int copyRemoveNamedStream = 0x00000010;

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpen2W([NativeTypeName("const wchar_t *")] char* wszPDB, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenEx2W([NativeTypeName("const wchar_t *")] char* wszPDB, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("long")] int cbPage, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenValidate4([NativeTypeName("const wchar_t *")] char* wszPDB, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("PCSIG70")] _GUID* pcsig70, [NativeTypeName("SIG")] uint sig, [NativeTypeName("AGE")] uint age, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenValidate5([NativeTypeName("const wchar_t *")] char* wszExecutable, [NativeTypeName("const wchar_t *")] char* wszSearchPath, void* pvClient, [NativeTypeName("PfnPDBQueryCallback")] delegate* unmanaged[Cdecl]<void*, POVC, delegate* unmanaged[Cdecl]<int>> pfnQueryCallback, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenNgenPdb([NativeTypeName("const wchar_t *")] char* wszNgenImage, [NativeTypeName("const wchar_t *")] char* wszPdbPath, [NativeTypeName("EC *")] int* pec, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchErrMax, PDB** pppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBExportValidateInterface([NativeTypeName("INTV")] uint intv);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBRPC();

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("EC")]
    public static extern int PDBQueryLastError(PDB* ppdb, [NativeTypeName("char[1024]")] sbyte* szError);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("EC")]
    public static extern int PDBQueryLastErrorExW(PDB* ppdb, [NativeTypeName("wchar_t *")] char* wszError, [NativeTypeName("size_t")] nuint cchMax);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("INTV")]
    public static extern uint PDBQueryInterfaceVersion(PDB* ppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("IMPV")]
    public static extern uint PDBQueryImplementationVersion(PDB* ppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* PDBQueryPDBName(PDB* ppdb, [NativeTypeName("char[260]")] sbyte* szPDB);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SIG")]
    public static extern uint PDBQuerySignature(PDB* ppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBQuerySignature2(PDB* ppdb, [NativeTypeName("PSIG70")] _GUID* psig70);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("AGE")]
    public static extern uint PDBQueryAge(PDB* ppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBCreateDBI(PDB* ppdb, [NativeTypeName("const char *")] sbyte* szTarget, DBI** ppdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenDBIEx(PDB* ppdb, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("const char *")] sbyte* szTarget, DBI** ppdbi, [NativeTypeName("PfnFindDebugInfoFile")] delegate* unmanaged[Stdcall]<_tagSEARCHDEBUGINFO*, int> pfn);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenDBI(PDB* ppdb, [NativeTypeName("const char *")] sbyte* szMode, [NativeTypeName("const char *")] sbyte* szTarget, DBI** ppdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenTpi(PDB* ppdb, [NativeTypeName("const char *")] sbyte* szMode, TPI** pptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenIpi(PDB* ppdb, [NativeTypeName("const char *")] sbyte* szMode, TPI** pptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBCommit(PDB* ppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBClose(PDB* ppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenStream(PDB* ppdb, [NativeTypeName("const char *")] sbyte* szStream, Stream** ppstream);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBOpenStreamEx(PDB* ppdb, [NativeTypeName("const char *")] sbyte* szStream, [NativeTypeName("const char *")] sbyte* szMode, Stream** ppstream);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBCopyTo(PDB* ppdb, [NativeTypeName("const char *")] sbyte* szTargetPdb, [NativeTypeName("DWORD")] uint dwCopyFilter, [NativeTypeName("DWORD")] uint dwReserved);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBCopyToW(PDB* ppdb, [NativeTypeName("const wchar_t *")] char* szTargetPdb, [NativeTypeName("DWORD")] uint dwCopyFilter, [NativeTypeName("DWORD")] uint dwReserved);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBfIsSZPDB(PDB* ppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBCopyToW2(PDB* ppdb, [NativeTypeName("const wchar_t *")] char* szTargetPdb, [NativeTypeName("DWORD")] uint dwCopyFilter, [NativeTypeName("PfnPDBCopyQueryCallback")] delegate* unmanaged[Cdecl]<void*, PCC, delegate* unmanaged[Cdecl]<int>> pfnCallBack, void* pvClientContext);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBRegisterPDBMapping(PDB* ppdb, [NativeTypeName("const wchar_t *")] char* wszPDBFrom, [NativeTypeName("const wchar_t *")] char* wszPDBTo);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBEnablePrefetching(PDB* ppdb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int PDBResetGUID(PDB* ppdb, byte* pb, [NativeTypeName("DWORD")] uint cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("wchar_t *")]
    public static extern char* PDBQueryPDBNameExW(PDB* ppdb, [NativeTypeName("wchar_t *")] char* wszPDB, [NativeTypeName("size_t")] nuint cchMax);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("INTV")]
    public static extern uint DBIQueryInterfaceVersion(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("IMPV")]
    public static extern uint DBIQueryImplementationVersion(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIOpenMod(DBI* pdbi, [NativeTypeName("const char *")] sbyte* szModule, [NativeTypeName("const char *")] sbyte* szFile, Mod** ppmod);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIOpenModW(DBI* pdbi, [NativeTypeName("const wchar_t *")] char* szModule, [NativeTypeName("const wchar_t *")] char* szFile, Mod** ppmod);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIDeleteMod(DBI* pdbi, [NativeTypeName("const char *")] sbyte* szModule);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryNextMod(DBI* pdbi, Mod* pmod, Mod** ppmodNext);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIOpenGlobals(DBI* pdbi, GSI** ppgsi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIOpenPublics(DBI* pdbi, GSI** ppgsi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIAddSec(DBI* pdbi, ushort isect, ushort flags, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIAddPublic(DBI* pdbi, [NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIRemovePublic(DBI* pdbi, [NativeTypeName("const char *")] sbyte* szPublic);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIAddPublic2(DBI* pdbi, [NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryModFromAddr(DBI* pdbi, ushort isect, [NativeTypeName("long")] int off, Mod** ppmod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryModFromAddr2(DBI* pdbi, ushort isect, [NativeTypeName("long")] int off, Mod** ppmod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryModFromAddrEx(DBI* pdbi, ushort isect, [NativeTypeName("ULONG")] uint off, Mod** ppmod, ushort* pisect, [NativeTypeName("ULONG *")] uint* pisectCoff, [NativeTypeName("ULONG *")] uint* poff, [NativeTypeName("ULONG *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryImodFromAddrEx(ushort isect, [NativeTypeName("ULONG")] uint off, ushort* pimod, ushort* pisect, [NativeTypeName("ULONG *")] uint* pisectCoff, [NativeTypeName("ULONG *")] uint* poff, [NativeTypeName("ULONG *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQuerySecMap(DBI* pdbi, byte* pb, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryFileInfo(DBI* pdbi, byte* pb, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQuerySupportsEC(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void DBIDumpMods(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void DBIDumpSecContribs(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void DBIDumpSecMap(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIClose(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIAddThunkMap(DBI* pdbi, [NativeTypeName("long *")] int* poffThunkMap, [NativeTypeName("unsigned int")] uint nThunks, [NativeTypeName("long")] int cbSizeOfThunk, [NativeTypeName("struct SO *")] SO* psoSectMap, [NativeTypeName("unsigned int")] uint nSects, ushort isectThunkTable, [NativeTypeName("long")] int offThunkTable);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIGetEnumContrib(DBI* pdbi, Enum** ppenum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIGetEnumContrib2(DBI* pdbi, Enum** ppenum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryTypeServer(DBI* pdbi, [NativeTypeName("ITSM")] byte itsm, TPI** pptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryItsmForTi(DBI* pdbi, [NativeTypeName("TI")] uint ti, [NativeTypeName("ITSM *")] byte* pitsm);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryNextItsm(DBI* pdbi, [NativeTypeName("ITSM")] byte itsm, [NativeTypeName("ITSM *")] byte* inext);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryLazyTypes(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBISetLazyTypes(DBI* pdbi, [NativeTypeName("BOOL")] int fLazy);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIFindTypeServers(DBI* pdbi, [NativeTypeName("EC *")] int* pec, [NativeTypeName("char[1024]")] sbyte* szError);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIOpenDbg(DBI* pdbi, DBGTYPE dbgtype, Dbg** ppdbg);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryDbgTypes(DBI* pdbi, DBGTYPE* pdbgtype, [NativeTypeName("long *")] int* pcDbgtype);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIAddLinkInfo(DBI* pdbi, [NativeTypeName("PLinkInfo")] LinkInfo* param1);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIAddLinkInfoW(DBI* pdbi, [NativeTypeName("PLinkInfoW")] LinkInfoW* param1);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIQueryLinkInfo(DBI* pdbi, [NativeTypeName("PLinkInfo")] LinkInfo* param1, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIFStripped(DBI* pdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIFAddSourceMappingItem(DBI* pdbi, [NativeTypeName("const wchar_t *")] char* szMapTo, [NativeTypeName("const wchar_t *")] char* szMapFrom, [NativeTypeName("ULONG")] uint grFlags);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void DBISetMachineType(DBI* pdbi, ushort wMachine);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void DBIRemoveDataForRva(DBI* pdbi, [NativeTypeName("ULONG")] uint rva, [NativeTypeName("ULONG")] uint cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIFSetPfnNotePdbUsed(DBI* pdbi, void* pvContext, [NativeTypeName("PFNNOTEPDBUSED")] delegate* unmanaged[Cdecl]<void*, char*, int, int, void> param2);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIFSetPfnNoteTypeMismatch(DBI* pdbi, void* pvContext, [NativeTypeName("PFNNOTETYPEMISMATCH")] delegate* unmanaged[Cdecl]<void*, char*, char*, void> param2);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DBIFSetPfnTmdTypeFilter(DBI* pdbi, void* pvContext, [NativeTypeName("PFNTMDTYPEFILTER")] delegate* unmanaged[Cdecl]<void*, char*, int> param2);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("INTV")]
    public static extern uint ModQueryInterfaceVersion(Mod* pmod);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("IMPV")]
    public static extern uint ModQueryImplementationVersion(Mod* pmod);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddTypes(Mod* pmod, byte* pbTypes, [NativeTypeName("long")] int cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModMergeTypes(Mod* pmod, byte* pb, [NativeTypeName("DWORD")] uint cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddSymbols(Mod* pmod, byte* pbSym, [NativeTypeName("long")] int cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddSymbols2(Mod* pmod, byte* pbSym, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint isectCoff);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddPublic(Mod* pmod, [NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddPublic2(Mod* pmod, [NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddLines(Mod* pmod, [NativeTypeName("const char *")] sbyte* szSrc, ushort isect, [NativeTypeName("long")] int offCon, [NativeTypeName("long")] int cbCon, [NativeTypeName("long")] int doff, ushort lineStart, byte* pbCoff, [NativeTypeName("long")] int cbCoff);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddLinesW(Mod* pmod, [NativeTypeName("const wchar_t *")] char* szSrc, ushort isect, [NativeTypeName("long")] int offCon, [NativeTypeName("long")] int cbCon, [NativeTypeName("long")] int doff, [NativeTypeName("ULONG")] uint lineStart, byte* pbCoff, [NativeTypeName("long")] int cbCoff);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddSecContrib(Mod* pmod, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, [NativeTypeName("ULONG")] uint dwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddSecContribEx(Mod* pmod, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, [NativeTypeName("ULONG")] uint dwCharacteristics, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddSecContrib2(Mod* pmod, ushort isect, [NativeTypeName("DWORD")] uint off, [NativeTypeName("DWORD")] uint isectCoff, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint dwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModAddSecContrib2Ex(Mod* pmod, ushort isect, [NativeTypeName("DWORD")] uint off, [NativeTypeName("DWORD")] uint isecfCoff, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint dwCharacteristics, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryCBName(Mod* pmod, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryName(Mod* pmod, [NativeTypeName("char[260]")] sbyte* szName, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQuerySymbols(Mod* pmod, byte* pbSym, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryCoffSymRVAs(Mod* pmod, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModIsTypeServed(Mod* pmod, [NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryTypes(Mod* pmod, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryIDs(Mod* pmod, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryCVRecordForTi(Mod* pmod, [NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryPbCVRecordForTi(Mod* pmod, [NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID, byte** ppb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryTiForUDT(Mod* pmod, [NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI *")] uint* pti);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryLines(Mod* pmod, byte* pbLines, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryLines2(Mod* pmod, [NativeTypeName("long")] int cb, byte* pbLines, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModSetPvClient(Mod* pmod, void* pvClient);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModGetPvClient(Mod* pmod, void** ppvClient);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQuerySecContrib(Mod* pmod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryFirstCodeSecContrib(Mod* pmod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryImod(Mod* pmod, ushort* pimod);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryDBI(Mod* pmod, DBI** ppdbi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModClose(Mod* pmod);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryCBFile(Mod* pmod, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryFile(Mod* pmod, [NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQuerySrcFile(Mod* pmod, [NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryPdbFile(Mod* pmod, [NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQuerySupportsEC(Mod* pmod);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryTpi(Mod* pmod, TPI** pptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModReplaceLines(Mod* pmod, byte* pbLines, [NativeTypeName("long")] int cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryCrossScopeExports(Mod* pmod, [NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryCrossScopeImports(Mod* pmod, [NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryInlineeLines(Mod* pmod, [NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModTranslateFileId(Mod* pmod, [NativeTypeName("DWORD")] uint id, [NativeTypeName("DWORD *")] uint* pid);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryFuncMDTokenMap(Mod* pmod, [NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryTypeMDTokenMap(Mod* pmod, [NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryMergedAssemblyInput(Mod* pmod, [NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryILLines(Mod* pmod, [NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModGetEnumILLines(Mod* pmod, EnumLines** ppenum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModQueryILLineFlags(Mod* pmod, [NativeTypeName("DWORD *")] uint* pdwFlags);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int ModRemoveGlobalRefs(Mod* pmod);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("INTV")]
    public static extern uint TypesQueryInterfaceVersion(TPI* ptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("IMPV")]
    public static extern uint TypesQueryImplementationVersion(TPI* ptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesQueryTiForCVRecordEx(TPI* ptpi, byte* pb, [NativeTypeName("TI *")] uint* pti);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesQueryCVRecordForTiEx(TPI* ptpi, [NativeTypeName("TI")] uint ti, byte* pb, [NativeTypeName("long *")] int* pcb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesQueryPbCVRecordForTiEx(TPI* ptpi, [NativeTypeName("TI")] uint ti, byte** ppb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("TI")]
    public static extern uint TypesQueryTiMinEx(TPI* ptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("TI")]
    public static extern uint TypesQueryTiMacEx(TPI* ptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern int TypesQueryCb(TPI* ptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesClose(TPI* ptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesCommit(TPI* ptpi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesQueryTiForUDTEx(TPI* ptpi, [NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI *")] uint* pti);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesSupportQueryTiForUDT(TPI* param0);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesfIs16bitTypePool(TPI* param0);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesAreTypesEqual(TPI* ptpi, [NativeTypeName("TI")] uint ti1, [NativeTypeName("TI")] uint ti2);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int TypesIsTypeServed(TPI* ptpi, [NativeTypeName("TI")] uint ti);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern byte* GSINextSym(GSI* pgsi, byte* pbSym);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern byte* GSIHashSym(GSI* pgsi, [NativeTypeName("const char *")] sbyte* szName, byte* pbSym);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern byte* GSINearestSym(GSI* pgsi, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long *")] int* pdisp);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int GSIClose(GSI* pgsi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern uint GSIOffForSym(GSI* pgsi, byte* pbSym);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern byte* GSISymForOff(GSI* pgsi, [NativeTypeName("unsigned long")] uint off);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern int StreamQueryCb(Stream* pstream);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamRead(Stream* pstream, [NativeTypeName("long")] int off, void* pvBuf, [NativeTypeName("long *")] int* pcbBuf);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamWrite(Stream* pstream, [NativeTypeName("long")] int off, void* pvBuf, [NativeTypeName("long")] int cbBuf);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamReplace(Stream* pstream, void* pvBuf, [NativeTypeName("long")] int cbBuf);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamAppend(Stream* pstream, void* pvBuf, [NativeTypeName("long")] int cbBuf);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamDelete(Stream* pstream);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamTruncate(Stream* pstream, [NativeTypeName("long")] int cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamRelease(Stream* pstream);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamImageOpen(Stream* pstream, [NativeTypeName("long")] int cb, StreamImage** ppsi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* StreamImageBase(StreamImage* psi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern int StreamImageSize(StreamImage* psi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamImageNoteRead(StreamImage* psi, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, void** ppv);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamImageNoteWrite(StreamImage* psi, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, void** ppv);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamImageWriteBack(StreamImage* psi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int StreamImageRelease(StreamImage* psi);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int NameMapOpen(PDB* ppdb, [NativeTypeName("BOOL")] int fWrite, NameMap** ppnm);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int NameMapClose(NameMap* pnm);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int NameMapReinitialize(NameMap* pnm);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int NameMapGetNi(NameMap* pnm, [NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int NameMapGetName(NameMap* pnm, [NativeTypeName("NI")] uint ni, [NativeTypeName("const char **")] sbyte** psz);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int NameMapGetEnumNameMap(NameMap* pnm, Enum** ppenum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int NameMapCommit(NameMap* pnm);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EnumNameMapRelease(EnumNameMap* penum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EnumNameMapReset(EnumNameMap* penum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int EnumNameMapNext(EnumNameMap* penum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EnumNameMapGet(EnumNameMap* penum, [NativeTypeName("const char **")] sbyte** psz, [NativeTypeName("NI *")] uint* pni);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EnumContribRelease(EnumContrib* penum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EnumContribReset(EnumContrib* penum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int EnumContribNext(EnumContrib* penum);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EnumContribGet(EnumContrib* penum, ushort* pimod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EnumContribGet2(EnumContrib* penum, ushort* pimod, ushort* pisect, [NativeTypeName("DWORD *")] uint* poff, [NativeTypeName("DWORD *")] uint* pisectCoff, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EnumContribGetCrcs(EnumContrib* penum, [NativeTypeName("DWORD *")] uint* pcrcData, [NativeTypeName("DWORD *")] uint* pcrcReloc);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int EnumContribfUpdate(EnumContrib* penum, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SIG")]
    public static extern uint SigForPbCb(byte* pb, [NativeTypeName("size_t")] nuint cb, [NativeTypeName("SIG")] uint sig);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TruncStFromSz([NativeTypeName("char *")] sbyte* stDst, [NativeTypeName("const char *")] sbyte* szSrc, [NativeTypeName("size_t")] nuint cbSrc);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DbgClose(Dbg* pdbg);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern int DbgQuerySize(Dbg* pdbg);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void DbgReset(Dbg* pdbg);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DbgSkip(Dbg* pdbg, [NativeTypeName("ULONG")] uint celt);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DbgQueryNext(Dbg* pdbg, [NativeTypeName("ULONG")] uint celt, void* rgelt);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DbgFind(Dbg* pdbg, void* pelt);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DbgClear(Dbg* pdbg);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DbgAppend(Dbg* pdbg, [NativeTypeName("ULONG")] uint celt, [NativeTypeName("const void *")] void* rgelt);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int DbgReplaceNext(Dbg* pdbg, [NativeTypeName("ULONG")] uint celt, [NativeTypeName("const void *")] void* rgelt);

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("wchar_t *")]
    public static extern char* SzCanonFilename([NativeTypeName("wchar_t *")] char* szFilename);

    [NativeTypeName("#define TypesQueryPbCVRecordForTi TypesQueryPbCVRecordForTiEx")]
    public static delegate*<TPI*, uint, byte**, int> TypesQueryPbCVRecordForTi => &TypesQueryPbCVRecordForTiEx;

    [NativeTypeName("#define TypesQueryTiForUDT TypesQueryTiForUDTEx")]
    public static delegate*<TPI*, sbyte*, int, uint*, int> TypesQueryTiForUDT => &TypesQueryTiForUDTEx;

    [NativeTypeName("#define cbNil ((long)-1)")]
    public const int cbNil = ((int)(-1));

    [NativeTypeName("#define tsNil ((TPI*)0)")]
    public static TPI* tsNil => ((TPI*)(0));

    [NativeTypeName("#define tiNil ((TI)0)")]
    public const uint tiNil = ((uint)(0));

    [NativeTypeName("#define imodNil ((USHORT)(-1))")]
    public const ushort imodNil = unchecked((ushort)(-1));

    [NativeTypeName("#define pdbFSCompress \"C\"")]
    public static ReadOnlySpan<byte> pdbFSCompress => "C"u8;

    [NativeTypeName("#define pdbVC120 \"L\"")]
    public static ReadOnlySpan<byte> pdbVC120 => "L"u8;

    [NativeTypeName("#define pdbTypeAppend \"a\"")]
    public static ReadOnlySpan<byte> pdbTypeAppend => "a"u8;

    [NativeTypeName("#define pdbGetRecordsOnly \"c\"")]
    public static ReadOnlySpan<byte> pdbGetRecordsOnly => "c"u8;

    [NativeTypeName("#define pdbFullBuild \"f\"")]
    public static ReadOnlySpan<byte> pdbFullBuild => "f"u8;

    [NativeTypeName("#define pdbGetTiOnly \"i\"")]
    public static ReadOnlySpan<byte> pdbGetTiOnly => "i"u8;

    [NativeTypeName("#define pdbNoTypeMergeLink \"l\"")]
    public static ReadOnlySpan<byte> pdbNoTypeMergeLink => "l"u8;

    [NativeTypeName("#define pdbTypeMismatchesLink \"m\"")]
    public static ReadOnlySpan<byte> pdbTypeMismatchesLink => "m"u8;

    [NativeTypeName("#define pdbNewNameMap \"n\"")]
    public static ReadOnlySpan<byte> pdbNewNameMap => "n"u8;

    [NativeTypeName("#define pdbMinimalLink \"o\"")]
    public static ReadOnlySpan<byte> pdbMinimalLink => "o"u8;

    [NativeTypeName("#define pdbRead \"r\"")]
    public static ReadOnlySpan<byte> pdbRead => "r"u8;

    [NativeTypeName("#define pdbWriteShared \"s\"")]
    public static ReadOnlySpan<byte> pdbWriteShared => "s"u8;

    [NativeTypeName("#define pdbCTypes \"t\"")]
    public static ReadOnlySpan<byte> pdbCTypes => "t"u8;

    [NativeTypeName("#define pdbWrite \"w\"")]
    public static ReadOnlySpan<byte> pdbWrite => "w"u8;

    [NativeTypeName("#define pdbExclusive \"x\"")]
    public static ReadOnlySpan<byte> pdbExclusive => "x"u8;

    [NativeTypeName("#define pdbRepro \"z\"")]
    public static ReadOnlySpan<byte> pdbRepro => "z"u8;
}
