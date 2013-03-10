@echo off
set MSBUILD=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe
%MSBUILD% ..\FSharp.CompilerBinding\FSharp.CompilerBinding.fsproj /p:Configuration=Debug
%MSBUILD% MonoDevelop.FSharpBinding\MonoDevelop.FSharp.windows.fsproj /p:Configuration=Debug
set MDROOT="D:\Program Files (x86)%\Xamarin Studio"
rmdir /s /q pack
mkdir pack\Debug
%MDROOT%\bin\mdtool.exe setup pack bin\Debug\MonoDevelop.Samples.DateInserter.addin.xml -d:pack\Debug
%MDROOT%\bin\mdtool.exe setup install -y pack\MonoDevelop.Flash_1.0.0.mpack 