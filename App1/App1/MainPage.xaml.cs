namespace App1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void onstartclicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
