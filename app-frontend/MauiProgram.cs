using app_backend.Services.Classes;
using app_backend.Services.Interfaces;
using app_frontend.Pages.LoginPage;
using app_frontend.Pages.ProfilePage;
using app_frontend.Pages.SearchPage;
using MauiIcons.Material.Rounded;
using Microsoft.Extensions.Logging;

namespace app_frontend
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            SecureStorage.RemoveAll();

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMaterialRoundedMauiIcons();

            var apiEndpoint = "http://localhost:8000";

            builder.Services.AddSingleton(sp => new HttpClient
            {
                BaseAddress = new Uri(apiEndpoint),  // Local development
                Timeout = TimeSpan.FromSeconds(30)
            });

            builder.Services.AddSingleton<AuthService>();

            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<LoginPageViewModel>();

            builder.Services.AddTransient<SearchPage>();
            builder.Services.AddTransient<SearchPageViewModel>();

            builder.Services.AddTransient<ProfilePage>();
            builder.Services.AddTransient<ProfilePageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
