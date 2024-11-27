using System;
using System.Text;

namespace AssetRipper.Bindings.MsPdbCore;

public static unsafe partial class MsPdbCore
{
    public static bool PDBOpen2W(string wszPDB, string szMode, out PDBErrors pec, out string error, out PDB* pppdb)
    {
        wszPDB += '\0';
        szMode += '\0';

        char[] chars = wszPDB.ToCharArray();
        byte[] bytes = Encoding.UTF8.GetBytes(szMode);
        Span<char> errorChars = stackalloc char[2048];
        bool result = false;

        fixed (char* cp = chars)
        fixed (byte* bp = bytes)
        fixed (char* ep = errorChars)
        fixed (PDBErrors* pecPtr = &pec)
        fixed (PDB** pppdbPtr = &pppdb)
            result = PDBOpen2W(cp, (sbyte*)bp, (int*)pecPtr, ep, (nuint)errorChars.Length, pppdbPtr).ToBoolean();

        int firstZero = errorChars.IndexOf('\0');
        error = new string(errorChars[..firstZero]);

        return result;
    }

    public static bool PDBOpenDBI(PDB* ppdb, string szMode, string szTarget, out DBI* ppdbi)
    {
        szMode += '\0';
        szTarget += '\0';

        fixed (byte* mb = Encoding.UTF8.GetBytes(szMode))
        fixed (byte* tb = Encoding.UTF8.GetBytes(szTarget))
        fixed (DBI** ppdbiPtr = &ppdbi)
            return PDBOpenDBI(ppdb, (sbyte*)mb, (sbyte*)tb, ppdbiPtr).ToBoolean();
    }

    public static bool DBIOpenModW(DBI* pdbi, string szModule, string szFile, out Mod* ppmod)
    {
        szFile += '\0';
        szModule += '\0';

        fixed (char* fp = szFile)
        fixed (char* mp = szModule)
        fixed (Mod** ppmodPtr = &ppmod)
            return DBIOpenModW(pdbi, mp, fp, ppmodPtr).ToBoolean();
    }

    public static bool DBIAddPublic2(DBI* pdbi, string szPublic, ushort isect, int off, CV_PUBSYMFLAGS_e cvpsf = CV_PUBSYMFLAGS_e.None)
    {
        szPublic += '\0';
        fixed (byte* mb = Encoding.UTF8.GetBytes(szPublic))
            return DBIAddPublic2(pdbi, (sbyte*)mb, isect, off, (uint)cvpsf).ToBoolean();
    }

    public static bool ModAddPublic2(Mod* pmod, string szPublic, ushort isect, int off, CV_PUBSYMFLAGS_e cvpsf = CV_PUBSYMFLAGS_e.None)
    {
        szPublic += '\0';
        fixed (byte* mb = Encoding.UTF8.GetBytes(szPublic))
            return ModAddPublic2(pmod, (sbyte*)mb, isect, off, (uint)cvpsf).ToBoolean();
    }

    public static bool PDBQuerySignature2(PDB* ppdb, out Guid guid)
    {
        fixed (Guid* guidPtr = &guid)
            return PDBQuerySignature2(ppdb, (_GUID*)guidPtr).ToBoolean();
    }

    private static bool ToBoolean(this int value) => value != 0;
}
