namespace app_frontend.Pages.SignUpPage;
using app_frontend.Pages.AthleteSignupPage;
using app_frontend.Pages.GuardianSignUpPage;
using app_frontend.Pages.CoachSignUpPage;
public partial class SignUpPage : ContentPage
{
    public SignUpPage()
    {
        InitializeComponent();
    }
    

    private async void AthleteButton_OnClicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new AthleteSignupPage());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Navigation failed: {ex.Message}", "OK");
        }
    }

    private async void ParentGuardianButton_OnClicked(object? sender, EventArgs e)
    {
       await Navigation.PushAsync(new GuardianSignUpPage());
    }

    private async void CoachOrgButton_OnClicked(object? sender, EventArgs e)
    {
       await Navigation.PushAsync(new CoachSignUpPage());
    }
}