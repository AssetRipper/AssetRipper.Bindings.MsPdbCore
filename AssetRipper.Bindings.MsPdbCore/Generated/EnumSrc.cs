using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

[NativeTypeName("struct EnumSrc : Enum")]
[NativeInheritance("Enum")]
public unsafe partial struct EnumSrc : EnumSrc.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void release()
    {
        ((delegate* unmanaged[MemberFunction]<EnumSrc*, void>)(lpVtbl[0]))((EnumSrc*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void reset()
    {
        ((delegate* unmanaged[MemberFunction]<EnumSrc*, void>)(lpVtbl[1]))((EnumSrc*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int next()
    {
        return ((delegate* unmanaged[MemberFunction]<EnumSrc*, int>)(lpVtbl[2]))((EnumSrc*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void get([NativeTypeName("PCSrcHeaderOut *")] SrcHeaderOut** ppcsrcheader)
    {
        ((delegate* unmanaged[MemberFunction]<EnumSrc*, SrcHeaderOut**, void>)(lpVtbl[3]))((EnumSrc*)Unsafe.AsPointer(ref this), ppcsrcheader);
    }

    public interface Interface : Enum.Interface
    {
        [VtblIndex(3)]
        void get([NativeTypeName("PCSrcHeaderOut *")] SrcHeaderOut** ppcsrcheader);
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

        [NativeTypeName("void (PCSrcHeaderOut *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SrcHeaderOut**, void> get;
    }
}
