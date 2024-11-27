dotnet tool install --global ClangSharpPInvokeGenerator --version 18.1.0.2
cd AssetRipper.Bindings.MsPdbCore
if not exist "Generated" mkdir "Generated"
rmdir /s /q Generated
cd ..
ClangSharpPInvokeGenerator @generate.rsp