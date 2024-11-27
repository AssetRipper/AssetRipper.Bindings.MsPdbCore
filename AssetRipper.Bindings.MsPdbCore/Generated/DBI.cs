using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct DBI : DBI.Interface
{
    public void** lpVtbl;

    public const int intv = (int)PDBINTV.PDBIntv;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("IMPV")]
    public uint QueryImplementationVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, uint>)(lpVtbl[0]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("INTV")]
    public uint QueryInterfaceVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, uint>)(lpVtbl[1]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int OpenMod([NativeTypeName("const char *")] sbyte* szModule, [NativeTypeName("const char *")] sbyte* szFile, Mod** ppmod)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, sbyte*, sbyte*, Mod**, int>)(lpVtbl[2]))((DBI*)Unsafe.AsPointer(ref this), szModule, szFile, ppmod);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public int DeleteMod([NativeTypeName("const char *")] sbyte* szModule)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, sbyte*, int>)(lpVtbl[3]))((DBI*)Unsafe.AsPointer(ref this), szModule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int QueryNextMod(Mod* pmod, Mod** ppmodNext)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, Mod*, Mod**, int>)(lpVtbl[4]))((DBI*)Unsafe.AsPointer(ref this), pmod, ppmodNext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int OpenGlobals(GSI** ppgsi)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, GSI**, int>)(lpVtbl[5]))((DBI*)Unsafe.AsPointer(ref this), ppgsi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int OpenPublics(GSI** ppgsi)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, GSI**, int>)(lpVtbl[6]))((DBI*)Unsafe.AsPointer(ref this), ppgsi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("BOOL")]
    public int AddSec(ushort isect, ushort flags, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort, ushort, int, int, int>)(lpVtbl[7]))((DBI*)Unsafe.AsPointer(ref this), isect, flags, off, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int QueryModFromAddr(ushort isect, [NativeTypeName("long")] int off, Mod** ppmod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort, int, Mod**, ushort*, int*, int*, int>)(lpVtbl[8]))((DBI*)Unsafe.AsPointer(ref this), isect, off, ppmod, pisect, poff, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("BOOL")]
    public int QuerySecMap(byte* pb, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, byte*, int*, int>)(lpVtbl[9]))((DBI*)Unsafe.AsPointer(ref this), pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("BOOL")]
    public int QueryFileInfo(byte* pb, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, byte*, int*, int>)(lpVtbl[10]))((DBI*)Unsafe.AsPointer(ref this), pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void DumpMods()
    {
        ((delegate* unmanaged[MemberFunction]<DBI*, void>)(lpVtbl[11]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void DumpSecContribs()
    {
        ((delegate* unmanaged[MemberFunction]<DBI*, void>)(lpVtbl[12]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void DumpSecMap()
    {
        ((delegate* unmanaged[MemberFunction]<DBI*, void>)(lpVtbl[13]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("BOOL")]
    public int Close()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int>)(lpVtbl[14]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("BOOL")]
    public int AddThunkMap([NativeTypeName("long *")] int* poffThunkMap, [NativeTypeName("unsigned int")] uint nThunks, [NativeTypeName("long")] int cbSizeOfThunk, [NativeTypeName("struct SO *")] SO* psoSectMap, [NativeTypeName("unsigned int")] uint nSects, ushort isectThunkTable, [NativeTypeName("long")] int offThunkTable)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int*, uint, int, SO*, uint, ushort, int, int>)(lpVtbl[15]))((DBI*)Unsafe.AsPointer(ref this), poffThunkMap, nThunks, cbSizeOfThunk, psoSectMap, nSects, isectThunkTable, offThunkTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("BOOL")]
    public int AddPublic([NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, sbyte*, ushort, int, int>)(lpVtbl[16]))((DBI*)Unsafe.AsPointer(ref this), szPublic, isect, off);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [return: NativeTypeName("BOOL")]
    public int getEnumContrib(Enum** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, Enum**, int>)(lpVtbl[17]))((DBI*)Unsafe.AsPointer(ref this), ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("BOOL")]
    public int QueryTypeServer([NativeTypeName("ITSM")] byte itsm, TPI** pptpi)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, byte, TPI**, int>)(lpVtbl[18]))((DBI*)Unsafe.AsPointer(ref this), itsm, pptpi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("BOOL")]
    public int QueryItsmForTi([NativeTypeName("TI")] uint ti, [NativeTypeName("ITSM *")] byte* pitsm)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, uint, byte*, int>)(lpVtbl[19]))((DBI*)Unsafe.AsPointer(ref this), ti, pitsm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("BOOL")]
    public int QueryNextItsm([NativeTypeName("ITSM")] byte itsm, [NativeTypeName("ITSM *")] byte* inext)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, byte, byte*, int>)(lpVtbl[20]))((DBI*)Unsafe.AsPointer(ref this), itsm, inext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("BOOL")]
    public int QueryLazyTypes()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int>)(lpVtbl[21]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("BOOL")]
    public int SetLazyTypes([NativeTypeName("BOOL")] int fLazy)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int, int>)(lpVtbl[22]))((DBI*)Unsafe.AsPointer(ref this), fLazy);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("BOOL")]
    public int FindTypeServers([NativeTypeName("EC *")] int* pec, [NativeTypeName("char[1024]")] sbyte* szError)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int*, sbyte*, int>)(lpVtbl[23]))((DBI*)Unsafe.AsPointer(ref this), pec, szError);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void DumpTypeServers()
    {
        ((delegate* unmanaged[MemberFunction]<DBI*, void>)(lpVtbl[24]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [return: NativeTypeName("BOOL")]
    public int OpenDbg(DBGTYPE dbgtype, Dbg** ppdbg)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, DBGTYPE, Dbg**, int>)(lpVtbl[25]))((DBI*)Unsafe.AsPointer(ref this), dbgtype, ppdbg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("BOOL")]
    public int QueryDbgTypes(DBGTYPE* pdbgtype, [NativeTypeName("long *")] int* pcDbgtype)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, DBGTYPE*, int*, int>)(lpVtbl[26]))((DBI*)Unsafe.AsPointer(ref this), pdbgtype, pcDbgtype);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [return: NativeTypeName("BOOL")]
    public int QueryAddrForSec(ushort* pisect, [NativeTypeName("long *")] int* poff, ushort imod, [NativeTypeName("long")] int cb, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort*, int*, ushort, int, uint, uint, int>)(lpVtbl[27]))((DBI*)Unsafe.AsPointer(ref this), pisect, poff, imod, cb, dwDataCrc, dwRelocCrc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [return: NativeTypeName("BOOL")]
    public int QueryAddrForSecEx(ushort* pisect, [NativeTypeName("long *")] int* poff, ushort imod, [NativeTypeName("long")] int cb, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc, [NativeTypeName("DWORD")] uint dwCharacteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort*, int*, ushort, int, uint, uint, uint, int>)(lpVtbl[28]))((DBI*)Unsafe.AsPointer(ref this), pisect, poff, imod, cb, dwDataCrc, dwRelocCrc, dwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [return: NativeTypeName("BOOL")]
    public int QuerySupportsEC()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int>)(lpVtbl[29]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [return: NativeTypeName("BOOL")]
    public int QueryPdb(PDB** pppdb)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, PDB**, int>)(lpVtbl[30]))((DBI*)Unsafe.AsPointer(ref this), pppdb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("BOOL")]
    public int AddLinkInfo([NativeTypeName("PLinkInfo")] LinkInfo* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, LinkInfo*, int>)(lpVtbl[31]))((DBI*)Unsafe.AsPointer(ref this), param0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("BOOL")]
    public int QueryLinkInfo([NativeTypeName("PLinkInfo")] LinkInfo* param0, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, LinkInfo*, int*, int>)(lpVtbl[32]))((DBI*)Unsafe.AsPointer(ref this), param0, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [return: NativeTypeName("AGE")]
    public uint QueryAge()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, uint>)(lpVtbl[33]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void* QueryHeader()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, void*>)(lpVtbl[34]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public void FlushTypeServers()
    {
        ((delegate* unmanaged[MemberFunction]<DBI*, void>)(lpVtbl[35]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [return: NativeTypeName("BOOL")]
    public int QueryTypeServerByPdb([NativeTypeName("const char *")] sbyte* szPdb, [NativeTypeName("ITSM *")] byte* pitsm)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, sbyte*, byte*, int>)(lpVtbl[36]))((DBI*)Unsafe.AsPointer(ref this), szPdb, pitsm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    [return: NativeTypeName("BOOL")]
    public int OpenModW([NativeTypeName("const wchar_t *")] char* szModule, [NativeTypeName("const wchar_t *")] char* szFile, Mod** ppmod)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, char*, char*, Mod**, int>)(lpVtbl[37]))((DBI*)Unsafe.AsPointer(ref this), szModule, szFile, ppmod);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [return: NativeTypeName("BOOL")]
    public int DeleteModW([NativeTypeName("const wchar_t *")] char* szModule)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, char*, int>)(lpVtbl[38]))((DBI*)Unsafe.AsPointer(ref this), szModule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [return: NativeTypeName("BOOL")]
    public int AddPublicW([NativeTypeName("const wchar_t *")] char* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, char*, ushort, int, uint, int>)(lpVtbl[39]))((DBI*)Unsafe.AsPointer(ref this), szPublic, isect, off, cvpsf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    [return: NativeTypeName("BOOL")]
    public int QueryTypeServerByPdbW([NativeTypeName("const wchar_t *")] char* szPdb, [NativeTypeName("ITSM *")] byte* pitsm)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, char*, byte*, int>)(lpVtbl[40]))((DBI*)Unsafe.AsPointer(ref this), szPdb, pitsm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    [return: NativeTypeName("BOOL")]
    public int AddLinkInfoW([NativeTypeName("PLinkInfoW")] LinkInfoW* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, LinkInfoW*, int>)(lpVtbl[41]))((DBI*)Unsafe.AsPointer(ref this), param0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    [return: NativeTypeName("BOOL")]
    public int AddPublic2([NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, sbyte*, ushort, int, uint, int>)(lpVtbl[42]))((DBI*)Unsafe.AsPointer(ref this), szPublic, isect, off, cvpsf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public ushort QueryMachineType()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort>)(lpVtbl[43]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void SetMachineType(ushort wMachine)
    {
        ((delegate* unmanaged[MemberFunction]<DBI*, ushort, void>)(lpVtbl[44]))((DBI*)Unsafe.AsPointer(ref this), wMachine);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void RemoveDataForRva([NativeTypeName("ULONG")] uint rva, [NativeTypeName("ULONG")] uint cb)
    {
        ((delegate* unmanaged[MemberFunction]<DBI*, uint, uint, void>)(lpVtbl[45]))((DBI*)Unsafe.AsPointer(ref this), rva, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    [return: NativeTypeName("BOOL")]
    public int FStripped()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int>)(lpVtbl[46]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    [return: NativeTypeName("BOOL")]
    public int QueryModFromAddr2(ushort isect, [NativeTypeName("long")] int off, Mod** ppmod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort, int, Mod**, ushort*, int*, int*, uint*, int>)(lpVtbl[47]))((DBI*)Unsafe.AsPointer(ref this), isect, off, ppmod, pisect, poff, pcb, pdwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    [return: NativeTypeName("BOOL")]
    public int QueryNoOfMods([NativeTypeName("long *")] int* cMods)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int*, int>)(lpVtbl[48]))((DBI*)Unsafe.AsPointer(ref this), cMods);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    [return: NativeTypeName("BOOL")]
    public int QueryMods(Mod** ppmodNext, [NativeTypeName("long")] int cMods)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, Mod**, int, int>)(lpVtbl[49]))((DBI*)Unsafe.AsPointer(ref this), ppmodNext, cMods);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    [return: NativeTypeName("BOOL")]
    public int QueryImodFromAddr(ushort isect, [NativeTypeName("long")] int off, ushort* pimod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort, int, ushort*, ushort*, int*, int*, uint*, int>)(lpVtbl[50]))((DBI*)Unsafe.AsPointer(ref this), isect, off, pimod, pisect, poff, pcb, pdwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    [return: NativeTypeName("BOOL")]
    public int OpenModFromImod(ushort imod, Mod** ppmod)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort, Mod**, int>)(lpVtbl[51]))((DBI*)Unsafe.AsPointer(ref this), imod, ppmod);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    [return: NativeTypeName("BOOL")]
    public int QueryHeader2([NativeTypeName("long")] int cb, byte* pb, [NativeTypeName("long *")] int* pcbOut)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int, byte*, int*, int>)(lpVtbl[52]))((DBI*)Unsafe.AsPointer(ref this), cb, pb, pcbOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    [return: NativeTypeName("BOOL")]
    public int FAddSourceMappingItem([NativeTypeName("const wchar_t *")] char* szMapTo, [NativeTypeName("const wchar_t *")] char* szMapFrom, [NativeTypeName("ULONG")] uint grFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, char*, char*, uint, int>)(lpVtbl[53]))((DBI*)Unsafe.AsPointer(ref this), szMapTo, szMapFrom, grFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    [return: NativeTypeName("BOOL")]
    public int FSetPfnNotePdbUsed(void* pvContext, [NativeTypeName("DBI::PFNNOTEPDBUSED")] delegate* unmanaged[Cdecl]<void*, char*, int, int, void> param1)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, void*, delegate* unmanaged[Cdecl]<void*, char*, int, int, void>, int>)(lpVtbl[54]))((DBI*)Unsafe.AsPointer(ref this), pvContext, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    [return: NativeTypeName("BOOL")]
    public int FCTypes()
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, int>)(lpVtbl[55]))((DBI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    [return: NativeTypeName("BOOL")]
    public int QueryFileInfo2(byte* pb, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, byte*, int*, int>)(lpVtbl[56]))((DBI*)Unsafe.AsPointer(ref this), pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    [return: NativeTypeName("BOOL")]
    public int FSetPfnQueryCallback(void* pvContext, [NativeTypeName("PFNDBIQUERYCALLBACK")] delegate* unmanaged[Cdecl]<void*, DOVC, delegate* unmanaged[Cdecl]<int>> param1)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, void*, delegate* unmanaged[Cdecl]<void*, DOVC, delegate* unmanaged[Cdecl]<int>>, int>)(lpVtbl[57]))((DBI*)Unsafe.AsPointer(ref this), pvContext, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    [return: NativeTypeName("BOOL")]
    public int FSetPfnNoteTypeMismatch(void* pvContext, [NativeTypeName("DBI::PFNNOTETYPEMISMATCH")] delegate* unmanaged[Cdecl]<void*, char*, char*, void> param1)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, void*, delegate* unmanaged[Cdecl]<void*, char*, char*, void>, int>)(lpVtbl[58]))((DBI*)Unsafe.AsPointer(ref this), pvContext, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    [return: NativeTypeName("BOOL")]
    public int FSetPfnTmdTypeFilter(void* pvContext, [NativeTypeName("DBI::PFNTMDTYPEFILTER")] delegate* unmanaged[Cdecl]<void*, char*, int> param1)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, void*, delegate* unmanaged[Cdecl]<void*, char*, int>, int>)(lpVtbl[59]))((DBI*)Unsafe.AsPointer(ref this), pvContext, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    [return: NativeTypeName("BOOL")]
    public int RemovePublic([NativeTypeName("const char *")] sbyte* szPublic)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, sbyte*, int>)(lpVtbl[60]))((DBI*)Unsafe.AsPointer(ref this), szPublic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    [return: NativeTypeName("BOOL")]
    public int getEnumContrib2(Enum** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, Enum**, int>)(lpVtbl[61]))((DBI*)Unsafe.AsPointer(ref this), ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    [return: NativeTypeName("BOOL")]
    public int QueryModFromAddrEx(ushort isect, [NativeTypeName("ULONG")] uint off, Mod** ppmod, ushort* pisect, [NativeTypeName("ULONG *")] uint* pisectCoff, [NativeTypeName("ULONG *")] uint* poff, [NativeTypeName("ULONG *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort, uint, Mod**, ushort*, uint*, uint*, uint*, uint*, int>)(lpVtbl[62]))((DBI*)Unsafe.AsPointer(ref this), isect, off, ppmod, pisect, pisectCoff, poff, pcb, pdwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    [return: NativeTypeName("BOOL")]
    public int QueryImodFromAddrEx(ushort isect, [NativeTypeName("ULONG")] uint off, ushort* pimod, ushort* pisect, [NativeTypeName("ULONG *")] uint* pisectCoff, [NativeTypeName("ULONG *")] uint* poff, [NativeTypeName("ULONG *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<DBI*, ushort, uint, ushort*, ushort*, uint*, uint*, uint*, uint*, int>)(lpVtbl[63]))((DBI*)Unsafe.AsPointer(ref this), isect, off, pimod, pisect, pisectCoff, poff, pcb, pdwCharacteristics);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("IMPV")]
        uint QueryImplementationVersion();

        [VtblIndex(1)]
        [return: NativeTypeName("INTV")]
        uint QueryInterfaceVersion();

        [VtblIndex(2)]
        [return: NativeTypeName("BOOL")]
        int OpenMod([NativeTypeName("const char *")] sbyte* szModule, [NativeTypeName("const char *")] sbyte* szFile, Mod** ppmod);

        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        int DeleteMod([NativeTypeName("const char *")] sbyte* szModule);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int QueryNextMod(Mod* pmod, Mod** ppmodNext);

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int OpenGlobals(GSI** ppgsi);

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int OpenPublics(GSI** ppgsi);

        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        int AddSec(ushort isect, ushort flags, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb);

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int QueryModFromAddr(ushort isect, [NativeTypeName("long")] int off, Mod** ppmod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(9)]
        [return: NativeTypeName("BOOL")]
        int QuerySecMap(byte* pb, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(10)]
        [return: NativeTypeName("BOOL")]
        int QueryFileInfo(byte* pb, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(11)]
        void DumpMods();

        [VtblIndex(12)]
        void DumpSecContribs();

        [VtblIndex(13)]
        void DumpSecMap();

        [VtblIndex(14)]
        [return: NativeTypeName("BOOL")]
        int Close();

        [VtblIndex(15)]
        [return: NativeTypeName("BOOL")]
        int AddThunkMap([NativeTypeName("long *")] int* poffThunkMap, [NativeTypeName("unsigned int")] uint nThunks, [NativeTypeName("long")] int cbSizeOfThunk, [NativeTypeName("struct SO *")] SO* psoSectMap, [NativeTypeName("unsigned int")] uint nSects, ushort isectThunkTable, [NativeTypeName("long")] int offThunkTable);

        [VtblIndex(16)]
        [return: NativeTypeName("BOOL")]
        int AddPublic([NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off);

        [VtblIndex(17)]
        [return: NativeTypeName("BOOL")]
        int getEnumContrib(Enum** ppenum);

        [VtblIndex(18)]
        [return: NativeTypeName("BOOL")]
        int QueryTypeServer([NativeTypeName("ITSM")] byte itsm, TPI** pptpi);

        [VtblIndex(19)]
        [return: NativeTypeName("BOOL")]
        int QueryItsmForTi([NativeTypeName("TI")] uint ti, [NativeTypeName("ITSM *")] byte* pitsm);

        [VtblIndex(20)]
        [return: NativeTypeName("BOOL")]
        int QueryNextItsm([NativeTypeName("ITSM")] byte itsm, [NativeTypeName("ITSM *")] byte* inext);

        [VtblIndex(21)]
        [return: NativeTypeName("BOOL")]
        int QueryLazyTypes();

        [VtblIndex(22)]
        [return: NativeTypeName("BOOL")]
        int SetLazyTypes([NativeTypeName("BOOL")] int fLazy);

        [VtblIndex(23)]
        [return: NativeTypeName("BOOL")]
        int FindTypeServers([NativeTypeName("EC *")] int* pec, [NativeTypeName("char[1024]")] sbyte* szError);

        [VtblIndex(24)]
        void DumpTypeServers();

        [VtblIndex(25)]
        [return: NativeTypeName("BOOL")]
        int OpenDbg(DBGTYPE dbgtype, Dbg** ppdbg);

        [VtblIndex(26)]
        [return: NativeTypeName("BOOL")]
        int QueryDbgTypes(DBGTYPE* pdbgtype, [NativeTypeName("long *")] int* pcDbgtype);

        [VtblIndex(27)]
        [return: NativeTypeName("BOOL")]
        int QueryAddrForSec(ushort* pisect, [NativeTypeName("long *")] int* poff, ushort imod, [NativeTypeName("long")] int cb, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc);

        [VtblIndex(28)]
        [return: NativeTypeName("BOOL")]
        int QueryAddrForSecEx(ushort* pisect, [NativeTypeName("long *")] int* poff, ushort imod, [NativeTypeName("long")] int cb, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc, [NativeTypeName("DWORD")] uint dwCharacteristics);

        [VtblIndex(29)]
        [return: NativeTypeName("BOOL")]
        int QuerySupportsEC();

        [VtblIndex(30)]
        [return: NativeTypeName("BOOL")]
        int QueryPdb(PDB** pppdb);

        [VtblIndex(31)]
        [return: NativeTypeName("BOOL")]
        int AddLinkInfo([NativeTypeName("PLinkInfo")] LinkInfo* param0);

        [VtblIndex(32)]
        [return: NativeTypeName("BOOL")]
        int QueryLinkInfo([NativeTypeName("PLinkInfo")] LinkInfo* param0, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(33)]
        [return: NativeTypeName("AGE")]
        uint QueryAge();

        [VtblIndex(34)]
        void* QueryHeader();

        [VtblIndex(35)]
        void FlushTypeServers();

        [VtblIndex(36)]
        [return: NativeTypeName("BOOL")]
        int QueryTypeServerByPdb([NativeTypeName("const char *")] sbyte* szPdb, [NativeTypeName("ITSM *")] byte* pitsm);

        [VtblIndex(37)]
        [return: NativeTypeName("BOOL")]
        int OpenModW([NativeTypeName("const wchar_t *")] char* szModule, [NativeTypeName("const wchar_t *")] char* szFile, Mod** ppmod);

        [VtblIndex(38)]
        [return: NativeTypeName("BOOL")]
        int DeleteModW([NativeTypeName("const wchar_t *")] char* szModule);

        [VtblIndex(39)]
        [return: NativeTypeName("BOOL")]
        int AddPublicW([NativeTypeName("const wchar_t *")] char* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0);

        [VtblIndex(40)]
        [return: NativeTypeName("BOOL")]
        int QueryTypeServerByPdbW([NativeTypeName("const wchar_t *")] char* szPdb, [NativeTypeName("ITSM *")] byte* pitsm);

        [VtblIndex(41)]
        [return: NativeTypeName("BOOL")]
        int AddLinkInfoW([NativeTypeName("PLinkInfoW")] LinkInfoW* param0);

        [VtblIndex(42)]
        [return: NativeTypeName("BOOL")]
        int AddPublic2([NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0);

        [VtblIndex(43)]
        ushort QueryMachineType();

        [VtblIndex(44)]
        void SetMachineType(ushort wMachine);

        [VtblIndex(45)]
        void RemoveDataForRva([NativeTypeName("ULONG")] uint rva, [NativeTypeName("ULONG")] uint cb);

        [VtblIndex(46)]
        [return: NativeTypeName("BOOL")]
        int FStripped();

        [VtblIndex(47)]
        [return: NativeTypeName("BOOL")]
        int QueryModFromAddr2(ushort isect, [NativeTypeName("long")] int off, Mod** ppmod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

        [VtblIndex(48)]
        [return: NativeTypeName("BOOL")]
        int QueryNoOfMods([NativeTypeName("long *")] int* cMods);

        [VtblIndex(49)]
        [return: NativeTypeName("BOOL")]
        int QueryMods(Mod** ppmodNext, [NativeTypeName("long")] int cMods);

        [VtblIndex(50)]
        [return: NativeTypeName("BOOL")]
        int QueryImodFromAddr(ushort isect, [NativeTypeName("long")] int off, ushort* pimod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

        [VtblIndex(51)]
        [return: NativeTypeName("BOOL")]
        int OpenModFromImod(ushort imod, Mod** ppmod);

        [VtblIndex(52)]
        [return: NativeTypeName("BOOL")]
        int QueryHeader2([NativeTypeName("long")] int cb, byte* pb, [NativeTypeName("long *")] int* pcbOut);

        [VtblIndex(53)]
        [return: NativeTypeName("BOOL")]
        int FAddSourceMappingItem([NativeTypeName("const wchar_t *")] char* szMapTo, [NativeTypeName("const wchar_t *")] char* szMapFrom, [NativeTypeName("ULONG")] uint grFlags);

        [VtblIndex(55)]
        [return: NativeTypeName("BOOL")]
        int FCTypes();

        [VtblIndex(56)]
        [return: NativeTypeName("BOOL")]
        int QueryFileInfo2(byte* pb, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(60)]
        [return: NativeTypeName("BOOL")]
        int RemovePublic([NativeTypeName("const char *")] sbyte* szPublic);

        [VtblIndex(61)]
        [return: NativeTypeName("BOOL")]
        int getEnumContrib2(Enum** ppenum);

        [VtblIndex(62)]
        [return: NativeTypeName("BOOL")]
        int QueryModFromAddrEx(ushort isect, [NativeTypeName("ULONG")] uint off, Mod** ppmod, ushort* pisect, [NativeTypeName("ULONG *")] uint* pisectCoff, [NativeTypeName("ULONG *")] uint* poff, [NativeTypeName("ULONG *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

        [VtblIndex(63)]
        [return: NativeTypeName("BOOL")]
        int QueryImodFromAddrEx(ushort isect, [NativeTypeName("ULONG")] uint off, ushort* pimod, ushort* pisect, [NativeTypeName("ULONG *")] uint* pisectCoff, [NativeTypeName("ULONG *")] uint* poff, [NativeTypeName("ULONG *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IMPV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryImplementationVersion;

        [NativeTypeName("INTV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryInterfaceVersion;

        [NativeTypeName("BOOL (const char *, const char *, Mod **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, sbyte*, Mod**, int> OpenMod;

        [NativeTypeName("BOOL (const char *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> DeleteMod;

        [NativeTypeName("BOOL (Mod *, Mod **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Mod*, Mod**, int> QueryNextMod;

        [NativeTypeName("BOOL (GSI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GSI**, int> OpenGlobals;

        [NativeTypeName("BOOL (GSI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GSI**, int> OpenPublics;

        [NativeTypeName("BOOL (USHORT, USHORT, long, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, ushort, int, int, int> AddSec;

        [NativeTypeName("BOOL (USHORT, long, Mod **, USHORT *, long *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int, Mod**, ushort*, int*, int*, int> QueryModFromAddr;

        [NativeTypeName("BOOL (BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int*, int> QuerySecMap;

        [NativeTypeName("BOOL (BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int*, int> QueryFileInfo;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DumpMods;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DumpSecContribs;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DumpSecMap;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("BOOL (long *, unsigned int, long, struct SO *, unsigned int, USHORT, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, uint, int, SO*, uint, ushort, int, int> AddThunkMap;

        [NativeTypeName("BOOL (const char *, USHORT, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, ushort, int, int> AddPublic;

        [NativeTypeName("BOOL (Enum **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Enum**, int> getEnumContrib;

        [NativeTypeName("BOOL (ITSM, TPI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, TPI**, int> QueryTypeServer;

        [NativeTypeName("BOOL (TI, ITSM *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> QueryItsmForTi;

        [NativeTypeName("BOOL (ITSM, ITSM *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, byte*, int> QueryNextItsm;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> QueryLazyTypes;

        [NativeTypeName("BOOL (BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> SetLazyTypes;

        [NativeTypeName("BOOL (EC *, char *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, sbyte*, int> FindTypeServers;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DumpTypeServers;

        [NativeTypeName("BOOL (DBGTYPE, Dbg **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DBGTYPE, Dbg**, int> OpenDbg;

        [NativeTypeName("BOOL (DBGTYPE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DBGTYPE*, int*, int> QueryDbgTypes;

        [NativeTypeName("BOOL (USHORT *, long *, USHORT, long, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int*, ushort, int, uint, uint, int> QueryAddrForSec;

        [NativeTypeName("BOOL (USHORT *, long *, USHORT, long, DWORD, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int*, ushort, int, uint, uint, uint, int> QueryAddrForSecEx;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> QuerySupportsEC;

        [NativeTypeName("BOOL (PDB **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PDB**, int> QueryPdb;

        [NativeTypeName("BOOL (PLinkInfo)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LinkInfo*, int> AddLinkInfo;

        [NativeTypeName("BOOL (PLinkInfo, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LinkInfo*, int*, int> QueryLinkInfo;

        [NativeTypeName("AGE () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryAge;

        [NativeTypeName("void *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> QueryHeader;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> FlushTypeServers;

        [NativeTypeName("BOOL (const char *, ITSM *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, byte*, int> QueryTypeServerByPdb;

        [NativeTypeName("BOOL (const wchar_t *, const wchar_t *, Mod **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, Mod**, int> OpenModW;

        [NativeTypeName("BOOL (const wchar_t *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteModW;

        [NativeTypeName("BOOL (const wchar_t *, USHORT, long, CV_pubsymflag_t)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ushort, int, uint, int> AddPublicW;

        [NativeTypeName("BOOL (const wchar_t *, ITSM *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, byte*, int> QueryTypeServerByPdbW;

        [NativeTypeName("BOOL (PLinkInfoW)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LinkInfoW*, int> AddLinkInfoW;

        [NativeTypeName("BOOL (const char *, USHORT, long, CV_pubsymflag_t)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, ushort, int, uint, int> AddPublic2;

        [NativeTypeName("USHORT () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort> QueryMachineType;

        [NativeTypeName("void (USHORT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, void> SetMachineType;

        [NativeTypeName("void (ULONG, ULONG)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, void> RemoveDataForRva;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> FStripped;

        [NativeTypeName("BOOL (USHORT, long, Mod **, USHORT *, long *, long *, ULONG *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int, Mod**, ushort*, int*, int*, uint*, int> QueryModFromAddr2;

        [NativeTypeName("BOOL (long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> QueryNoOfMods;

        [NativeTypeName("BOOL (Mod **, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Mod**, int, int> QueryMods;

        [NativeTypeName("BOOL (USHORT, long, USHORT *, USHORT *, long *, long *, ULONG *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int, ushort*, ushort*, int*, int*, uint*, int> QueryImodFromAddr;

        [NativeTypeName("BOOL (USHORT, Mod **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, Mod**, int> OpenModFromImod;

        [NativeTypeName("BOOL (long, BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, byte*, int*, int> QueryHeader2;

        [NativeTypeName("BOOL (const wchar_t *, const wchar_t *, ULONG)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, int> FAddSourceMappingItem;

        [NativeTypeName("BOOL (void *, PFNNOTEPDBUSED)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, delegate* unmanaged[Cdecl]<void*, char*, int, int, void>, int> FSetPfnNotePdbUsed;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> FCTypes;

        [NativeTypeName("BOOL (BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int*, int> QueryFileInfo2;

        [NativeTypeName("BOOL (void *, PFNDBIQUERYCALLBACK)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, delegate* unmanaged[Cdecl]<void*, DOVC, delegate* unmanaged[Cdecl]<int>>, int> FSetPfnQueryCallback;

        [NativeTypeName("BOOL (void *, PFNNOTETYPEMISMATCH)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, delegate* unmanaged[Cdecl]<void*, char*, char*, void>, int> FSetPfnNoteTypeMismatch;

        [NativeTypeName("BOOL (void *, PFNTMDTYPEFILTER)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, delegate* unmanaged[Cdecl]<void*, char*, int>, int> FSetPfnTmdTypeFilter;

        [NativeTypeName("BOOL (const char *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> RemovePublic;

        [NativeTypeName("BOOL (Enum **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Enum**, int> getEnumContrib2;

        [NativeTypeName("BOOL (USHORT, ULONG, Mod **, USHORT *, ULONG *, ULONG *, ULONG *, ULONG *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, uint, Mod**, ushort*, uint*, uint*, uint*, uint*, int> QueryModFromAddrEx;

        [NativeTypeName("BOOL (USHORT, ULONG, USHORT *, USHORT *, ULONG *, ULONG *, ULONG *, ULONG *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, uint, ushort*, ushort*, uint*, uint*, uint*, uint*, int> QueryImodFromAddrEx;
    }
}
