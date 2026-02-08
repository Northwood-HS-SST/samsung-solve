namespace app_frontend.Pages.UserInfoSignUpPage;
public partial class UserInfoSignUpPage : ContentPage
{
    public UserInfoSignUpPage()
    {
        InitializeComponent();
    }

    private void SportPicker_OnSelectedIndexChanged(object? sender, EventArgs e)
    {
    }

    private async void ContinueButton_OnClicked(object? sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
    }
}