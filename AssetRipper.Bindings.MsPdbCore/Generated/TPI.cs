using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct TPI : TPI.Interface
{
    public void** lpVtbl;

    public const int intv = (int)PDBINTV.PDBIntv;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("INTV")]
    public uint QueryInterfaceVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint>)(lpVtbl[0]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("IMPV")]
    public uint QueryImplementationVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint>)(lpVtbl[1]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int QueryTi16ForCVRecord(byte* pb, [NativeTypeName("TI16 *")] ushort* pti)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, byte*, ushort*, int>)(lpVtbl[2]))((TPI*)Unsafe.AsPointer(ref this), pb, pti);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public int QueryCVRecordForTi16([NativeTypeName("TI16")] ushort ti, byte* pb, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, ushort, byte*, int*, int>)(lpVtbl[3]))((TPI*)Unsafe.AsPointer(ref this), ti, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int QueryPbCVRecordForTi16([NativeTypeName("TI16")] ushort ti, byte** ppb)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, ushort, byte**, int>)(lpVtbl[4]))((TPI*)Unsafe.AsPointer(ref this), ti, ppb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("TI16")]
    public ushort QueryTi16Min()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, ushort>)(lpVtbl[5]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("TI16")]
    public ushort QueryTi16Mac()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, ushort>)(lpVtbl[6]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("long")]
    public int QueryCb()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, int>)(lpVtbl[7]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int Close()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, int>)(lpVtbl[8]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("BOOL")]
    public int Commit()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, int>)(lpVtbl[9]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("BOOL")]
    public int QueryTi16ForUDT([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI16 *")] ushort* pti)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, sbyte*, int, ushort*, int>)(lpVtbl[10]))((TPI*)Unsafe.AsPointer(ref this), sz, fCase, pti);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("BOOL")]
    public int SupportQueryTiForUDT()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, int>)(lpVtbl[11]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("BOOL")]
    public int fIs16bitTypePool()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, int>)(lpVtbl[12]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("BOOL")]
    public int QueryTiForUDT([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI *")] uint* pti)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, sbyte*, int, uint*, int>)(lpVtbl[13]))((TPI*)Unsafe.AsPointer(ref this), sz, fCase, pti);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("BOOL")]
    public int QueryTiForCVRecord(byte* pb, [NativeTypeName("TI *")] uint* pti)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, byte*, uint*, int>)(lpVtbl[14]))((TPI*)Unsafe.AsPointer(ref this), pb, pti);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("BOOL")]
    public int QueryCVRecordForTi([NativeTypeName("TI")] uint ti, byte* pb, [NativeTypeName("long *")] int* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint, byte*, int*, int>)(lpVtbl[15]))((TPI*)Unsafe.AsPointer(ref this), ti, pb, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("BOOL")]
    public int QueryPbCVRecordForTi([NativeTypeName("TI")] uint ti, byte** ppb)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint, byte**, int>)(lpVtbl[16]))((TPI*)Unsafe.AsPointer(ref this), ti, ppb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [return: NativeTypeName("TI")]
    public uint QueryTiMin()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint>)(lpVtbl[17]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("TI")]
    public uint QueryTiMac()
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint>)(lpVtbl[18]))((TPI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("BOOL")]
    public int AreTypesEqual([NativeTypeName("TI")] uint ti1, [NativeTypeName("TI")] uint ti2)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint, uint, int>)(lpVtbl[19]))((TPI*)Unsafe.AsPointer(ref this), ti1, ti2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("BOOL")]
    public int IsTypeServed([NativeTypeName("TI")] uint ti)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint, int>)(lpVtbl[20]))((TPI*)Unsafe.AsPointer(ref this), ti);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("BOOL")]
    public int QueryTiForUDTW([NativeTypeName("const wchar_t *")] char* wcs, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI *")] uint* pti)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, char*, int, uint*, int>)(lpVtbl[21]))((TPI*)Unsafe.AsPointer(ref this), wcs, fCase, pti);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("BOOL")]
    public int QueryModSrcLineForUDTDefn([NativeTypeName("const TI")] uint tiUdt, ushort* pimod, [NativeTypeName("NI *")] uint* psrcId, [NativeTypeName("DWORD *")] uint* pline)
    {
        return ((delegate* unmanaged[MemberFunction]<TPI*, uint, ushort*, uint*, uint*, int>)(lpVtbl[22]))((TPI*)Unsafe.AsPointer(ref this), tiUdt, pimod, psrcId, pline);
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
        int QueryTi16ForCVRecord(byte* pb, [NativeTypeName("TI16 *")] ushort* pti);

        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        int QueryCVRecordForTi16([NativeTypeName("TI16")] ushort ti, byte* pb, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int QueryPbCVRecordForTi16([NativeTypeName("TI16")] ushort ti, byte** ppb);

        [VtblIndex(5)]
        [return: NativeTypeName("TI16")]
        ushort QueryTi16Min();

        [VtblIndex(6)]
        [return: NativeTypeName("TI16")]
        ushort QueryTi16Mac();

        [VtblIndex(7)]
        [return: NativeTypeName("long")]
        int QueryCb();

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int Close();

        [VtblIndex(9)]
        [return: NativeTypeName("BOOL")]
        int Commit();

        [VtblIndex(10)]
        [return: NativeTypeName("BOOL")]
        int QueryTi16ForUDT([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI16 *")] ushort* pti);

        [VtblIndex(11)]
        [return: NativeTypeName("BOOL")]
        int SupportQueryTiForUDT();

        [VtblIndex(12)]
        [return: NativeTypeName("BOOL")]
        int fIs16bitTypePool();

        [VtblIndex(13)]
        [return: NativeTypeName("BOOL")]
        int QueryTiForUDT([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI *")] uint* pti);

        [VtblIndex(14)]
        [return: NativeTypeName("BOOL")]
        int QueryTiForCVRecord(byte* pb, [NativeTypeName("TI *")] uint* pti);

        [VtblIndex(15)]
        [return: NativeTypeName("BOOL")]
        int QueryCVRecordForTi([NativeTypeName("TI")] uint ti, byte* pb, [NativeTypeName("long *")] int* pcb);

        [VtblIndex(16)]
        [return: NativeTypeName("BOOL")]
        int QueryPbCVRecordForTi([NativeTypeName("TI")] uint ti, byte** ppb);

        [VtblIndex(17)]
        [return: NativeTypeName("TI")]
        uint QueryTiMin();

        [VtblIndex(18)]
        [return: NativeTypeName("TI")]
        uint QueryTiMac();

        [VtblIndex(19)]
        [return: NativeTypeName("BOOL")]
        int AreTypesEqual([NativeTypeName("TI")] uint ti1, [NativeTypeName("TI")] uint ti2);

        [VtblIndex(20)]
        [return: NativeTypeName("BOOL")]
        int IsTypeServed([NativeTypeName("TI")] uint ti);

        [VtblIndex(21)]
        [return: NativeTypeName("BOOL")]
        int QueryTiForUDTW([NativeTypeName("const wchar_t *")] char* wcs, [NativeTypeName("BOOL")] int fCase, [NativeTypeName("TI *")] uint* pti);

        [VtblIndex(22)]
        [return: NativeTypeName("BOOL")]
        int QueryModSrcLineForUDTDefn([NativeTypeName("const TI")] uint tiUdt, ushort* pimod, [NativeTypeName("NI *")] uint* psrcId, [NativeTypeName("DWORD *")] uint* pline);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("INTV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryInterfaceVersion;

        [NativeTypeName("IMPV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryImplementationVersion;

        [NativeTypeName("BOOL (BYTE *, TI16 *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, ushort*, int> QueryTi16ForCVRecord;

        [NativeTypeName("BOOL (TI16, BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, byte*, int*, int> QueryCVRecordForTi16;

        [NativeTypeName("BOOL (TI16, BYTE **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, byte**, int> QueryPbCVRecordForTi16;

        [NativeTypeName("TI16 ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort> QueryTi16Min;

        [NativeTypeName("TI16 ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort> QueryTi16Mac;

        [NativeTypeName("long ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> QueryCb;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Commit;

        [NativeTypeName("BOOL (const char *, BOOL, TI16 *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int, ushort*, int> QueryTi16ForUDT;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SupportQueryTiForUDT;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> fIs16bitTypePool;

        [NativeTypeName("BOOL (const char *, BOOL, TI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int, uint*, int> QueryTiForUDT;

        [NativeTypeName("BOOL (BYTE *, TI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint*, int> QueryTiForCVRecord;

        [NativeTypeName("BOOL (TI, BYTE *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int*, int> QueryCVRecordForTi;

        [NativeTypeName("BOOL (TI, BYTE **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte**, int> QueryPbCVRecordForTi;

        [NativeTypeName("TI ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryTiMin;

        [NativeTypeName("TI ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryTiMac;

        [NativeTypeName("BOOL (TI, TI)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> AreTypesEqual;

        [NativeTypeName("BOOL (TI)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> IsTypeServed;

        [NativeTypeName("BOOL (const wchar_t *, BOOL, TI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int, uint*, int> QueryTiForUDTW;

        [NativeTypeName("BOOL (const TI, USHORT *, NI *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ushort*, uint*, uint*, int> QueryModSrcLineForUDTDefn;
    }
}
