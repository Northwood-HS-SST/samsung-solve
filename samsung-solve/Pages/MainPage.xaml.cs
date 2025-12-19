using samsung_solve.Models;
using samsung_solve.PageModels;

namespace samsung_solve.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}