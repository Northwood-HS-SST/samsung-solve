using app_backend.DTOs;
using app_backend.Services.Classes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace app_frontend.Pages.LoginPage
{
    public partial class LoginPageViewModel : ObservableObject
    {
        private readonly AuthService _apiService;


        public LoginPageViewModel(AuthService apiService)
        {
            _apiService = apiService;
        }

    }
}
