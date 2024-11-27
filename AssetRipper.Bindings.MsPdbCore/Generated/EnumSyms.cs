using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

[NativeTypeName("struct EnumSyms : Enum")]
[NativeInheritance("Enum")]
public unsafe partial struct EnumSyms : EnumSyms.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void release()
    {
        ((delegate* unmanaged[MemberFunction]<EnumSyms*, void>)(lpVtbl[0]))((EnumSyms*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void reset()
    {
        ((delegate* unmanaged[MemberFunction]<EnumSyms*, void>)(lpVtbl[1]))((EnumSyms*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int next()
    {
        return ((delegate* unmanaged[MemberFunction]<EnumSyms*, int>)(lpVtbl[2]))((EnumSyms*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void get(byte** ppbSym)
    {
        ((delegate* unmanaged[MemberFunction]<EnumSyms*, byte**, void>)(lpVtbl[3]))((EnumSyms*)Unsafe.AsPointer(ref this), ppbSym);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int prev()
    {
        return ((delegate* unmanaged[MemberFunction]<EnumSyms*, int>)(lpVtbl[4]))((EnumSyms*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int clone(EnumSyms** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<EnumSyms*, EnumSyms**, int>)(lpVtbl[5]))((EnumSyms*)Unsafe.AsPointer(ref this), ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int locate([NativeTypeName("long")] int isect, [NativeTypeName("long")] int off)
    {
        return ((delegate* unmanaged[MemberFunction]<EnumSyms*, int, int, int>)(lpVtbl[6]))((EnumSyms*)Unsafe.AsPointer(ref this), isect, off);
    }

    public interface Interface : Enum.Interface
    {
        [VtblIndex(3)]
        void get(byte** ppbSym);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int prev();

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int clone(EnumSyms** ppEnum);

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int locate([NativeTypeName("long")] int isect, [NativeTypeName("long")] int off);
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

        [NativeTypeName("void (BYTE **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte**, void> get;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> prev;

        [NativeTypeName("BOOL (EnumSyms **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnumSyms**, int> clone;

        [NativeTypeName("BOOL (long, long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int> locate;
    }
}
