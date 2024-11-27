using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct Mod : Mod.Interface
{
    public void** lpVtbl;

    public const int intv = (int)PDBINTV.PDBIntv;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("INTV")]
    public uint QueryInterfaceVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint>)(lpVtbl[0]))((Mod*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("IMPV")]
    public uint QueryImplementationVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint>)(lpVtbl[1]))((Mod*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int AddTypes(byte* pbTypes, [NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, int, int>)(lpVtbl[2]))((Mod*)Unsafe.AsPointer(ref this), pbTypes, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public int AddSymbols(byte* pbSym, [NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, int, int>)(lpVtbl[3]))((Mod*)Unsafe.AsPointer(ref this), pbSym, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int AddPublic([NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, sbyte*, ushort, int, int>)(lpVtbl[4]))((Mod*)Unsafe.AsPointer(ref this), szPublic, isect, off);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int AddLines([NativeTypeName("const char *")] sbyte* szSrc, ushort isect, [NativeTypeName("long")] int offCon, [NativeTypeName("long")] int cbCon, [NativeTypeName("long")] int doff, ushort lineStart, byte* pbCoff, [NativeTypeName("long")] int cbCoff)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, sbyte*, ushort, int, int, int, ushort, byte*, int, int>)(lpVtbl[5]))((Mod*)Unsafe.AsPointer(ref this), szSrc, isect, offCon, cbCon, doff, lineStart, pbCoff, cbCoff);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int AddSecContrib(ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, [NativeTypeName("ULONG")] uint dwCharacteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, ushort, int, int, uint, int>)(lpVtbl[6]))((Mod*)Unsafe.AsPointer(ref this), isect, off, cb, dwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("BOOL")]
    public int QueryCBName([NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, int*, int>)(lpVtbl[7]))((Mod*)Unsafe.AsPointer(ref this), pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int QueryName([NativeTypeName("char[260]")] sbyte* szName, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, sbyte*, int*, int>)(lpVtbl[8]))((Mod*)Unsafe.AsPointer(ref this), szName, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("BOOL")]
    public int QuerySymbols(byte* pbSym, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, int*, int>)(lpVtbl[9]))((Mod*)Unsafe.AsPointer(ref this), pbSym, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("BOOL")]
    public int QueryLines(byte* pbLines, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, int*, int>)(lpVtbl[10]))((Mod*)Unsafe.AsPointer(ref this), pbLines, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("BOOL")]
    public int SetPvClient(void* pvClient)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, void*, int>)(lpVtbl[11]))((Mod*)Unsafe.AsPointer(ref this), pvClient);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("BOOL")]
    public int GetPvClient(void** ppvClient)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, void**, int>)(lpVtbl[12]))((Mod*)Unsafe.AsPointer(ref this), ppvClient);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("BOOL")]
    public int QueryFirstCodeSecContrib(ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, ushort*, int*, int*, uint*, int>)(lpVtbl[13]))((Mod*)Unsafe.AsPointer(ref this), pisect, poff, pcb, pdwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("BOOL")]
    public int QueryImod(ushort* pimod)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, ushort*, int>)(lpVtbl[14]))((Mod*)Unsafe.AsPointer(ref this), pimod);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("BOOL")]
    public int QueryDBI(DBI** ppdbi)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, DBI**, int>)(lpVtbl[15]))((Mod*)Unsafe.AsPointer(ref this), ppdbi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("BOOL")]
    public int Close()
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, int>)(lpVtbl[16]))((Mod*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [return: NativeTypeName("BOOL")]
    public int QueryCBFile([NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, int*, int>)(lpVtbl[17]))((Mod*)Unsafe.AsPointer(ref this), pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("BOOL")]
    public int QueryFile([NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, sbyte*, int*, int>)(lpVtbl[18]))((Mod*)Unsafe.AsPointer(ref this), szFile, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("BOOL")]
    public int QueryTpi(TPI** pptpi)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, TPI**, int>)(lpVtbl[19]))((Mod*)Unsafe.AsPointer(ref this), pptpi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("BOOL")]
    public int AddSecContribEx(ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, [NativeTypeName("ULONG")] uint dwCharacteristics, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, ushort, int, int, uint, uint, uint, int>)(lpVtbl[20]))((Mod*)Unsafe.AsPointer(ref this), isect, off, cb, dwCharacteristics, dwDataCrc, dwRelocCrc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("BOOL")]
    public int QueryItsm(ushort* pitsm)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, ushort*, int>)(lpVtbl[21]))((Mod*)Unsafe.AsPointer(ref this), pitsm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("BOOL")]
    public int QuerySrcFile([NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, sbyte*, int*, int>)(lpVtbl[22]))((Mod*)Unsafe.AsPointer(ref this), szFile, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("BOOL")]
    public int QuerySupportsEC()
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, int>)(lpVtbl[23]))((Mod*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [return: NativeTypeName("BOOL")]
    public int QueryPdbFile([NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, sbyte*, int*, int>)(lpVtbl[24]))((Mod*)Unsafe.AsPointer(ref this), szFile, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [return: NativeTypeName("BOOL")]
    public int ReplaceLines(byte* pbLines, [NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, int, int>)(lpVtbl[25]))((Mod*)Unsafe.AsPointer(ref this), pbLines, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public bool GetEnumLines(EnumLines** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, EnumLines**, bool>)(lpVtbl[26]))((Mod*)Unsafe.AsPointer(ref this), ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public bool QueryLineFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint*, bool>)(lpVtbl[27]))((Mod*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public bool QueryFileNameInfo([NativeTypeName("DWORD")] uint fileId, [NativeTypeName("wchar_t *")] char* szFilename, [NativeTypeName("DWORD *")] uint* pccFilename, [NativeTypeName("DWORD *")] uint* pChksumType, byte* pbChksum, [NativeTypeName("DWORD *")] uint* pcbChksum)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, char*, uint*, uint*, byte*, uint*, bool>)(lpVtbl[28]))((Mod*)Unsafe.AsPointer(ref this), fileId, szFilename, pccFilename, pChksumType, pbChksum, pcbChksum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [return: NativeTypeName("BOOL")]
    public int AddPublicW([NativeTypeName("const wchar_t *")] char* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, char*, ushort, int, uint, int>)(lpVtbl[29]))((Mod*)Unsafe.AsPointer(ref this), szPublic, isect, off, cvpsf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [return: NativeTypeName("BOOL")]
    public int AddLinesW([NativeTypeName("const wchar_t *")] char* szSrc, ushort isect, [NativeTypeName("long")] int offCon, [NativeTypeName("long")] int cbCon, [NativeTypeName("long")] int doff, [NativeTypeName("ULONG")] uint lineStart, byte* pbCoff, [NativeTypeName("long")] int cbCoff)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, char*, ushort, int, int, int, uint, byte*, int, int>)(lpVtbl[30]))((Mod*)Unsafe.AsPointer(ref this), szSrc, isect, offCon, cbCon, doff, lineStart, pbCoff, cbCoff);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("BOOL")]
    public int QueryNameW([NativeTypeName("wchar_t[260]")] char* szName, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, char*, int*, int>)(lpVtbl[31]))((Mod*)Unsafe.AsPointer(ref this), szName, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("BOOL")]
    public int QueryFileW([NativeTypeName("wchar_t[260]")] char* szFile, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, char*, int*, int>)(lpVtbl[32]))((Mod*)Unsafe.AsPointer(ref this), szFile, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [return: NativeTypeName("BOOL")]
    public int QuerySrcFileW([NativeTypeName("wchar_t[260]")] char* szFile, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, char*, int*, int>)(lpVtbl[33]))((Mod*)Unsafe.AsPointer(ref this), szFile, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [return: NativeTypeName("BOOL")]
    public int QueryPdbFileW([NativeTypeName("wchar_t[260]")] char* szFile, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, char*, int*, int>)(lpVtbl[34]))((Mod*)Unsafe.AsPointer(ref this), szFile, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [return: NativeTypeName("BOOL")]
    public int AddPublic2([NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, sbyte*, ushort, int, uint, int>)(lpVtbl[35]))((Mod*)Unsafe.AsPointer(ref this), szPublic, isect, off, cvpsf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [return: NativeTypeName("BOOL")]
    public int InsertLines(byte* pbLines, [NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, int, int>)(lpVtbl[36]))((Mod*)Unsafe.AsPointer(ref this), pbLines, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    [return: NativeTypeName("BOOL")]
    public int QueryLines2([NativeTypeName("long")] int cbLines, byte* pbLines, [NativeTypeName("long *")] int* pcbLines)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, int, byte*, int*, int>)(lpVtbl[37]))((Mod*)Unsafe.AsPointer(ref this), cbLines, pbLines, pcbLines);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [return: NativeTypeName("BOOL")]
    public int QueryCrossScopeExports([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, byte*, uint*, int>)(lpVtbl[38]))((Mod*)Unsafe.AsPointer(ref this), cb, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [return: NativeTypeName("BOOL")]
    public int QueryCrossScopeImports([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, byte*, uint*, int>)(lpVtbl[39]))((Mod*)Unsafe.AsPointer(ref this), cb, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    [return: NativeTypeName("BOOL")]
    public int QueryInlineeLines([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, byte*, uint*, int>)(lpVtbl[40]))((Mod*)Unsafe.AsPointer(ref this), cb, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    [return: NativeTypeName("BOOL")]
    public int TranslateFileId([NativeTypeName("DWORD")] uint id, [NativeTypeName("DWORD *")] uint* pid)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, uint*, int>)(lpVtbl[41]))((Mod*)Unsafe.AsPointer(ref this), id, pid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    [return: NativeTypeName("BOOL")]
    public int QueryFuncMDTokenMap([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, byte*, uint*, int>)(lpVtbl[42]))((Mod*)Unsafe.AsPointer(ref this), cb, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    [return: NativeTypeName("BOOL")]
    public int QueryTypeMDTokenMap([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, byte*, uint*, int>)(lpVtbl[43]))((Mod*)Unsafe.AsPointer(ref this), cb, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    [return: NativeTypeName("BOOL")]
    public int QueryMergedAssemblyInput([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, byte*, uint*, int>)(lpVtbl[44]))((Mod*)Unsafe.AsPointer(ref this), cb, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    [return: NativeTypeName("BOOL")]
    public int QueryILLines([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, byte*, uint*, int>)(lpVtbl[45]))((Mod*)Unsafe.AsPointer(ref this), cb, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public bool GetEnumILLines(EnumLines** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, EnumLines**, bool>)(lpVtbl[46]))((Mod*)Unsafe.AsPointer(ref this), ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public bool QueryILLineFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint*, bool>)(lpVtbl[47]))((Mod*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    [return: NativeTypeName("BOOL")]
    public int MergeTypes(byte* pb, [NativeTypeName("DWORD")] uint cb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, uint, int>)(lpVtbl[48]))((Mod*)Unsafe.AsPointer(ref this), pb, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    [return: NativeTypeName("BOOL")]
    public int IsTypeServed([NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, int, int>)(lpVtbl[49]))((Mod*)Unsafe.AsPointer(ref this), index, fID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    [return: NativeTypeName("BOOL")]
    public int QueryTypes(byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, uint*, int>)(lpVtbl[50]))((Mod*)Unsafe.AsPointer(ref this), pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    [return: NativeTypeName("BOOL")]
    public int QueryIDs(byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, uint*, int>)(lpVtbl[51]))((Mod*)Unsafe.AsPointer(ref this), pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    [return: NativeTypeName("BOOL")]
    public int QueryCVRecordForTi([NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID, byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, int, byte*, uint*, int>)(lpVtbl[52]))((Mod*)Unsafe.AsPointer(ref this), index, fID, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    [return: NativeTypeName("BOOL")]
    public int QueryPbCVRecordForTi([NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID, byte** ppb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, int, byte**, int>)(lpVtbl[53]))((Mod*)Unsafe.AsPointer(ref this), index, fID, ppb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    [return: NativeTypeName("BOOL")]
    public int QueryTiForUDT([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI *")] uint* pti)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, sbyte*, int, uint*, int>)(lpVtbl[54]))((Mod*)Unsafe.AsPointer(ref this), sz, fCase, pti);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    [return: NativeTypeName("BOOL")]
    public int QueryCoffSymRVAs(byte* pb, [NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, uint*, int>)(lpVtbl[55]))((Mod*)Unsafe.AsPointer(ref this), pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    [return: NativeTypeName("BOOL")]
    public int AddSecContrib2(ushort isect, [NativeTypeName("DWORD")] uint off, [NativeTypeName("DWORD")] uint isectCoff, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint dwCharacteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, ushort, uint, uint, uint, uint, int>)(lpVtbl[56]))((Mod*)Unsafe.AsPointer(ref this), isect, off, isectCoff, cb, dwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    [return: NativeTypeName("BOOL")]
    public int AddSecContrib2Ex(ushort isect, [NativeTypeName("DWORD")] uint off, [NativeTypeName("DWORD")] uint isecfCoff, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint dwCharacteristics, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, ushort, uint, uint, uint, uint, uint, uint, int>)(lpVtbl[57]))((Mod*)Unsafe.AsPointer(ref this), isect, off, isecfCoff, cb, dwCharacteristics, dwDataCrc, dwRelocCrc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    [return: NativeTypeName("BOOL")]
    public int AddSymbols2(byte* pbSym, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint isectCoff)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, byte*, uint, uint, int>)(lpVtbl[58]))((Mod*)Unsafe.AsPointer(ref this), pbSym, cb, isectCoff);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    [return: NativeTypeName("BOOL")]
    public int RemoveGlobalRefs()
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, int>)(lpVtbl[59]))((Mod*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    [return: NativeTypeName("BOOL")]
    public int QuerySrcLineForUDT([NativeTypeName("TI")] uint ti, [NativeTypeName("char **")] sbyte** pszSrc, [NativeTypeName("DWORD *")] uint* pLine)
    {
        return ((delegate* unmanaged[MemberFunction]<Mod*, uint, sbyte**, uint*, int>)(lpVtbl[60]))((Mod*)Unsafe.AsPointer(ref this), ti, pszSrc, pLine);
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
        [return: NativeTypeName("BOOL")]
        int AddTypes(byte* pbTypes, [NativeTypeName("long")] int cb);

        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        int AddSymbols(byte* pbSym, [NativeTypeName("long")] int cb);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int AddPublic([NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off);

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int AddLines([NativeTypeName("const char *")] sbyte* szSrc, ushort isect, [NativeTypeName("long")] int offCon, [NativeTypeName("long")] int cbCon, [NativeTypeName("long")] int doff, ushort lineStart, byte* pbCoff, [NativeTypeName("long")] int cbCoff);

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int AddSecContrib(ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, [NativeTypeName("ULONG")] uint dwCharacteristics);

        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        int QueryCBName([NativeTypeName("long *")] int* pcb);

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int QueryName([NativeTypeName("char[260]")] sbyte* szName, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(9)]
        [return: NativeTypeName("BOOL")]
        int QuerySymbols(byte* pbSym, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(10)]
        [return: NativeTypeName("BOOL")]
        int QueryLines(byte* pbLines, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(11)]
        [return: NativeTypeName("BOOL")]
        int SetPvClient(void* pvClient);

        [VtblIndex(12)]
        [return: NativeTypeName("BOOL")]
        int GetPvClient(void** ppvClient);

        [VtblIndex(13)]
        [return: NativeTypeName("BOOL")]
        int QueryFirstCodeSecContrib(ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

        [VtblIndex(14)]
        [return: NativeTypeName("BOOL")]
        int QueryImod(ushort* pimod);

        [VtblIndex(15)]
        [return: NativeTypeName("BOOL")]
        int QueryDBI(DBI** ppdbi);

        [VtblIndex(16)]
        [return: NativeTypeName("BOOL")]
        int Close();

        [VtblIndex(17)]
        [return: NativeTypeName("BOOL")]
        int QueryCBFile([NativeTypeName("long *")] int* pcb);

        [VtblIndex(18)]
        [return: NativeTypeName("BOOL")]
        int QueryFile([NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(19)]
        [return: NativeTypeName("BOOL")]
        int QueryTpi(TPI** pptpi);

        [VtblIndex(20)]
        [return: NativeTypeName("BOOL")]
        int AddSecContribEx(ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, [NativeTypeName("ULONG")] uint dwCharacteristics, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc);

        [VtblIndex(21)]
        [return: NativeTypeName("BOOL")]
        int QueryItsm(ushort* pitsm);

        [VtblIndex(22)]
        [return: NativeTypeName("BOOL")]
        int QuerySrcFile([NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(23)]
        [return: NativeTypeName("BOOL")]
        int QuerySupportsEC();

        [VtblIndex(24)]
        [return: NativeTypeName("BOOL")]
        int QueryPdbFile([NativeTypeName("char[260]")] sbyte* szFile, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(25)]
        [return: NativeTypeName("BOOL")]
        int ReplaceLines(byte* pbLines, [NativeTypeName("long")] int cb);

        [VtblIndex(26)]
        bool GetEnumLines(EnumLines** ppenum);

        [VtblIndex(27)]
        bool QueryLineFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(28)]
        bool QueryFileNameInfo([NativeTypeName("DWORD")] uint fileId, [NativeTypeName("wchar_t *")] char* szFilename, [NativeTypeName("DWORD *")] uint* pccFilename, [NativeTypeName("DWORD *")] uint* pChksumType, byte* pbChksum, [NativeTypeName("DWORD *")] uint* pcbChksum);

        [VtblIndex(29)]
        [return: NativeTypeName("BOOL")]
        int AddPublicW([NativeTypeName("const wchar_t *")] char* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0);

        [VtblIndex(30)]
        [return: NativeTypeName("BOOL")]
        int AddLinesW([NativeTypeName("const wchar_t *")] char* szSrc, ushort isect, [NativeTypeName("long")] int offCon, [NativeTypeName("long")] int cbCon, [NativeTypeName("long")] int doff, [NativeTypeName("ULONG")] uint lineStart, byte* pbCoff, [NativeTypeName("long")] int cbCoff);

        [VtblIndex(31)]
        [return: NativeTypeName("BOOL")]
        int QueryNameW([NativeTypeName("wchar_t[260]")] char* szName, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(32)]
        [return: NativeTypeName("BOOL")]
        int QueryFileW([NativeTypeName("wchar_t[260]")] char* szFile, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(33)]
        [return: NativeTypeName("BOOL")]
        int QuerySrcFileW([NativeTypeName("wchar_t[260]")] char* szFile, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(34)]
        [return: NativeTypeName("BOOL")]
        int QueryPdbFileW([NativeTypeName("wchar_t[260]")] char* szFile, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(35)]
        [return: NativeTypeName("BOOL")]
        int AddPublic2([NativeTypeName("const char *")] sbyte* szPublic, ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("CV_pubsymflag_t")] uint cvpsf = 0);

        [VtblIndex(36)]
        [return: NativeTypeName("BOOL")]
        int InsertLines(byte* pbLines, [NativeTypeName("long")] int cb);

        [VtblIndex(37)]
        [return: NativeTypeName("BOOL")]
        int QueryLines2([NativeTypeName("long")] int cbLines, byte* pbLines, [NativeTypeName("long *")] int* pcbLines);

        [VtblIndex(38)]
        [return: NativeTypeName("BOOL")]
        int QueryCrossScopeExports([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(39)]
        [return: NativeTypeName("BOOL")]
        int QueryCrossScopeImports([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(40)]
        [return: NativeTypeName("BOOL")]
        int QueryInlineeLines([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(41)]
        [return: NativeTypeName("BOOL")]
        int TranslateFileId([NativeTypeName("DWORD")] uint id, [NativeTypeName("DWORD *")] uint* pid);

        [VtblIndex(42)]
        [return: NativeTypeName("BOOL")]
        int QueryFuncMDTokenMap([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(43)]
        [return: NativeTypeName("BOOL")]
        int QueryTypeMDTokenMap([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(44)]
        [return: NativeTypeName("BOOL")]
        int QueryMergedAssemblyInput([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(45)]
        [return: NativeTypeName("BOOL")]
        int QueryILLines([NativeTypeName("DWORD")] uint cb, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(46)]
        bool GetEnumILLines(EnumLines** ppenum);

        [VtblIndex(47)]
        bool QueryILLineFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(48)]
        [return: NativeTypeName("BOOL")]
        int MergeTypes(byte* pb, [NativeTypeName("DWORD")] uint cb);

        [VtblIndex(49)]
        [return: NativeTypeName("BOOL")]
        int IsTypeServed([NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID);

        [VtblIndex(50)]
        [return: NativeTypeName("BOOL")]
        int QueryTypes(byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(51)]
        [return: NativeTypeName("BOOL")]
        int QueryIDs(byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(52)]
        [return: NativeTypeName("BOOL")]
        int QueryCVRecordForTi([NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID, byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(53)]
        [return: NativeTypeName("BOOL")]
        int QueryPbCVRecordForTi([NativeTypeName("DWORD")] uint index, [NativeTypeName("BOOL")] int fID, byte** ppb);

        [VtblIndex(54)]
        [return: NativeTypeName("BOOL")]
        int QueryTiForUDT([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI *")] uint* pti);

        [VtblIndex(55)]
        [return: NativeTypeName("BOOL")]
        int QueryCoffSymRVAs(byte* pb, [NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(56)]
        [return: NativeTypeName("BOOL")]
        int AddSecContrib2(ushort isect, [NativeTypeName("DWORD")] uint off, [NativeTypeName("DWORD")] uint isectCoff, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint dwCharacteristics);

        [VtblIndex(57)]
        [return: NativeTypeName("BOOL")]
        int AddSecContrib2Ex(ushort isect, [NativeTypeName("DWORD")] uint off, [NativeTypeName("DWORD")] uint isecfCoff, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint dwCharacteristics, [NativeTypeName("DWORD")] uint dwDataCrc, [NativeTypeName("DWORD")] uint dwRelocCrc);

        [VtblIndex(58)]
        [return: NativeTypeName("BOOL")]
        int AddSymbols2(byte* pbSym, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD")] uint isectCoff);

        [VtblIndex(59)]
        [return: NativeTypeName("BOOL")]
        int RemoveGlobalRefs();

        [VtblIndex(60)]
        [return: NativeTypeName("BOOL")]
        int QuerySrcLineForUDT([NativeTypeName("TI")] uint ti, [NativeTypeName("char **")] sbyte** pszSrc, [NativeTypeName("DWORD *")] uint* pLine);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("INTV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryInterfaceVersion;

        [NativeTypeName("IMPV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryImplementationVersion;

        [NativeTypeName("BOOL (BYTE *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int, int> AddTypes;

        [NativeTypeName("BOOL (BYTE *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int, int> AddSymbols;

        [NativeTypeName("BOOL (const char *, USHORT, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, ushort, int, int> AddPublic;

        [NativeTypeName("BOOL (const char *, USHORT, long, long, long, USHORT, BYTE *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, ushort, int, int, int, ushort, byte*, int, int> AddLines;

        [NativeTypeName("BOOL (USHORT, long, long, ULONG)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int, int, uint, int> AddSecContrib;

        [NativeTypeName("BOOL (long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> QueryCBName;

        [NativeTypeName("BOOL (char *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int*, int> QueryName;

        [NativeTypeName("BOOL (BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int*, int> QuerySymbols;

        [NativeTypeName("BOOL (BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int*, int> QueryLines;

        [NativeTypeName("BOOL (void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int> SetPvClient;

        [NativeTypeName("BOOL (void **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, int> GetPvClient;

        [NativeTypeName("BOOL (USHORT *, long *, long *, ULONG *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int*, int*, uint*, int> QueryFirstCodeSecContrib;

        [NativeTypeName("BOOL (USHORT *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> QueryImod;

        [NativeTypeName("BOOL (DBI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DBI**, int> QueryDBI;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("BOOL (long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> QueryCBFile;

        [NativeTypeName("BOOL (char *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int*, int> QueryFile;

        [NativeTypeName("BOOL (TPI **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TPI**, int> QueryTpi;

        [NativeTypeName("BOOL (USHORT, long, long, ULONG, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int, int, uint, uint, uint, int> AddSecContribEx;

        [NativeTypeName("BOOL (USHORT *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> QueryItsm;

        [NativeTypeName("BOOL (char *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int*, int> QuerySrcFile;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> QuerySupportsEC;

        [NativeTypeName("BOOL (char *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int*, int> QueryPdbFile;

        [NativeTypeName("BOOL (BYTE *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int, int> ReplaceLines;

        [NativeTypeName("bool (EnumLines **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnumLines**, bool> GetEnumLines;

        [NativeTypeName("bool (DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, bool> QueryLineFlags;

        [NativeTypeName("bool (DWORD, wchar_t *, DWORD *, DWORD *, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, uint*, byte*, uint*, bool> QueryFileNameInfo;

        [NativeTypeName("BOOL (const wchar_t *, USHORT, long, CV_pubsymflag_t)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ushort, int, uint, int> AddPublicW;

        [NativeTypeName("BOOL (const wchar_t *, USHORT, long, long, long, ULONG, BYTE *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ushort, int, int, int, uint, byte*, int, int> AddLinesW;

        [NativeTypeName("BOOL (wchar_t *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> QueryNameW;

        [NativeTypeName("BOOL (wchar_t *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> QueryFileW;

        [NativeTypeName("BOOL (wchar_t *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> QuerySrcFileW;

        [NativeTypeName("BOOL (wchar_t *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> QueryPdbFileW;

        [NativeTypeName("BOOL (const char *, USHORT, long, CV_pubsymflag_t)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, ushort, int, uint, int> AddPublic2;

        [NativeTypeName("BOOL (BYTE *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int, int> InsertLines;

        [NativeTypeName("BOOL (long, BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, byte*, int*, int> QueryLines2;

        [NativeTypeName("BOOL (DWORD, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint*, int> QueryCrossScopeExports;

        [NativeTypeName("BOOL (DWORD, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint*, int> QueryCrossScopeImports;

        [NativeTypeName("BOOL (DWORD, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint*, int> QueryInlineeLines;

        [NativeTypeName("BOOL (DWORD, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, int> TranslateFileId;

        [NativeTypeName("BOOL (DWORD, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint*, int> QueryFuncMDTokenMap;

        [NativeTypeName("BOOL (DWORD, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint*, int> QueryTypeMDTokenMap;

        [NativeTypeName("BOOL (DWORD, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint*, int> QueryMergedAssemblyInput;

        [NativeTypeName("BOOL (DWORD, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint*, int> QueryILLines;

        [NativeTypeName("bool (EnumLines **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnumLines**, bool> GetEnumILLines;

        [NativeTypeName("bool (DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, bool> QueryILLineFlags;

        [NativeTypeName("BOOL (BYTE *, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, int> MergeTypes;

        [NativeTypeName("BOOL (DWORD, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int, int> IsTypeServed;

        [NativeTypeName("BOOL (BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint*, int> QueryTypes;

        [NativeTypeName("BOOL (BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint*, int> QueryIDs;

        [NativeTypeName("BOOL (DWORD, BOOL, BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int, byte*, uint*, int> QueryCVRecordForTi;

        [NativeTypeName("BOOL (DWORD, BOOL, BYTE **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int, byte**, int> QueryPbCVRecordForTi;

        [NativeTypeName("BOOL (const char *, BOOL, TI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int, uint*, int> QueryTiForUDT;

        [NativeTypeName("BOOL (BYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint*, int> QueryCoffSymRVAs;

        [NativeTypeName("BOOL (USHORT, DWORD, DWORD, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, uint, uint, uint, uint, int> AddSecContrib2;

        [NativeTypeName("BOOL (USHORT, DWORD, DWORD, DWORD, DWORD, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, uint, uint, uint, uint, uint, uint, int> AddSecContrib2Ex;

        [NativeTypeName("BOOL (BYTE *, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, uint, int> AddSymbols2;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveGlobalRefs;

        [NativeTypeName("BOOL (TI, char **, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, sbyte**, uint*, int> QuerySrcLineForUDT;
    }
}
