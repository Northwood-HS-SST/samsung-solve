using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_frontend.Pages.AthleteUnder13SignupPage;

public partial class AthleteUnder13SignupPage : ContentPage
{
    public AthleteUnder13SignupPage()
    {
        InitializeComponent();
    }

    private void SaveData()
    {
        string fullName = FullNameEntry?.Text ?? string.Empty;
        string parentPhone = ParentPhoneNumberEntry?.Text ?? string.Empty;
        string parentEmail = ParentEmailEntry?.Text ?? string.Empty;
        // Save the data to a database or file
    }

    private void FullNameEntry_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void ParentPhoneNumberEntry_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void ParentEmailEntry_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        SaveData();
    }
}
