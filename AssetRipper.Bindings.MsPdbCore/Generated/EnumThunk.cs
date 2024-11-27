using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

[NativeTypeName("struct EnumThunk : Enum")]
[NativeInheritance("Enum")]
public unsafe partial struct EnumThunk : EnumThunk.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void release()
    {
        ((delegate* unmanaged[MemberFunction]<EnumThunk*, void>)(lpVtbl[0]))((EnumThunk*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void reset()
    {
        ((delegate* unmanaged[MemberFunction]<EnumThunk*, void>)(lpVtbl[1]))((EnumThunk*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int next()
    {
        return ((delegate* unmanaged[MemberFunction]<EnumThunk*, int>)(lpVtbl[2]))((EnumThunk*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void get(ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb)
    {
        ((delegate* unmanaged[MemberFunction]<EnumThunk*, ushort*, int*, int*, void>)(lpVtbl[3]))((EnumThunk*)Unsafe.AsPointer(ref this), pisect, poff, pcb);
    }

    public interface Interface : Enum.Interface
    {
        [VtblIndex(3)]
        void get(ushort* pisect, [NativeTypeName("long *")] int* poff, [NativeTypeName("long *")] int* pcb);
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

        [NativeTypeName("void (USHORT *, long *, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int*, int*, void> get;
    }
}
