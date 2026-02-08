namespace app_frontend.Pages.LoginPage;
using app_frontend.Pages.SignUpPage;
using app_frontend.Pages.SignInPage;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void SignUpButton_OnClicked(object? sender, EventArgs e)
    {
        // Navigate to Sign Up page
        await Navigation.PushAsync(new SignUpPage());
    }

    private async void LoginButton_OnClicked(object? sender, EventArgs e)
    {
        // Navigate to Login Input page
        await Navigation.PushAsync(new SignInPage());
    }
}