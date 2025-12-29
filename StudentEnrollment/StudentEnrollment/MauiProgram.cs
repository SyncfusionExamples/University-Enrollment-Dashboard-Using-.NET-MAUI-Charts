using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace StudentEnrollment
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Jost-Regular.ttf", "JostRegular");
                    fonts.AddFont("JosefinSans-Regular.ttf", "JosefinSansRegular");
                });

            // TODO: Register your Syncfusion license here (placeholder)
            // Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
            builder.Services.AddSingleton<EnrollmentViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
