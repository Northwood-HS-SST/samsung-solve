using app_backend.Services.Classes;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using app_frontend.Pages.SearchPage;

namespace app_frontend.Pages.ProfilePage
{
    public partial class ProfilePageViewModel : ObservableObject
    {
        private readonly AuthService _apiService;


        [ObservableProperty]
        private bool _isRefreshing = false;
        public ObservableCollection<SearchPageViewModel.SearchResult> PastEntries { get; set; } =
            new ObservableCollection<SearchPageViewModel.SearchResult>();

        public ProfilePageViewModel(AuthService apiService)
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


            PastEntries.Clear();

            for (int i = 0; i < 10; i++)
            {
                PastEntries.Add(new SearchPageViewModel.SearchResult { Name = "Test Team", ImageUrl = "https://content.sportslogos.net/logos/7/153/full/baltimore_ravens_logo_primary_dark_19994944.png" });
            }
        }

    }
}
