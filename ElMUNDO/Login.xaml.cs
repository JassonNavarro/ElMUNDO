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
        if (username == "Bryan" && password == "123")
        {
            await DisplayAlert("Inicio de sesión", "¡Inicio de sesión exitoso!", "OK");
            await Navigation.PushAsync(new Pages.TabbedPageE());
        }
        else
        {
            await DisplayAlert("Inicio de sesión fallido", "Usuario o contraseña incorrectos.", "OK");
        }
    }
}