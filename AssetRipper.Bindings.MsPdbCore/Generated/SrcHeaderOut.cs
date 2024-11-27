using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct SrcHeaderOut
{
    [NativeTypeName("unsigned long")]
    public uint cb;

    [NativeTypeName("unsigned long")]
    public uint ver;

    [NativeTypeName("unsigned long")]
    public uint sig;

    [NativeTypeName("unsigned long")]
    public uint cbSource;

    [NativeTypeName("unsigned long")]
    public uint niFile;

    [NativeTypeName("unsigned long")]
    public uint niObj;

    [NativeTypeName("unsigned long")]
    public uint niVirt;

    [NativeTypeName("unsigned char")]
    public byte srccompress;

    [NativeTypeName("__AnonymousRecord_pdb_L644_C5")]
    public _Anonymous1_e__Union Anonymous1;

    public short sPad;

    [NativeTypeName("__AnonymousRecord_pdb_L652_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("unsigned char")]
        public byte grFlags;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_pdb_L646_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            [NativeBitfield("fVirtual", offset: 0, length: 1)]
            [NativeBitfield("pad", offset: 1, length: 7)]
            public byte _bitfield;

            [NativeTypeName("unsigned char : 1")]
            public byte fVirtual
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (byte)(_bitfield & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
                }
            }

            [NativeTypeName("unsigned char : 7")]
            public byte pad
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (byte)((_bitfield >> 1) & 0x7Fu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1));
                }
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public void* pvReserved1;

        [FieldOffset(0)]
        [NativeTypeName("long long")]
        public long pv64Reserved2;
    }
}
