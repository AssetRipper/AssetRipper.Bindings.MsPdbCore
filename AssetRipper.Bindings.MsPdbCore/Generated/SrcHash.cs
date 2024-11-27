using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct SrcHash : SrcHash.Interface
{
    public void** lpVtbl;

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?FCreateSrcHash@SrcHash@@SA_NAEAPEAU1@W4HID@1@@Z", ExactSpelling = true)]
    public static extern bool FCreateSrcHash([NativeTypeName("PSrcHash &")] SrcHash** param0, [NativeTypeName("SrcHash::HID")] HID hid);

    public enum TriState
    {
        tsYes,
        tsNo,
        tsMaybe,
    }

    public enum HID
    {
        hidNone,
        hidMD5,
        hidSHA1,
        hidSHA256,
        hidMax,
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public bool FHashBuffer([NativeTypeName("PCV")] void* pvBuf, [NativeTypeName("size_t")] nuint cbBuf)
    {
        return ((delegate* unmanaged[MemberFunction]<SrcHash*, void*, nuint, bool>)(lpVtbl[0]))((SrcHash*)Unsafe.AsPointer(ref this), pvBuf, cbBuf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("SrcHash::HashID_t")]
    public int HashID()
    {
        return ((delegate* unmanaged[MemberFunction]<SrcHash*, int>)(lpVtbl[1]))((SrcHash*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("SrcHash::CbHash_t")]
    public uint CbHash()
    {
        return ((delegate* unmanaged[MemberFunction]<SrcHash*, uint>)(lpVtbl[2]))((SrcHash*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public bool FGetHash([NativeTypeName("PV")] void* pvHash, [NativeTypeName("SrcHash::CbHash_t")] uint cbHash)
    {
        return ((delegate* unmanaged[MemberFunction]<SrcHash*, void*, uint, bool>)(lpVtbl[3]))((SrcHash*)Unsafe.AsPointer(ref this), pvHash, cbHash);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SrcHash::TriState")]
    public TriState TsVerifyHash([NativeTypeName("SrcHash::HID")] HID param0, [NativeTypeName("SrcHash::CbHash_t")] uint cbHash, [NativeTypeName("PCV")] void* pvHash, [NativeTypeName("size_t")] nuint cbBuf, [NativeTypeName("PCV")] void* pvBuf)
    {
        return ((delegate* unmanaged[MemberFunction]<SrcHash*, HID, uint, void*, nuint, void*, TriState>)(lpVtbl[4]))((SrcHash*)Unsafe.AsPointer(ref this), param0, cbHash, pvHash, cbBuf, pvBuf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool FReset()
    {
        return ((delegate* unmanaged[MemberFunction]<SrcHash*, bool>)(lpVtbl[5]))((SrcHash*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void Close()
    {
        ((delegate* unmanaged[MemberFunction]<SrcHash*, void>)(lpVtbl[6]))((SrcHash*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        bool FHashBuffer([NativeTypeName("PCV")] void* pvBuf, [NativeTypeName("size_t")] nuint cbBuf);

        [VtblIndex(1)]
        [return: NativeTypeName("SrcHash::HashID_t")]
        int HashID();

        [VtblIndex(2)]
        [return: NativeTypeName("SrcHash::CbHash_t")]
        uint CbHash();

        [VtblIndex(3)]
        bool FGetHash([NativeTypeName("PV")] void* pvHash, [NativeTypeName("SrcHash::CbHash_t")] uint cbHash);

        [VtblIndex(4)]
        [return: NativeTypeName("SrcHash::TriState")]
        TriState TsVerifyHash([NativeTypeName("SrcHash::HID")] HID param0, [NativeTypeName("SrcHash::CbHash_t")] uint cbHash, [NativeTypeName("PCV")] void* pvHash, [NativeTypeName("size_t")] nuint cbBuf, [NativeTypeName("PCV")] void* pvBuf);

        [VtblIndex(5)]
        bool FReset();

        [VtblIndex(6)]
        void Close();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("bool (PCV, size_t)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint, bool> FHashBuffer;

        [NativeTypeName("HashID_t () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> HashID;

        [NativeTypeName("CbHash_t () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> CbHash;

        [NativeTypeName("bool (PV, CbHash_t) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, bool> FGetHash;

        [NativeTypeName("TriState (HID, CbHash_t, PCV, size_t, PCV)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HID, uint, void*, nuint, void*, TriState> TsVerifyHash;

        [NativeTypeName("bool ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, bool> FReset;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Close;
    }
}
