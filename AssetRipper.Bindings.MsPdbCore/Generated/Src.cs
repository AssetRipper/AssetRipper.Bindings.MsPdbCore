using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct Src : Src.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public bool Close()
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, bool>)(lpVtbl[0]))((Src*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public bool Add([NativeTypeName("PCSrcHeader")] SrcHeader* psrcheader, [NativeTypeName("const void *")] void* pvData)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, SrcHeader*, void*, bool>)(lpVtbl[1]))((Src*)Unsafe.AsPointer(ref this), psrcheader, pvData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public bool Remove([NativeTypeName("SZ_CONST")] sbyte* szFile)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, sbyte*, bool>)(lpVtbl[2]))((Src*)Unsafe.AsPointer(ref this), szFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public bool QueryByName([NativeTypeName("SZ_CONST")] sbyte* szFile, [NativeTypeName("PSrcHeaderOut")] SrcHeaderOut* psrcheaderOut)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, sbyte*, SrcHeaderOut*, bool>)(lpVtbl[3]))((Src*)Unsafe.AsPointer(ref this), szFile, psrcheaderOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public bool GetData([NativeTypeName("PCSrcHeaderOut")] SrcHeaderOut* pcsrcheader, void* pvData)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, SrcHeaderOut*, void*, bool>)(lpVtbl[4]))((Src*)Unsafe.AsPointer(ref this), pcsrcheader, pvData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool GetEnum(EnumSrc** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, EnumSrc**, bool>)(lpVtbl[5]))((Src*)Unsafe.AsPointer(ref this), ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public bool GetHeaderBlock([NativeTypeName("SrcHeaderBlock &")] SrcHeaderBlock* shb)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, SrcHeaderBlock*, bool>)(lpVtbl[6]))((Src*)Unsafe.AsPointer(ref this), shb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public bool RemoveW([NativeTypeName("wchar_t *")] char* wcsFile)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, char*, bool>)(lpVtbl[7]))((Src*)Unsafe.AsPointer(ref this), wcsFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public bool QueryByNameW([NativeTypeName("wchar_t *")] char* wcsFile, [NativeTypeName("PSrcHeaderOut")] SrcHeaderOut* psrcheaderOut)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, char*, SrcHeaderOut*, bool>)(lpVtbl[8]))((Src*)Unsafe.AsPointer(ref this), wcsFile, psrcheaderOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public bool AddW([NativeTypeName("PCSrcHeaderW")] SrcHeaderW* psrcheader, [NativeTypeName("const void *")] void* pvData)
    {
        return ((delegate* unmanaged[MemberFunction]<Src*, SrcHeaderW*, void*, bool>)(lpVtbl[9]))((Src*)Unsafe.AsPointer(ref this), psrcheader, pvData);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        bool Close();

        [VtblIndex(1)]
        bool Add([NativeTypeName("PCSrcHeader")] SrcHeader* psrcheader, [NativeTypeName("const void *")] void* pvData);

        [VtblIndex(2)]
        bool Remove([NativeTypeName("SZ_CONST")] sbyte* szFile);

        [VtblIndex(3)]
        bool QueryByName([NativeTypeName("SZ_CONST")] sbyte* szFile, [NativeTypeName("PSrcHeaderOut")] SrcHeaderOut* psrcheaderOut);

        [VtblIndex(4)]
        bool GetData([NativeTypeName("PCSrcHeaderOut")] SrcHeaderOut* pcsrcheader, void* pvData);

        [VtblIndex(5)]
        bool GetEnum(EnumSrc** ppenum);

        [VtblIndex(6)]
        bool GetHeaderBlock([NativeTypeName("SrcHeaderBlock &")] SrcHeaderBlock* shb);

        [VtblIndex(7)]
        bool RemoveW([NativeTypeName("wchar_t *")] char* wcsFile);

        [VtblIndex(8)]
        bool QueryByNameW([NativeTypeName("wchar_t *")] char* wcsFile, [NativeTypeName("PSrcHeaderOut")] SrcHeaderOut* psrcheaderOut);

        [VtblIndex(9)]
        bool AddW([NativeTypeName("PCSrcHeaderW")] SrcHeaderW* psrcheader, [NativeTypeName("const void *")] void* pvData);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("bool ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, bool> Close;

        [NativeTypeName("bool (PCSrcHeader, const void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SrcHeader*, void*, bool> Add;

        [NativeTypeName("bool (SZ_CONST)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, bool> Remove;

        [NativeTypeName("bool (SZ_CONST, PSrcHeaderOut) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, SrcHeaderOut*, bool> QueryByName;

        [NativeTypeName("bool (PCSrcHeaderOut, void *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SrcHeaderOut*, void*, bool> GetData;

        [NativeTypeName("bool (EnumSrc **) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnumSrc**, bool> GetEnum;

        [NativeTypeName("bool (SrcHeaderBlock &) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SrcHeaderBlock*, bool> GetHeaderBlock;

        [NativeTypeName("bool (wchar_t *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, bool> RemoveW;

        [NativeTypeName("bool (wchar_t *, PSrcHeaderOut) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, SrcHeaderOut*, bool> QueryByNameW;

        [NativeTypeName("bool (PCSrcHeaderW, const void *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SrcHeaderW*, void*, bool> AddW;
    }
}
