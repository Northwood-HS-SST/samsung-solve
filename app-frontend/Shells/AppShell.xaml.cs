using app_frontend.Pages.LoginPage;
using app_frontend.Pages.SearchPage;

namespace app_frontend
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // if you want to be able to go a specific page, you MUST register a route here
            Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));


        }

    }
}
