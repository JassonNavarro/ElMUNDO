namespace ElMUNDO;

public partial class Login : ContentPage
{
    private readonly SQLiteLogin.DatabaseHelper _databaseHelper;
    public Login()
	{
		InitializeComponent();
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "users.db");
        _databaseHelper = new SQLiteLogin.DatabaseHelper(dbPath);

    }

    private async void loginBTN_Clicked(object sender, EventArgs e)
    {
        string username = userentry.Text;
        string password = passwordentry.Text;

        var user = await _databaseHelper.GetUserAsync(username);
        if (user != null && user.Password == password)
        {
            await DisplayAlert("Success", "Login successful!", "OK");
            await Navigation.PushAsync(new Pages.TabbedPageE());
        }
        else
        {
            await DisplayAlert("Error", "Invalid username or password", "OK");
        }
    }

    private  void registrarBTN_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CrearCuenta());
    }
}