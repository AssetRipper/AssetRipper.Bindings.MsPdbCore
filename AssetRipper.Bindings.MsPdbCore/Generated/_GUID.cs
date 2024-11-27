using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public partial struct _GUID
{
    [NativeTypeName("DWORD")]
    public uint Data1;

    [NativeTypeName("WORD")]
    public ushort Data2;

    [NativeTypeName("WORD")]
    public ushort Data3;

    [NativeTypeName("BYTE[8]")]
    public _Data4_e__FixedBuffer Data4;

    [InlineArray(8)]
    public partial struct _Data4_e__FixedBuffer
    {
        public byte e0;
    }
}
