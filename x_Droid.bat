@rem https://learn.microsoft.com/en-us/dotnet/TestDummy/android/deployment/publish-cli?view=net-TestDummy-9.0
@rem dotnet workload update
cls
call Clean.bat
dotnet clean
//..\UpdateVersionInfoTestDummy -s -i -ui
dotnet publish TestDummy\TestDummy.csproj -f net10.0-android -c Release /p:TestDummy=True -p:AndroidKeyStore=true -p:AndroidSigningKeyStore=D:\GitWare\_Units_\_Certif_\ZPF.keystore -p:AndroidSigningKeyAlias=ZPF -p:AndroidSigningKeyPass=MossIsTheBoss -p:AndroidSigningStorePass=MossIsTheBoss
rem OK dotnet build TestDummy\TestDummy.csproj -c Release -f net10.0-android


@echo off
@if %ERRORLEVEL% neq 0 (
    @echo *** Publish failed with error level %ERRORLEVEL% ***
    @exit /b %ERRORLEVEL%
)

@echo *** publish succeeded *** 

copy /y ".\TestDummy\bin\Release\net10.0-android\fr.zpf.TestDummy-Signed.apk" .
rem call scs LastUpdate.Droid.scs
