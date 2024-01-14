using IFridge;

namespace IFridge;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

	}
    private void LogInButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}