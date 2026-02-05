namespace app_frontend.Pages.SignUpPage;
using app_frontend.Pages.AthleteSignupPage;
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

    private void ParentGuardianButton_OnClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void CoachOrgButton_OnClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}