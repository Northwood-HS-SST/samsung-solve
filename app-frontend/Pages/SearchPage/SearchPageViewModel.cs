using System.Collections.ObjectModel;
using app_backend.DTOs;
using app_backend.Services.Classes;
using app_backend.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace app_frontend.Pages.SearchPage
{
    public partial class SearchPageViewModel : ObservableObject
    {
        private readonly IAuthService _apiService;

        [ObservableProperty]
        private bool _isRefreshing = false;

        public class SearchResult
        {
            public string Name { get; set; }
            public string ImageUrl { get; set; }
        }

        public ObservableCollection<SearchResult> AvailableEntries { get; set; } =
            new ObservableCollection<SearchResult>();

        public SearchPageViewModel(IAuthService apiService)
        {
            _apiService = apiService;

            _ = Refresh();
        }



        [RelayCommand]
        public async Task Refresh()
        {
            // fake buffering
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(1));
            IsRefreshing = false;

            // fill entry list with fake teams
            AvailableEntries.Clear();
            for (int i = 0; i < 10; i++)
            {
                AvailableEntries.Add(new SearchResult { Name = "Test Team", ImageUrl = "https://content.sportslogos.net/logos/7/153/full/baltimore_ravens_logo_primary_dark_19994944.png" });
            }
        }
    }
}