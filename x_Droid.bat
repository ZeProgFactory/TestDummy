@rem https://learn.microsoft.com/en-us/dotnet/maui/android/deployment/publish-cli?view=net-maui-9.0
@rem dotnet workload update
cls
call Clean.bat
dotnet clean
//..\UpdateVersionInfoMaui -s -i -ui
dotnet publish Maui\Maui.csproj -f net10.0-android -c Release /p:MAUI=True -p:AndroidKeyStore=true -p:AndroidSigningKeyStore=D:\GitWare\_Units_\_Certif_\ZPF.keystore -p:AndroidSigningKeyAlias=ZPF -p:AndroidSigningKeyPass=MossIsTheBoss -p:AndroidSigningStorePass=MossIsTheBoss
rem OK dotnet build Maui\Maui.csproj -c Release -f net10.0-android


@echo off
@if %ERRORLEVEL% neq 0 (
    @echo *** Publish failed with error level %ERRORLEVEL% ***
    @exit /b %ERRORLEVEL%
)

@echo *** publish succeeded *** 

copy /y ".\Maui\bin\Release\net10.0-android\fr.zpf.maui-Signed.apk" .
rem call scs LastUpdate.Droid.scs
