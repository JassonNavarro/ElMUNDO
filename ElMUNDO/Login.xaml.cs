namespace ElMUNDO;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void loginBTN_Clicked(object sender, EventArgs e)
    {
        string username = userentry.Text;
        string password = passwordentry.Text;
        if (username == "TrAndroid" && password == "12345")
        {
            await DisplayAlert("Inicio de sesi�n", "�Inicio de sesi�n exitoso!", "OK");
            await Navigation.PushAsync(new Pages.TabbedPageE());
        }
        else
        {
            await DisplayAlert("Inicio de sesi�n fallido", "Usuario o contrase�a incorrectos.", "OK");
        }
    }
}