using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

[NativeTypeName("struct EnumNameMap : Enum")]
[NativeInheritance("Enum")]
public unsafe partial struct EnumNameMap : EnumNameMap.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void release()
    {
        ((delegate* unmanaged[MemberFunction]<EnumNameMap*, void>)(lpVtbl[0]))((EnumNameMap*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void reset()
    {
        ((delegate* unmanaged[MemberFunction]<EnumNameMap*, void>)(lpVtbl[1]))((EnumNameMap*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int next()
    {
        return ((delegate* unmanaged[MemberFunction]<EnumNameMap*, int>)(lpVtbl[2]))((EnumNameMap*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void get([NativeTypeName("const char **")] sbyte** psz, [NativeTypeName("NI *")] uint* pni)
    {
        ((delegate* unmanaged[MemberFunction]<EnumNameMap*, sbyte**, uint*, void>)(lpVtbl[3]))((EnumNameMap*)Unsafe.AsPointer(ref this), psz, pni);
    }

    public interface Interface : Enum.Interface
    {
        [VtblIndex(3)]
        void get([NativeTypeName("const char **")] sbyte** psz, [NativeTypeName("NI *")] uint* pni);
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

        [NativeTypeName("void (const char **, NI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte**, uint*, void> get;
    }
}
