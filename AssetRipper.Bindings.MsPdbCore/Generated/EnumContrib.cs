using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

[NativeTypeName("struct EnumContrib : Enum")]
[NativeInheritance("Enum")]
public unsafe partial struct EnumContrib : EnumContrib.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void release()
    {
        ((delegate* unmanaged[MemberFunction]<EnumContrib*, void>)(lpVtbl[0]))((EnumContrib*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void reset()
    {
        ((delegate* unmanaged[MemberFunction]<EnumContrib*, void>)(lpVtbl[1]))((EnumContrib*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int next()
    {
        return ((delegate* unmanaged[MemberFunction]<EnumContrib*, int>)(lpVtbl[2]))((EnumContrib*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void get(ushort* pimod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics)
    {
        ((delegate* unmanaged[MemberFunction]<EnumContrib*, ushort*, ushort*, int*, int*, uint*, void>)(lpVtbl[3]))((EnumContrib*)Unsafe.AsPointer(ref this), pimod, pisect, poff, pcb, pdwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void getCrcs([NativeTypeName("DWORD *")] uint* pcrcData, [NativeTypeName("DWORD *")] uint* pcrcReloc)
    {
        ((delegate* unmanaged[MemberFunction]<EnumContrib*, uint*, uint*, void>)(lpVtbl[4]))((EnumContrib*)Unsafe.AsPointer(ref this), pcrcData, pcrcReloc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool fUpdate([NativeTypeName("long")] int off, [NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged[MemberFunction]<EnumContrib*, int, int, bool>)(lpVtbl[5]))((EnumContrib*)Unsafe.AsPointer(ref this), off, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int prev()
    {
        return ((delegate* unmanaged[MemberFunction]<EnumContrib*, int>)(lpVtbl[6]))((EnumContrib*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("BOOL")]
    public int clone(EnumContrib** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<EnumContrib*, EnumContrib**, int>)(lpVtbl[7]))((EnumContrib*)Unsafe.AsPointer(ref this), ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int locate([NativeTypeName("long")] int isect, [NativeTypeName("long")] int off)
    {
        return ((delegate* unmanaged[MemberFunction]<EnumContrib*, int, int, int>)(lpVtbl[8]))((EnumContrib*)Unsafe.AsPointer(ref this), isect, off);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void get2(ushort* pimod, ushort* pisect, [NativeTypeName("DWORD *")] uint* poff, [NativeTypeName("DWORD *")] uint* pisectCoff, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics)
    {
        ((delegate* unmanaged[MemberFunction]<EnumContrib*, ushort*, ushort*, uint*, uint*, uint*, uint*, void>)(lpVtbl[9]))((EnumContrib*)Unsafe.AsPointer(ref this), pimod, pisect, poff, pisectCoff, pcb, pdwCharacteristics);
    }

    public interface Interface : Enum.Interface
    {
        [VtblIndex(3)]
        void get(ushort* pimod, ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);

        [VtblIndex(4)]
        void getCrcs([NativeTypeName("DWORD *")] uint* pcrcData, [NativeTypeName("DWORD *")] uint* pcrcReloc);

        [VtblIndex(5)]
        bool fUpdate([NativeTypeName("long")] int off, [NativeTypeName("long")] int cb);

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int prev();

        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        int clone(EnumContrib** ppEnum);

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int locate([NativeTypeName("long")] int isect, [NativeTypeName("long")] int off);

        [VtblIndex(9)]
        void get2(ushort* pimod, ushort* pisect, [NativeTypeName("DWORD *")] uint* poff, [NativeTypeName("DWORD *")] uint* pisectCoff, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("ULONG *")] uint* pdwCharacteristics);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> release;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> reset;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> next;

        [NativeTypeName("void (USHORT *, USHORT *, long *, long *, ULONG *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, ushort*, int*, int*, uint*, void> get;

        [NativeTypeName("void (DWORD *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, void> getCrcs;

        [NativeTypeName("bool (long, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, bool> fUpdate;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> prev;

        [NativeTypeName("BOOL (EnumContrib **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnumContrib**, int> clone;

        [NativeTypeName("BOOL (long, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int> locate;

        [NativeTypeName("void (USHORT *, USHORT *, DWORD *, DWORD *, DWORD *, ULONG *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, ushort*, uint*, uint*, uint*, uint*, void> get2;
    }
}
