

namespace app_frontend.Pages.CoachSignUpPage;

public partial class CoachSignUpPage : ContentPage
{
    public CoachSignUpPage()
    {
        InitializeComponent();
    }

    private string firstName;
    private string lastName;
    private string zipcode;
    private string teamInfo;
    private string email;
    
    private void SaveData()
    {
        // do with this what you will
        firstName = FirstNameEntry.Text;
        lastName = LastNameEntry.Text;
        zipcode = ZipcodeEntry.Text;
        teamInfo = TeamInfoEntry.Text;
        email = EmailEntry.Text;
        checkIfDone();
    }
    
    private async void checkIfDone()
    {
       if(!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) &&
          !string.IsNullOrEmpty(zipcode) && !string.IsNullOrEmpty(teamInfo) && 
          !string.IsNullOrEmpty(email))
       {
           await Navigation.PushAsync(new CoachSignUpPage2.CoachSignUpPage2());
       }
   
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