using app_backend.Services.Classes;
using app_backend.Services.Interfaces;
using app_shared.Enums;

namespace app_frontend.Pages.HomePage;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;

    }

}