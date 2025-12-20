using app_frontend.Pages.TestPage;

namespace app_frontend
{
    public partial class TestPage : ContentPage
    {
        public TestPage(TestPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

    }
}
