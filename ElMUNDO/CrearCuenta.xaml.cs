namespace ElMUNDO;

public partial class CrearCuenta : ContentPage
{
    private readonly SQLiteLogin.DatabaseHelper _databaseHelper;
    public CrearCuenta()
	{
		InitializeComponent();
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "users.db");
        _databaseHelper = new SQLiteLogin.DatabaseHelper(dbPath);

    }

    private async void registrarBTN_Clicked(object sender, EventArgs e)
    {
        string username = userentry.Text;
        string password = passwordentry.Text;

        var existingUser = await _databaseHelper.GetUserAsync(username);
        if (existingUser != null)
        {
            await DisplayAlert("Error", "Username already exists", "OK");
            return;
        }

        var newUser = new SQLiteLogin.User { Username = username, Password = password };
        await _databaseHelper.SaveUserAsync(newUser);
        await DisplayAlert("Success", "User registered successfully!", "OK");
        await Navigation.PushAsync(new Login());
    }
}