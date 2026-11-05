using Foundation;

namespace TestDummy
{
   [Register("AppDelegate")]
   public class AppDelegate : MauiUIApplicationDelegate
   {
      protected override MauiApp CreateMauiApp() => TestDummyProgram.CreateMauiApp();
   }
}
