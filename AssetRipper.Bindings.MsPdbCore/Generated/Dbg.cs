using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct Dbg : Dbg.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("BOOL")]
    public int Close()
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, int>)(lpVtbl[0]))((Dbg*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("long")]
    public int QuerySize()
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, int>)(lpVtbl[1]))((Dbg*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void Reset()
    {
        ((delegate* unmanaged[MemberFunction]<Dbg*, void>)(lpVtbl[2]))((Dbg*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public int Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, uint, int>)(lpVtbl[3]))((Dbg*)Unsafe.AsPointer(ref this), celt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int QueryNext([NativeTypeName("ULONG")] uint celt, void* rgelt)
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, uint, void*, int>)(lpVtbl[4]))((Dbg*)Unsafe.AsPointer(ref this), celt, rgelt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int Find(void* pelt)
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, void*, int>)(lpVtbl[5]))((Dbg*)Unsafe.AsPointer(ref this), pelt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, int>)(lpVtbl[6]))((Dbg*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("BOOL")]
    public int Append([NativeTypeName("ULONG")] uint celt, [NativeTypeName("const void *")] void* rgelt)
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, uint, void*, int>)(lpVtbl[7]))((Dbg*)Unsafe.AsPointer(ref this), celt, rgelt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int ReplaceNext([NativeTypeName("ULONG")] uint celt, [NativeTypeName("const void *")] void* rgelt)
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, uint, void*, int>)(lpVtbl[8]))((Dbg*)Unsafe.AsPointer(ref this), celt, rgelt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("BOOL")]
    public int Clone(Dbg** ppDbg)
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, Dbg**, int>)(lpVtbl[9]))((Dbg*)Unsafe.AsPointer(ref this), ppDbg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("long")]
    public int QueryElementSize()
    {
        return ((delegate* unmanaged[MemberFunction]<Dbg*, int>)(lpVtbl[10]))((Dbg*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("BOOL")]
        int Close();

        [VtblIndex(1)]
        [return: NativeTypeName("long")]
        int QuerySize();

        [VtblIndex(2)]
        void Reset();

        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        int Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int QueryNext([NativeTypeName("ULONG")] uint celt, void* rgelt);

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int Find(void* pelt);

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int Clear();

        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        int Append([NativeTypeName("ULONG")] uint celt, [NativeTypeName("const void *")] void* rgelt);

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int ReplaceNext([NativeTypeName("ULONG")] uint celt, [NativeTypeName("const void *")] void* rgelt);

        [VtblIndex(9)]
        [return: NativeTypeName("BOOL")]
        int Clone(Dbg** ppDbg);

        [VtblIndex(10)]
        [return: NativeTypeName("long")]
        int QueryElementSize();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("long ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> QuerySize;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Reset;

        [NativeTypeName("BOOL (ULONG)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("BOOL (ULONG, void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, int> QueryNext;

        [NativeTypeName("BOOL (void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int> Find;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("BOOL (ULONG, const void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, int> Append;

        [NativeTypeName("BOOL (ULONG, const void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, int> ReplaceNext;

        [NativeTypeName("BOOL (Dbg **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Dbg**, int> Clone;

        [NativeTypeName("long ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> QueryElementSize;
    }
}
