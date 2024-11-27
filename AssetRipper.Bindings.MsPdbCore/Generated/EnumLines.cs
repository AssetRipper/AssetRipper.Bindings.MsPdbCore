using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

[NativeTypeName("struct EnumLines : Enum")]
[NativeInheritance("Enum")]
public unsafe partial struct EnumLines : EnumLines.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void release()
    {
        ((delegate* unmanaged[MemberFunction]<EnumLines*, void>)(lpVtbl[0]))((EnumLines*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void reset()
    {
        ((delegate* unmanaged[MemberFunction]<EnumLines*, void>)(lpVtbl[1]))((EnumLines*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int next()
    {
        return ((delegate* unmanaged[MemberFunction]<EnumLines*, int>)(lpVtbl[2]))((EnumLines*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public bool getLines([NativeTypeName("DWORD *")] uint* fileId, [NativeTypeName("DWORD *")] uint* poffset, [NativeTypeName("WORD *")] ushort* pseg, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("DWORD *")] uint* pcLines, CV_Line_t* pLines)
    {
        return ((delegate* unmanaged[MemberFunction]<EnumLines*, uint*, uint*, ushort*, uint*, uint*, CV_Line_t*, bool>)(lpVtbl[3]))((EnumLines*)Unsafe.AsPointer(ref this), fileId, poffset, pseg, pcb, pcLines, pLines);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public bool getLinesColumns([NativeTypeName("DWORD *")] uint* fileId, [NativeTypeName("DWORD *")] uint* poffset, [NativeTypeName("WORD *")] ushort* pseg, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("DWORD *")] uint* pcLines, CV_Line_t* pLines, CV_Column_t* pColumns)
    {
        return ((delegate* unmanaged[MemberFunction]<EnumLines*, uint*, uint*, ushort*, uint*, uint*, CV_Line_t*, CV_Column_t*, bool>)(lpVtbl[4]))((EnumLines*)Unsafe.AsPointer(ref this), fileId, poffset, pseg, pcb, pcLines, pLines, pColumns);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool clone(EnumLines** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<EnumLines*, EnumLines**, bool>)(lpVtbl[5]))((EnumLines*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : Enum.Interface
    {
        [VtblIndex(3)]
        bool getLines([NativeTypeName("DWORD *")] uint* fileId, [NativeTypeName("DWORD *")] uint* poffset, [NativeTypeName("WORD *")] ushort* pseg, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("DWORD *")] uint* pcLines, CV_Line_t* pLines);

        [VtblIndex(4)]
        bool getLinesColumns([NativeTypeName("DWORD *")] uint* fileId, [NativeTypeName("DWORD *")] uint* poffset, [NativeTypeName("WORD *")] ushort* pseg, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("DWORD *")] uint* pcLines, CV_Line_t* pLines, CV_Column_t* pColumns);

        [VtblIndex(5)]
        bool clone(EnumLines** ppEnum);
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

        [NativeTypeName("bool (DWORD *, DWORD *, WORD *, DWORD *, DWORD *, CV_Line_t *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, ushort*, uint*, uint*, CV_Line_t*, bool> getLines;

        [NativeTypeName("bool (DWORD *, DWORD *, WORD *, DWORD *, DWORD *, CV_Line_t *, CV_Column_t *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, ushort*, uint*, uint*, CV_Line_t*, CV_Column_t*, bool> getLinesColumns;

        [NativeTypeName("bool (EnumLines **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnumLines**, bool> clone;
    }
}
