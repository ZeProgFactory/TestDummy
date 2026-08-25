using Microsoft.Extensions.Logging;
#if DEBUG
using Microsoft.Maui.DevFlow.Agent;
#endif

namespace Maui
{
   public static class MauiProgram
   {
      public static MauiApp CreateMauiApp()
      {
         var builder = MauiApp.CreateBuilder();
         builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
               fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
               fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
   		builder.Logging.AddDebug();
#endif
#if DEBUG
         builder.AddMauiDevFlowAgent();
#endif

         return builder.Build();
      }
   }
}
