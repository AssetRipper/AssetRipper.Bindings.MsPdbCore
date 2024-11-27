using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct GSI : GSI.Interface
{
    public void** lpVtbl;

    public const int intv = (int)PDBINTV.PDBIntv;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("INTV")]
    public uint QueryInterfaceVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, uint>)(lpVtbl[0]))((GSI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("IMPV")]
    public uint QueryImplementationVersion()
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, uint>)(lpVtbl[1]))((GSI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public byte* NextSym(byte* pbSym)
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, byte*, byte*>)(lpVtbl[2]))((GSI*)Unsafe.AsPointer(ref this), pbSym);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public byte* HashSym([NativeTypeName("const char *")] sbyte* szName, byte* pbSym)
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, sbyte*, byte*, byte*>)(lpVtbl[3]))((GSI*)Unsafe.AsPointer(ref this), szName, pbSym);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public byte* NearestSym(ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long *")] int* pdisp)
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, ushort, int, int*, byte*>)(lpVtbl[4]))((GSI*)Unsafe.AsPointer(ref this), isect, off, pdisp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int Close()
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, int>)(lpVtbl[5]))((GSI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int getEnumThunk(ushort isect, [NativeTypeName("long")] int off, EnumThunk** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, ushort, int, EnumThunk**, int>)(lpVtbl[6]))((GSI*)Unsafe.AsPointer(ref this), isect, off, ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("unsigned long")]
    public uint OffForSym(byte* pbSym)
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, byte*, uint>)(lpVtbl[7]))((GSI*)Unsafe.AsPointer(ref this), pbSym);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public byte* SymForOff([NativeTypeName("unsigned long")] uint off)
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, uint, byte*>)(lpVtbl[8]))((GSI*)Unsafe.AsPointer(ref this), off);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public byte* HashSymW([NativeTypeName("const wchar_t *")] char* wcsName, byte* pbSym)
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, char*, byte*, byte*>)(lpVtbl[9]))((GSI*)Unsafe.AsPointer(ref this), wcsName, pbSym);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("BOOL")]
    public int getEnumByAddr(EnumSyms** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<GSI*, EnumSyms**, int>)(lpVtbl[10]))((GSI*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("INTV")]
        uint QueryInterfaceVersion();

        [VtblIndex(1)]
        [return: NativeTypeName("IMPV")]
        uint QueryImplementationVersion();

        [VtblIndex(2)]
        byte* NextSym(byte* pbSym);

        [VtblIndex(3)]
        byte* HashSym([NativeTypeName("const char *")] sbyte* szName, byte* pbSym);

        [VtblIndex(4)]
        byte* NearestSym(ushort isect, [NativeTypeName("long")] int off, [NativeTypeName("long *")] int* pdisp);

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int Close();

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int getEnumThunk(ushort isect, [NativeTypeName("long")] int off, EnumThunk** ppenum);

        [VtblIndex(7)]
        [return: NativeTypeName("unsigned long")]
        uint OffForSym(byte* pbSym);

        [VtblIndex(8)]
        byte* SymForOff([NativeTypeName("unsigned long")] uint off);

        [VtblIndex(9)]
        byte* HashSymW([NativeTypeName("const wchar_t *")] char* wcsName, byte* pbSym);

        [VtblIndex(10)]
        [return: NativeTypeName("BOOL")]
        int getEnumByAddr(EnumSyms** ppEnum);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("INTV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryInterfaceVersion;

        [NativeTypeName("IMPV ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> QueryImplementationVersion;

        [NativeTypeName("BYTE *(BYTE *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, byte*> NextSym;

        [NativeTypeName("BYTE *(const char *, BYTE *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, byte*, byte*> HashSym;

        [NativeTypeName("BYTE *(USHORT, long, long *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int, int*, byte*> NearestSym;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("BOOL (USHORT, long, EnumThunk **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int, EnumThunk**, int> getEnumThunk;

        [NativeTypeName("unsigned long (BYTE *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint> OffForSym;

        [NativeTypeName("BYTE *(unsigned long)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*> SymForOff;

        [NativeTypeName("BYTE *(const wchar_t *, BYTE *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, byte*, byte*> HashSymW;

        [NativeTypeName("BOOL (EnumSyms **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnumSyms**, int> getEnumByAddr;
    }
}
