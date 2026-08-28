using Foundation;

namespace TestDummy
{
   [Register("AppDelegate")]
   public class AppDelegate : TestDummyUIApplicationDelegate
   {
      protected override TestDummyApp CreateTestDummyApp() => TestDummyProgram.CreateTestDummyApp();
   }
}
