using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_frontend.Pages.GuardianSignUpPage;

public partial class GuardianSignUpPage : ContentPage
{
    public GuardianSignUpPage()
    {
        InitializeComponent();
    }

    private void SaveData()
    {
        string firstName = FirstNameEntry.Text;
        string lastName = LastNameEntry.Text;
        string zipcode = ZipcodeEntry.Text;
        string email = EmailEntry.Text;
        string phoneNumber = PhoneNumberEntry.Text;
        
        checkIfDone(); // probably doing this backwards but it's ok
    }

    private void checkIfDone()
    {
        if (!string.IsNullOrEmpty(FirstNameEntry.Text) &&
            !string.IsNullOrEmpty(LastNameEntry.Text) &&
            !string.IsNullOrEmpty(ZipcodeEntry.Text) &&
            !string.IsNullOrEmpty(EmailEntry.Text) &&
            !string.IsNullOrEmpty(PhoneNumberEntry.Text))
        {
            return; // implement go to next screen
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

    private void EmailEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void PhoneNumberEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }
}