using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct Stream : Stream.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("long")]
    public int QueryCb()
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, int>)(lpVtbl[0]))((Stream*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("BOOL")]
    public int Read([NativeTypeName("long")] int off, void* pvBuf, [NativeTypeName("long *")] int* pcbBuf)
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, int, void*, int*, int>)(lpVtbl[1]))((Stream*)Unsafe.AsPointer(ref this), off, pvBuf, pcbBuf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int Write([NativeTypeName("long")] int off, void* pvBuf, [NativeTypeName("long")] int cbBuf)
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, int, void*, int, int>)(lpVtbl[2]))((Stream*)Unsafe.AsPointer(ref this), off, pvBuf, cbBuf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public int Replace(void* pvBuf, [NativeTypeName("long")] int cbBuf)
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, void*, int, int>)(lpVtbl[3]))((Stream*)Unsafe.AsPointer(ref this), pvBuf, cbBuf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int Append(void* pvBuf, [NativeTypeName("long")] int cbBuf)
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, void*, int, int>)(lpVtbl[4]))((Stream*)Unsafe.AsPointer(ref this), pvBuf, cbBuf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int Delete()
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, int>)(lpVtbl[5]))((Stream*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int Release()
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, int>)(lpVtbl[6]))((Stream*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("BOOL")]
    public int Read2([NativeTypeName("long")] int off, void* pvBuf, [NativeTypeName("long")] int cbBuf)
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, int, void*, int, int>)(lpVtbl[7]))((Stream*)Unsafe.AsPointer(ref this), off, pvBuf, cbBuf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int Truncate([NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged[MemberFunction]<Stream*, int, int>)(lpVtbl[8]))((Stream*)Unsafe.AsPointer(ref this), cb);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("long")]
        int QueryCb();

        [VtblIndex(1)]
        [return: NativeTypeName("BOOL")]
        int Read([NativeTypeName("long")] int off, void* pvBuf, [NativeTypeName("long *")] int* pcbBuf);

        [VtblIndex(2)]
        [return: NativeTypeName("BOOL")]
        int Write([NativeTypeName("long")] int off, void* pvBuf, [NativeTypeName("long")] int cbBuf);

        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        int Replace(void* pvBuf, [NativeTypeName("long")] int cbBuf);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int Append(void* pvBuf, [NativeTypeName("long")] int cbBuf);

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int Delete();

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int Release();

        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        int Read2([NativeTypeName("long")] int off, void* pvBuf, [NativeTypeName("long")] int cbBuf);

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int Truncate([NativeTypeName("long")] int cb);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("long ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> QueryCb;

        [NativeTypeName("BOOL (long, void *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, void*, int*, int> Read;

        [NativeTypeName("BOOL (long, void *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, void*, int, int> Write;

        [NativeTypeName("BOOL (void *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int, int> Replace;

        [NativeTypeName("BOOL (void *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int, int> Append;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Delete;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Release;

        [NativeTypeName("BOOL (long, void *, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, void*, int, int> Read2;

        [NativeTypeName("BOOL (long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> Truncate;
    }
}
