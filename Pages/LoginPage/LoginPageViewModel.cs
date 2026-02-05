using app_backend.DTOs;
using app_backend.Services.Classes;
using app_backend.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace app_frontend.Pages.LoginPage
{
    public partial class LoginPageViewModel : ObservableObject
    {
        private readonly IAuthService _apiService;


        public LoginPageViewModel(IAuthService apiService)
        {
            _apiService = apiService;
        }

    }
}
