
namespace app_frontend.Pages.AthleteSignupPage;
using app_frontend.Pages.AthleteUnder13SignupPage;

public partial class AthleteSignupPage : ContentPage
    {
        public AthleteSignupPage()
        {
            InitializeComponent();
        }

        private async void Under13Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AthleteUnder13SignupPage());
        }
        
        private void SaveData()
        {
            // do with this what you will
            string firstName = FirstNameEntry.Text;
            string lastName = LastNameEntry.Text;
            string zipcode = ZipcodeEntry.Text;
            string birthday = BirthdayEntry.Text;
            string sport = SportEntry.Text;
            string position = PositionPicker.SelectedItem?.ToString() ?? string.Empty;
            string email = EmailEntry.Text;
        }
        
        private void SportEntry_TextChanged(object sender, TextChangedEventArgs e)
        {   
            SaveData();
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                populatePicker(e.NewTextValue);
            }
        }

        private void populatePicker(string sport)
        {
            List<string> basketballPositions = new List<string> { "Point Guard", "Shooting Guard", "Small Forward", "Center", "Power Forward" };
            List<string> volleyballPositions = new List<string> {"Setter", "Outside Hitter Left", "Middle Blocker", "Libero", "Opposite Hitter", "Serving Specalist" };
            List<string> softballPositions = new List<string> { "Pitcher", "Catcher", "First Base", "Second Base", "Third Base", "Shortstop", "Left Fielder", "Center Fielder", "Right Fielder", "Outfielder" };
            List<string> soccerPositions = new List<string> { "Goalkeeper", "Defense", "Midfielder", "Forward", "Center Midfield", "Defense Midfield", "Attacking Midfield", "Wide Midfield", "Striker", "Left Wing", "Right Wing", "Center-Backs", "Sweeper", "Fullback Left", "Fullback Right", "Wing-Backs" }; // why does soccer have so many positons

            if (sport.ToLower() == "soccer")
            {
                PositionPicker.ItemsSource = soccerPositions;
            }
            else if (sport.ToLower() == "basketball")
            {
                PositionPicker.ItemsSource = basketballPositions;
            }
            else if (sport.ToLower() == "volleyball")
            {
                PositionPicker.ItemsSource = volleyballPositions;
            }
            else if (sport.ToLower() == "softball")
            {
                PositionPicker.ItemsSource = softballPositions;
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

        private void BirthdayEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
        {
            SaveData();
        }

        private void PositionPicker_OnSelectedIndexChanged(object? sender, EventArgs e)
        {
            SaveData();
        }

        private void EmailEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
        {
            SaveData();
        }
    }