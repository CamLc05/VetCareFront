namespace Veterinaria;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void onClick(object sender, EventArgs e)
	{
		var boton = (Button)sender;
		boton.BackgroundColor = Color.FromArgb("#899878");
		
		Application.Current.MainPage = new AppShell();


    }
}