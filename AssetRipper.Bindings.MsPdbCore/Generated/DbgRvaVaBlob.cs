namespace AssetRipper.Bindings.MsPdbCore;

public partial struct DbgRvaVaBlob
{
    [NativeTypeName("ULONG")]
    public uint ver;

    [NativeTypeName("ULONG")]
    public uint cbHdr;

    [NativeTypeName("ULONG")]
    public uint cbData;

    [NativeTypeName("ULONG")]
    public uint rvaDataBase;

    [NativeTypeName("DWORDLONG")]
    public ulong vaImageBase;

    [NativeTypeName("ULONG")]
    public uint ulReserved1;

    [NativeTypeName("ULONG")]
    public uint ulReserved2;
}
