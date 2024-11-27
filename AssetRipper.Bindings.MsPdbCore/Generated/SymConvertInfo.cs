namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct SymConvertInfo
{
    [NativeTypeName("ULONG")]
    public uint cbSyms;

    [NativeTypeName("ULONG")]
    public uint cSyms;

    public byte* pbSyms;

    public OffMap* rgOffMap;
}
