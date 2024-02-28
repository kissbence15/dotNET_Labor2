namespace Labor2;

public partial class Feladat2Page : ContentPage
{
	public Feladat2Page()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Feladat1Page");
    }
}