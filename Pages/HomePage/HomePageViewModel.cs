using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Humanizer;

namespace app_frontend.Pages.HomePage
{
    public partial class HomePageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<SearchResult> availableEntries;

        [ObservableProperty]
        private ObservableCollection<Popup> availablePopups;

        [ObservableProperty]
        private bool isRefreshing;

        public HomePageViewModel()
        {
            AvailableEntries = new ObservableCollection<SearchResult>();
            AvailablePopups = new ObservableCollection<Popup>();

            // Initialize commands
            LikeCommand = new RelayCommand<SearchResult>(OnLike);
            CommentCommand = new RelayCommand<SearchResult>(OnComment);
            ShareCommand = new RelayCommand<SearchResult>(OnShare);
            SaveCommand = new RelayCommand<SearchResult>(OnSave);
            RefreshCommand = new RelayCommand(OnRefresh);
            ClosePopupCommand = new RelayCommand<Popup>(OnClosePopup);

            AvailablePopups.Add(new Popup{Content = "Welcome to HerPlay!", Title = "Welcome!"});

            OnRefresh();
        }

        public IRelayCommand<SearchResult> LikeCommand { get; }
        public IRelayCommand<SearchResult> CommentCommand { get; }
        public IRelayCommand<SearchResult> ShareCommand { get; }
        public IRelayCommand<SearchResult> SaveCommand { get; }
        public IRelayCommand<Popup> ClosePopupCommand { get; }
        public IRelayCommand RefreshCommand { get; }

        private void OnLike(SearchResult post)
        {
            // Handle like action
            // Example: post.IsLiked = !post.IsLiked;
            // Call API to like/unlike the post
        }

        private void OnComment(SearchResult post)
        {
            // Handle comment action
            // Example: Navigate to comment page
            // Shell.Current.GoToAsync($"CommentPage?postId={post.Id}");
        }

        private void OnShare(SearchResult post)
        {
            // Handle share action
            // Example: Open share dialog
        }

        private void OnSave(SearchResult post)
        {
            // Handle save action
            // Example: post.IsSaved = !post.IsSaved;
            // Call API to save/unsave the post
        }

        private void OnRefresh()
        {
            // Handle refresh action
            IsRefreshing = true;

            // Load data
            // await LoadPostsAsync();

            // fill entry list with fake teams
            AvailableEntries.Clear();
            for (int i = 0; i < 10; i++)
            {
                var searchResult = new SearchResult();
                searchResult.ProfilePhotoUrl =
                    "https://content.sportslogos.net/logos/7/153/full/baltimore_ravens_logo_primary_dark_19994944.png";

                searchResult.Content = "Blah blah blah join my team blah blah blah";
                searchResult.UserName = "Ravens";
                searchResult.CommentCount = 10;
                searchResult.LikeCount = 50;
                searchResult.TimePosted = (DateTime.Now - DateTime.Parse("Jan 1, 2026, 5:00 PM")).Humanize();
                searchResult.ImageUrl =
                    "https://static01.nyt.com/images/2023/06/08/multimedia/08ncaa-softball-oklahoma-top-thwj/08ncaa-softball-oklahoma-top-thwj-articleLarge.jpg?quality=75&auto=webp&disable=upscale";

                searchResult.HasSpecialOutline = (i % 2) == 0;

                AvailableEntries.Add(searchResult);
            }


            IsRefreshing = false;
        }


        private void OnClosePopup(Popup popup)
        {
            AvailablePopups.Remove(popup);
        }

        public class SearchResult
        {
            public string Id { get; set; }
            public string ProfilePhotoUrl { get; set; }
            public string UserName { get; set; }
            public string TimePosted { get; set; }
            public string Content { get; set; }
            public string ImageUrl { get; set; }
            public bool IsLiked { get; set; }
            public bool IsSaved { get; set; }
            public int LikeCount { get; set; }
            public int CommentCount { get; set; }

            public bool HasSpecialOutline { get; set; }
        }

        public class Popup
        {
            public string Title { get; set; }
            public string Content { get; set; }
        }

    }
}