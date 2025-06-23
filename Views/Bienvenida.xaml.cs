namespace Veterinaria.Views;

public partial class Bienvenida : ContentPage
{
	public Bienvenida()
	{
		InitializeComponent();
	}

    private async void onClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Bienvenida());
    }
}