# AssetRipper.Bindings.MsPdbCore

These are bindings over `mspdbcore.dll` which is shipped with Visual Studio.

## Required Files

You need to manually copy the following Microsoft-provided libraries from Visual Studio (or other build tools) for this wrapping library. They cannot be redistributed because the license on them is not clear.

 * `mspdbcore.dll`
 * `msobj140.dll`
 * `tbbmalloc.dll`

These need to be placed next to the built executable file. Use file search to find `mspdbcore` in the Visual Studio install directory. By default, they are in `C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\`.
