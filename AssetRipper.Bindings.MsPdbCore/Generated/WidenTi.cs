using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct WidenTi : WidenTi.Interface
{
    public void** lpVtbl;

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?fCreate@WidenTi@@SAHAEAPEAU1@IH@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int fCreate([NativeTypeName("WidenTi *&")] WidenTi** param0, [NativeTypeName("unsigned int")] uint cTypeInitialCache = 256, [NativeTypeName("BOOL")] int fNB10Syms = (int)(MsPdbCore.wtiSymsNB09));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void release()
    {
        ((delegate* unmanaged[MemberFunction]<WidenTi*, void>)(lpVtbl[0]))((WidenTi*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public byte* pTypeWidenTi([NativeTypeName("TI")] uint ti16, byte* param1)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, uint, byte*, byte*>)(lpVtbl[1]))((WidenTi*)Unsafe.AsPointer(ref this), ti16, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public byte* pSymWidenTi(byte* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, byte*, byte*>)(lpVtbl[2]))((WidenTi*)Unsafe.AsPointer(ref this), param0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public int fTypeWidenTiNoCache(byte* pbTypeDst, byte* pbTypeSrc, [NativeTypeName("long &")] int* cbDst)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, byte*, byte*, int*, int>)(lpVtbl[3]))((WidenTi*)Unsafe.AsPointer(ref this), pbTypeDst, pbTypeSrc, cbDst);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int fSymWidenTiNoCache(byte* pbSymDst, byte* pbSymSrc, [NativeTypeName("long &")] int* cbDst)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, byte*, byte*, int*, int>)(lpVtbl[4]))((WidenTi*)Unsafe.AsPointer(ref this), pbSymDst, pbSymSrc, cbDst);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int fTypeNeedsWidening(byte* pbType)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, byte*, int>)(lpVtbl[5]))((WidenTi*)Unsafe.AsPointer(ref this), pbType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int fSymNeedsWidening(byte* pbSym)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, byte*, int>)(lpVtbl[6]))((WidenTi*)Unsafe.AsPointer(ref this), pbSym);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("BOOL")]
    public int freeRecord(void* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, void*, int>)(lpVtbl[7]))((WidenTi*)Unsafe.AsPointer(ref this), param0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int fQuerySymConvertInfo([NativeTypeName("SymConvertInfo &")] SymConvertInfo* sciOut, byte* pbSym, [NativeTypeName("long")] int cbSym, int doff = 0)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, SymConvertInfo*, byte*, int, int, int>)(lpVtbl[8]))((WidenTi*)Unsafe.AsPointer(ref this), sciOut, pbSym, cbSym, doff);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("BOOL")]
    public int fConvertSymbolBlock([NativeTypeName("SymConvertInfo &")] SymConvertInfo* sciOut, byte* pbSymIn, [NativeTypeName("long")] int cbSymIn, int doff = 0)
    {
        return ((delegate* unmanaged[MemberFunction]<WidenTi*, SymConvertInfo*, byte*, int, int, int>)(lpVtbl[9]))((WidenTi*)Unsafe.AsPointer(ref this), sciOut, pbSymIn, cbSymIn, doff);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void release();

        [VtblIndex(1)]
        byte* pTypeWidenTi([NativeTypeName("TI")] uint ti16, byte* param1);

        [VtblIndex(2)]
        byte* pSymWidenTi(byte* param0);

        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        int fTypeWidenTiNoCache(byte* pbTypeDst, byte* pbTypeSrc, [NativeTypeName("long &")] int* cbDst);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int fSymWidenTiNoCache(byte* pbSymDst, byte* pbSymSrc, [NativeTypeName("long &")] int* cbDst);

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int fTypeNeedsWidening(byte* pbType);

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int fSymNeedsWidening(byte* pbSym);

        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        int freeRecord(void* param0);

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int fQuerySymConvertInfo([NativeTypeName("SymConvertInfo &")] SymConvertInfo* sciOut, byte* pbSym, [NativeTypeName("long")] int cbSym, int doff = 0);

        [VtblIndex(9)]
        [return: NativeTypeName("BOOL")]
        int fConvertSymbolBlock([NativeTypeName("SymConvertInfo &")] SymConvertInfo* sciOut, byte* pbSymIn, [NativeTypeName("long")] int cbSymIn, int doff = 0);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> release;

        [NativeTypeName("BYTE *(TI, BYTE *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, byte*> pTypeWidenTi;

        [NativeTypeName("BYTE *(BYTE *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, byte*> pSymWidenTi;

        [NativeTypeName("BOOL (BYTE *, BYTE *, long &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, byte*, int*, int> fTypeWidenTiNoCache;

        [NativeTypeName("BOOL (BYTE *, BYTE *, long &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, byte*, int*, int> fSymWidenTiNoCache;

        [NativeTypeName("BOOL (BYTE *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> fTypeNeedsWidening;

        [NativeTypeName("BOOL (BYTE *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> fSymNeedsWidening;

        [NativeTypeName("BOOL (void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int> freeRecord;

        [NativeTypeName("BOOL (SymConvertInfo &, BYTE *, long, int)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SymConvertInfo*, byte*, int, int, int> fQuerySymConvertInfo;

        [NativeTypeName("BOOL (SymConvertInfo &, BYTE *, long, int)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SymConvertInfo*, byte*, int, int, int> fConvertSymbolBlock;
    }
}
