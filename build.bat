:: %systemroot%\Microsoft.Net\Framework\v4.0.30319\MSBuild.exe build.proj /t:Release /fl /flp:Verbosity=normal & pause
"%ProgramFiles(x86)%\MSBuild\14.0\Bin\MsBuild.exe" build.proj /t:Release /fl /flp:Verbosity=normal
dotnet pack DatabaseSchemaReader -c Release -o nuget
pause