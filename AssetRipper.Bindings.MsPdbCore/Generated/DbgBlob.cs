namespace AssetRipper.Bindings.MsPdbCore;

public partial struct DbgBlob
{
    [NativeTypeName("ULONG")]
    public uint ver;

    [NativeTypeName("ULONG")]
    public uint cbHdr;

    [NativeTypeName("ULONG")]
    public uint cbData;
}
