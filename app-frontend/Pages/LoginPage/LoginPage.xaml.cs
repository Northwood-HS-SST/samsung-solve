using app_backend.DTOs;
using app_backend.Services.Classes;
using app_frontend.Pages.ProfilePage;

namespace app_frontend.Pages.LoginPage;

public partial class LoginPage : ContentPage
{
	public LoginPage(ProfilePageViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }

    private bool emailBox_ready = false;
    private bool passwordBox_ready = false;


    private void UpdateLoginPage()
    {
        // login button only works if the email and password arent empty
        LoginButton.IsEnabled = emailBox_ready && passwordBox_ready;
        ErrorLabel.IsVisible = false;
    }

    private void EmailBox_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        // ensures that the text has no spaces
        if (!string.IsNullOrEmpty(e.NewTextValue) && e.NewTextValue.Contains(" "))
        {
            (sender as Entry).Text = e.NewTextValue.Replace(" ", "");
        }

        // todo: check to make sure it's an email and not just random text
        emailBox_ready = e.NewTextValue.Length != 0;
        UpdateLoginPage();
    }

    private void PassBox_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        // ensures that the text has no spaces
        if (!string.IsNullOrEmpty(e.NewTextValue) && e.NewTextValue.Contains(" "))
        {
            (sender as Entry).Text = e.NewTextValue.Replace(" ", "");
        }

        passwordBox_ready = e.NewTextValue.Length != 0;
        UpdateLoginPage();
    }

    private async void LoginButton_OnClicked(object? sender, EventArgs e)
    {
        // disable inputs while logging in
        PassBox.IsEnabled = false;
        EmailBox.IsEnabled = false;
        LoginButton.IsEnabled = false;
        LoginActivity.IsRunning = true;

        // actually log in
        var authService = IPlatformApplication.Current.Services.GetService<AuthService>();
        var result = await authService.LoginAsync(new LoginRequestDto { email = EmailBox.Text, password = PassBox.Text });
        LoginActivity.IsRunning = false;

        if (result.response != null)
        {
            // if succcessfully logged in, go to main app
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            // if not successfully logged in, enable inputs and try again
            PassBox.IsEnabled = true;
            EmailBox.IsEnabled = true;
            LoginButton.IsEnabled = true;

            ErrorLabel.Text = result.error;
            ErrorLabel.IsVisible = true;
        }
    }
}