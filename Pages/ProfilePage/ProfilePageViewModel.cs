using app_backend.Services.Classes;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using app_backend.Services.Interfaces;
using app_frontend.Pages.HomePage;

namespace app_frontend.Pages.ProfilePage
{
    public partial class ProfilePageViewModel : ObservableObject
    {
        private readonly IAuthService _apiService;


        [ObservableProperty]
        private bool _isRefreshing = false;
        public ObservableCollection<HomePageViewModel.SearchResult> PastEntries { get; set; } =
            new ObservableCollection<HomePageViewModel.SearchResult>();

        public ProfilePageViewModel(IAuthService apiService)
        {
            _apiService = apiService;

            _ = Refresh();
        }

        [RelayCommand]
        private async Task Refresh()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(1));
            IsRefreshing = false;
        }

    }
}
