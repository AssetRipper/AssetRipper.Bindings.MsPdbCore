namespace AssetRipper.Bindings.MsPdbCore;

public partial struct OffMap
{
    [NativeTypeName("ULONG")]
    public uint offOld;

    [NativeTypeName("ULONG")]
    public uint offNew;
}
