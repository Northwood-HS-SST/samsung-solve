using app_backend.Services.Classes;
using app_backend.Services.Interfaces;
using app_shared.Enums;

namespace app_frontend.Pages.SearchPage;

public partial class SearchPage : ContentPage
{
	public SearchPage(SearchPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

        // preload all sports
        for (int i = 0; i < (int)(app_shared.Enums.SportType.Basketball + 1); i++)
        {
            SportPicker.Items.Add(Enum.GetName((app_shared.Enums.SportType)i));
        }

        LoadUserInfo();

    }

    private async void LoadUserInfo()
    {
        try
        {
            var userService = IPlatformApplication.Current.Services.GetService<IUserService>();
            var currentUser = await userService.GetCurrentUserAsync();

            SportType sport;

            Enum.TryParse(currentUser.sport, out sport);

            SportPicker.SelectedIndex = (int)sport;
        }
        catch (Exception e)
        {
            throw e; // TODO handle exception
        }
    }

    private void OnItemSelected(object? sender, SelectionChangedEventArgs e)
    {

    }


    private void SportPicker_OnSelectedIndexChanged(object? sender, EventArgs e)
    {
        Type enumType = (SportType)SportPicker.SelectedIndex switch
        {
            SportType.Soccer => typeof(SoccerPosition),
            SportType.Volleyball => typeof(VolleyballPosition),
            SportType.Softball => typeof(SoftballPosition),
            SportType.Basketball => typeof(BasketballPosition),
            _ => throw new ArgumentOutOfRangeException()
        };

        PositionPicker.Items.Clear();

        foreach (var value in Enum.GetValues(enumType))
        {
            PositionPicker.Items.Add(value.ToString());
        }
        
        _ = ((SearchPageViewModel)BindingContext).Refresh();
    }

    private void PositionPicker_OnSelectedIndexChanged(object? sender, EventArgs e)
    {
        _ = ((SearchPageViewModel)BindingContext).Refresh();
    }
}