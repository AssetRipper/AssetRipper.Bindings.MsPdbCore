using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public partial struct SrcHeaderBlock
{
    public int ver;

    public int cb;

    [NativeTypeName("__AnonymousRecord_pdb_L665_C5")]
    public _ft_e__Struct ft;

    public int age;

    [NativeTypeName("BYTE[44]")]
    public _rgbPad_e__FixedBuffer rgbPad;

    public partial struct _ft_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint dwLowDateTime;

        [NativeTypeName("DWORD")]
        public uint dwHighDateTime;
    }

    [InlineArray(44)]
    public partial struct _rgbPad_e__FixedBuffer
    {
        public byte e0;
    }
}
