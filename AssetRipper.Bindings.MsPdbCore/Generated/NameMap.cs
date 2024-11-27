using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct NameMap : NameMap.Interface
{
    public void** lpVtbl;

    [DllImport("mspdbcore", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?open@NameMap@@SAHPEAUPDB@@HPEAPEAU1@@Z", ExactSpelling = true)]
    [return: NativeTypeName("BOOL")]
    public static extern int open(PDB* ppdb, [NativeTypeName("BOOL")] int fWrite, NameMap** ppnm);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("BOOL")]
    public int close()
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, int>)(lpVtbl[0]))((NameMap*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("BOOL")]
    public int reinitialize()
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, int>)(lpVtbl[1]))((NameMap*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("BOOL")]
    public int getNi([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, sbyte*, uint*, int>)(lpVtbl[2]))((NameMap*)Unsafe.AsPointer(ref this), sz, pni);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("BOOL")]
    public int getName([NativeTypeName("NI")] uint ni, [NativeTypeName("const char **")] sbyte** psz)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, uint, sbyte**, int>)(lpVtbl[3]))((NameMap*)Unsafe.AsPointer(ref this), ni, psz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("BOOL")]
    public int getEnumNameMap(Enum** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, Enum**, int>)(lpVtbl[4]))((NameMap*)Unsafe.AsPointer(ref this), ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("BOOL")]
    public int contains([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, sbyte*, uint*, int>)(lpVtbl[5]))((NameMap*)Unsafe.AsPointer(ref this), sz, pni);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("BOOL")]
    public int commit()
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, int>)(lpVtbl[6]))((NameMap*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("BOOL")]
    public int isValidNi([NativeTypeName("NI")] uint ni)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, uint, int>)(lpVtbl[7]))((NameMap*)Unsafe.AsPointer(ref this), ni);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("BOOL")]
    public int getNiW([NativeTypeName("const wchar_t *")] char* sz, [NativeTypeName("NI *")] uint* pni)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, char*, uint*, int>)(lpVtbl[8]))((NameMap*)Unsafe.AsPointer(ref this), sz, pni);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("BOOL")]
    public int getNameW([NativeTypeName("NI")] uint ni, [NativeTypeName("wchar_t *")] char* szName, [NativeTypeName("size_t *")] nuint* pcch)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, uint, char*, nuint*, int>)(lpVtbl[9]))((NameMap*)Unsafe.AsPointer(ref this), ni, szName, pcch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("BOOL")]
    public int containsW([NativeTypeName("const wchar_t *")] char* sz, [NativeTypeName("NI *")] uint* pni)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, char*, uint*, int>)(lpVtbl[10]))((NameMap*)Unsafe.AsPointer(ref this), sz, pni);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("BOOL")]
    public int containsUTF8([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, sbyte*, uint*, int>)(lpVtbl[11]))((NameMap*)Unsafe.AsPointer(ref this), sz, pni);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("BOOL")]
    public int getNiUTF8([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, sbyte*, uint*, int>)(lpVtbl[12]))((NameMap*)Unsafe.AsPointer(ref this), sz, pni);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("BOOL")]
    public int getNameA([NativeTypeName("NI")] uint ni, [NativeTypeName("const char **")] sbyte** psz)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, uint, sbyte**, int>)(lpVtbl[13]))((NameMap*)Unsafe.AsPointer(ref this), ni, psz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("BOOL")]
    public int getNameW2([NativeTypeName("NI")] uint ni, [NativeTypeName("const wchar_t **")] char** pwsz)
    {
        return ((delegate* unmanaged[MemberFunction]<NameMap*, uint, char**, int>)(lpVtbl[14]))((NameMap*)Unsafe.AsPointer(ref this), ni, pwsz);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("BOOL")]
        int close();

        [VtblIndex(1)]
        [return: NativeTypeName("BOOL")]
        int reinitialize();

        [VtblIndex(2)]
        [return: NativeTypeName("BOOL")]
        int getNi([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni);

        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        int getName([NativeTypeName("NI")] uint ni, [NativeTypeName("const char **")] sbyte** psz);

        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        int getEnumNameMap(Enum** ppenum);

        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        int contains([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni);

        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        int commit();

        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        int isValidNi([NativeTypeName("NI")] uint ni);

        [VtblIndex(8)]
        [return: NativeTypeName("BOOL")]
        int getNiW([NativeTypeName("const wchar_t *")] char* sz, [NativeTypeName("NI *")] uint* pni);

        [VtblIndex(9)]
        [return: NativeTypeName("BOOL")]
        int getNameW([NativeTypeName("NI")] uint ni, [NativeTypeName("wchar_t *")] char* szName, [NativeTypeName("size_t *")] nuint* pcch);

        [VtblIndex(10)]
        [return: NativeTypeName("BOOL")]
        int containsW([NativeTypeName("const wchar_t *")] char* sz, [NativeTypeName("NI *")] uint* pni);

        [VtblIndex(11)]
        [return: NativeTypeName("BOOL")]
        int containsUTF8([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni);

        [VtblIndex(12)]
        [return: NativeTypeName("BOOL")]
        int getNiUTF8([NativeTypeName("const char *")] sbyte* sz, [NativeTypeName("NI *")] uint* pni);

        [VtblIndex(13)]
        [return: NativeTypeName("BOOL")]
        int getNameA([NativeTypeName("NI")] uint ni, [NativeTypeName("const char **")] sbyte** psz);

        [VtblIndex(14)]
        [return: NativeTypeName("BOOL")]
        int getNameW2([NativeTypeName("NI")] uint ni, [NativeTypeName("const wchar_t **")] char** pwsz);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> close;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> reinitialize;

        [NativeTypeName("BOOL (const char *, NI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, uint*, int> getNi;

        [NativeTypeName("BOOL (NI, const char **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, sbyte**, int> getName;

        [NativeTypeName("BOOL (Enum **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Enum**, int> getEnumNameMap;

        [NativeTypeName("BOOL (const char *, NI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, uint*, int> contains;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> commit;

        [NativeTypeName("BOOL (NI)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> isValidNi;

        [NativeTypeName("BOOL (const wchar_t *, NI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> getNiW;

        [NativeTypeName("BOOL (NI, wchar_t *, size_t *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, nuint*, int> getNameW;

        [NativeTypeName("BOOL (const wchar_t *, NI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> containsW;

        [NativeTypeName("BOOL (const char *, NI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, uint*, int> containsUTF8;

        [NativeTypeName("BOOL (const char *, NI *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, uint*, int> getNiUTF8;

        [NativeTypeName("BOOL (NI, const char **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, sbyte**, int> getNameA;

        [NativeTypeName("BOOL (NI, const wchar_t **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> getNameW2;
    }
}
