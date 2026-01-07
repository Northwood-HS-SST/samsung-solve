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
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMaterialRoundedMauiIcons();

            var apiEndpoint = DeviceInfo.Platform == DevicePlatform.Android
                ? "http://10.0.2.2:8000"  // Android emulator special IP
                : "http://localhost:8000"; // iOS simulator or physical device on same network

            builder.Services.AddSingleton(sp => new HttpClient
            {
                BaseAddress = new Uri(apiEndpoint),  // Local development
                Timeout = TimeSpan.FromSeconds(30)
            });

            builder.Services.AddSingleton<IAuthService, AuthService>();
            builder.Services.AddSingleton<IUserService, UserService>();


            builder.Services.AddSingleton<AppShell>();

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
