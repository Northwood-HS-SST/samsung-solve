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

        // todo: load all positions into PositionPicker
        // todo: auto set sport and position based on user info
    }

    private void OnItemSelected(object? sender, SelectionChangedEventArgs e)
    {

    }


}