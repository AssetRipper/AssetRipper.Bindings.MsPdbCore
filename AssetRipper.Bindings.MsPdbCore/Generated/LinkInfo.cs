namespace AssetRipper.Bindings.MsPdbCore;

public partial struct LinkInfo
{
    [NativeTypeName("ULONG")]
    public uint cb;

    [NativeTypeName("ULONG")]
    public uint ver;

    [NativeTypeName("ULONG")]
    public uint offszCwd;

    [NativeTypeName("ULONG")]
    public uint offszCommand;

    [NativeTypeName("ULONG")]
    public uint ichOutfile;

    [NativeTypeName("ULONG")]
    public uint offszLibs;
}
