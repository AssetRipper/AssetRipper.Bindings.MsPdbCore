using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct StreamImage : StreamImage.Interface
{
    public void** lpVtbl;

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?open@StreamImage@@SAHPEAUStream@@JPEAPEAU1@@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int open(Stream* pstream, [NativeTypeName("long")] int cb, StreamImage** ppsi);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("long")]
    public int size()
    {
        return ((delegate* unmanaged[MemberFunction]<StreamImage*, int>)(lpVtbl[0]))((StreamImage*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void* @base()
    {
        return ((delegate* unmanaged[MemberFunction]<StreamImage*, void*>)(lpVtbl[1]))((StreamImage*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int noteRead([NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<StreamImage*, int, int, void**, int>)(lpVtbl[2]))((StreamImage*)Unsafe.AsPointer(ref this), off, cb, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public int noteWrite([NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<StreamImage*, int, int, void**, int>)(lpVtbl[3]))((StreamImage*)Unsafe.AsPointer(ref this), off, cb, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int writeBack()
    {
        return ((delegate* unmanaged[MemberFunction]<StreamImage*, int>)(lpVtbl[4]))((StreamImage*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int release()
    {
        return ((delegate* unmanaged[MemberFunction]<StreamImage*, int>)(lpVtbl[5]))((StreamImage*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("long")]
        int size();

        [VtblIndex(1)]
        void* @base();

        [VtblIndex(2)]
        [return: NativeTypeName("BOOL")]
        int noteRead([NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, void** ppv);

        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        int noteWrite([NativeTypeName("long")] int off, [NativeTypeName("long")] int cb, void** ppv);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int writeBack();

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int release();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("long ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> size;

        [NativeTypeName("void *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> @base;

        [NativeTypeName("BOOL (long, long, void **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, void**, int> noteRead;

        [NativeTypeName("BOOL (long, long, void **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, void**, int> noteWrite;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> writeBack;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> release;
    }
}
