using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_frontend.Pages.CoachSignUpPage2;

public partial class CoachSignUpPage2 : ContentPage
{
    public CoachSignUpPage2()
    {
        InitializeComponent();
    }

    private string time;
    private string positionNeeded;
    private string teamName;

    private void SaveData()
    {
        time = TimeEntry.Text;
        positionNeeded = PositionNeededEntry.Text;
        teamName = TeamNameEntry.Text;
    }

    private void TimeEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void PositionNeededEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }

    private void TeamNameEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        SaveData();
    }
}