using Android.App;
using Android.Runtime;

namespace TestDummy
{
   [Application]
   public class MainApplication : TestDummyApplication
   {
      public MainApplication(IntPtr handle, JniHandleOwnership ownership)
         : base(handle, ownership)
      {
      }

      protected override TestDummyApp CreateTestDummyApp() => TestDummyProgram.CreateTestDummyApp();
   }
}
