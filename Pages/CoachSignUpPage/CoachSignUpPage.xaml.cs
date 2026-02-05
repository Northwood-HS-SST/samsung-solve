

namespace app_frontend.Pages.CoachSignUpPage;

public partial class CoachSignUpPage : ContentPage
{
    public CoachSignUpPage()
    {
        InitializeComponent();
    }

    private void SaveData()
    {
        // do with this what you will
        string firstName = FirstNameEntry.Text;
        string lastName = LastNameEntry.Text;
        string zipcode = ZipcodeEntry.Text;
        string teamInfo = TeamInfoEntry.Text;
        string email = EmailEntry.Text;
    }

    private void FirstNameEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void LastNameEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void ZipcodeEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void TeamInfoEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void EmailEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }

}