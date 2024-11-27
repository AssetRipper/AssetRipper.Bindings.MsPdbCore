using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.MsPdbCore;

public unsafe partial struct _tagSEARCHDEBUGINFO
{
    [NativeTypeName("DWORD")]
    public uint cb;

    [NativeTypeName("BOOL")]
    public int fMainDebugFile;

    [NativeTypeName("char *")]
    public sbyte* szMod;

    [NativeTypeName("char *")]
    public sbyte* szLib;

    [NativeTypeName("char *")]
    public sbyte* szObj;

    [NativeTypeName("char **")]
    public sbyte** rgszTriedThese;

    [NativeTypeName("char[260]")]
    public _szValidatedFile_e__FixedBuffer szValidatedFile;

    [NativeTypeName("PFNVALIDATEDEBUGINFOFILE")]
    public delegate* unmanaged[Stdcall]<sbyte*, uint*, int> pfnValidateDebugInfoFile;

    [NativeTypeName("char *")]
    public sbyte* szExe;

    [InlineArray(260)]
    public partial struct _szValidatedFile_e__FixedBuffer
    {
        public sbyte e0;
    }
}
