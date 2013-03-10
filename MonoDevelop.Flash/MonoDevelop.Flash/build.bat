@echo off
set MSBUILD=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe
%MSBUILD% MonoDevelop.Flash.csproj /p:Configuration=Debug
set MDROOT="D:\Program Files (x86)%\Xamarin Studio"
rmdir /s /q pack
mkdir pack\Debug
%MDROOT%\bin\mdtool.exe setup pack bin\Debug\MonoDevelop.Flash.addin.xml -d:pack\Debug
%MDROOT%\bin\mdtool.exe setup install -y pack\MonoDevelop.Flash_1.0.mpack 