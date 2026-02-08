using app_backend.DTOs;
using app_backend.Services.Classes;
using app_backend.Services.Interfaces;
using app_frontend.Pages.LoginPage;
using Microsoft.Extensions.DependencyInjection;

namespace app_frontend
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;


        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        protected override void OnStart()
        {
            base.OnStart();
            try
            {
                var authService = IPlatformApplication.Current.Services.GetService<IAuthService>();

                authService.LoginAsync(new LoginRequestDto { email = "user@example.com",password = "string" }).GetAwaiter().GetResult();

                var authToken = authService.GetTokenAsync();

                if (!string.IsNullOrEmpty(authToken.Result))
                {
                    // Optionally validate token with an API call
                    bool isAuthenticated = true;

                    if (isAuthenticated)
                    {
                        // User is already logged in, navigate to main page/shell
                        MainPage = _serviceProvider.GetRequiredService<AppShell>();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw ex;
            }
            var loginPage = _serviceProvider.GetRequiredService<LoginPage>();
            MainPage = new NavigationPage(loginPage);

        }
    }
}