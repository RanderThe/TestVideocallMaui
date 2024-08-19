using Microsoft.Extensions.Logging;
using The49.Twilio.Video.Maui;

namespace TestVideocallMaui
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
            builder
            .UseMauiApp<App>()
            .UseTwilioVideo();

            return builder.Build();
        }
    }
}
