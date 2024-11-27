using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.MsPdbCore;

public partial struct SrcHeader
{
    [NativeTypeName("unsigned long")]
    public uint cb;

    [NativeTypeName("unsigned long")]
    public uint ver;

    [NativeTypeName("unsigned long")]
    public uint sig;

    [NativeTypeName("unsigned long")]
    public uint cbSource;

    [NativeTypeName("unsigned char")]
    public byte srccompress;

    [NativeTypeName("__AnonymousRecord_pdb_L592_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("unsigned char[1]")]
    public _szNames_e__FixedBuffer szNames;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("unsigned char")]
        public byte grFlags;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_pdb_L594_C9")]
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

    public partial struct _szNames_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
