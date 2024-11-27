namespace AssetRipper.Bindings.MsPdbCore;

public partial struct SO
{
    [NativeTypeName("long")]
    public int off;

    public ushort isect;

    [NativeTypeName("unsigned short")]
    public ushort pad;
}
