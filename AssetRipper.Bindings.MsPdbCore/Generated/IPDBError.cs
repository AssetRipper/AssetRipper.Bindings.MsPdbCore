using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct IPDBError : IPDBError.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("EC")]
    public int QueryLastError([NativeTypeName("wchar_t *")] char* szError, [NativeTypeName("size_t")] nuint cchMax)
    {
        return ((delegate* unmanaged[MemberFunction]<IPDBError*, char*, nuint, int>)(lpVtbl[0]))((IPDBError*)Unsafe.AsPointer(ref this), szError, cchMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void SetLastError([NativeTypeName("EC")] int ec, [NativeTypeName("const wchar_t *")] char* wszErr)
    {
        ((delegate* unmanaged[MemberFunction]<IPDBError*, int, char*, void>)(lpVtbl[1]))((IPDBError*)Unsafe.AsPointer(ref this), ec, wszErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void Destroy()
    {
        ((delegate* unmanaged[MemberFunction]<IPDBError*, void>)(lpVtbl[2]))((IPDBError*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("EC")]
        int QueryLastError([NativeTypeName("wchar_t *")] char* szError, [NativeTypeName("size_t")] nuint cchMax);

        [VtblIndex(1)]
        void SetLastError([NativeTypeName("EC")] int ec, [NativeTypeName("const wchar_t *")] char* wszErr);

        [VtblIndex(2)]
        void Destroy();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("EC (wchar_t *, size_t)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, nuint, int> QueryLastError;

        [NativeTypeName("void (EC, const wchar_t *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, void> SetLastError;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Destroy;
    }
}
