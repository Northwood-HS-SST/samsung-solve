namespace app_frontend.Pages.ProfilePage;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfilePageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void OnItemSelected(object? sender, SelectionChangedEventArgs e)
    {

    }
}