# APK
https://tools-4all.com/apk-explorer

## Uninstall the existing app completely
To uninstall an APK from an Android device, you can use the following command in your terminal or command prompt:

adb uninstall com.yourcompany.yourapp


## Install the APK on your device
adb install yourapp.apk

with downgrade option:
adb install -d yourapp.apk


## Uninstall the app using the package name
adb uninstall com.zpf.maui

## Check the logs for PackageManager and your app
"C:\Program Files (x86)\Android\android-sdk\platform-tools\adb" logcat | findstr PackageManager
"C:\Program Files (x86)\Android\android-sdk\platform-tools\adb" logcat | findstr com.zpf.maui

