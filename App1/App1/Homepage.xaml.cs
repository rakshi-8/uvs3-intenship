namespace App1;

public partial class Homepage : ContentPage
{
	public Homepage()
	{
		InitializeComponent();
	}
	private async void GoProfile(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new ProfilePage());
	}
	private async void GoWork (object sender,EventArgs e)
	{
		await Navigation.PushAsync(new WorkPage());
	}
}