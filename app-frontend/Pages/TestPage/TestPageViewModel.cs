using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using app_backend.DTOs;
using app_backend.Services.Classes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace app_frontend.Pages.TestPage
{
    public partial class TestPageViewModel : ObservableObject
    {
        private readonly AuthService _apiService;

        public TestPageViewModel(AuthService apiService)
        {
            _apiService = apiService;
        }

        [ObservableProperty]
        private string _statusMessage = "Ready";

        [RelayCommand]
        private async Task OnCallApi()
        {
            // This runs when the button is clicked
            var result = await _apiService.LoginAsync(new LoginRequestDto { email = "user@example.com", password = "string" });

            
            // Update UI properties here...
            _statusMessage = result.user.birth_date.ToString();
        }
    }
}
