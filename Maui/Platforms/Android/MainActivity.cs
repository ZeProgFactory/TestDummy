using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

namespace TestDummy
{
   [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
   [Register("com.companyname.TestDummy.MainActivity")]
   public class MainActivity : MauiAppCompatActivity
   {
   }
}
