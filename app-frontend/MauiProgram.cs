using app_backend.Services.Classes;
using app_backend.Services.Interfaces;
using app_frontend.Pages.TestPage;
using Microsoft.Extensions.Logging;

namespace app_frontend
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

            string apiEndpoint = "https://web-production-eca0f.up.railway.app/";

#if DEBUG
            apiEndpoint = "http://localhost:8000";   
#endif

            builder.Services.AddSingleton(sp => new HttpClient
            {
                BaseAddress = new Uri(apiEndpoint),  // Local development
                Timeout = TimeSpan.FromSeconds(30)
            });

            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddTransient<TestPageViewModel>();
            builder.Services.AddTransient<TestPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
