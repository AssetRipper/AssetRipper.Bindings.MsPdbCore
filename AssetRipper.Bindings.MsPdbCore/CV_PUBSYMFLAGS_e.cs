using System;

namespace AssetRipper.Bindings.MsPdbCore;

/// <summary>
/// <see href="https://github.com/microsoft/microsoft-pdb/blob/805655a28bd8198004be2ac27e6e0290121a5e89/include/cvinfo.h#L3676"/>
/// </summary>
[Flags]
public enum CV_PUBSYMFLAGS_e : uint
{
    None = 0,
    Code = 0x00000001,
    Function = 0x00000002,
    Managed = 0x00000004,
    MSIL = 0x00000008,
}
