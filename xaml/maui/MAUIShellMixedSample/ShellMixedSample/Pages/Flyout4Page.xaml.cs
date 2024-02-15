namespace ShellMixedSample.Pages;

public partial class Flyout4Page : ContentPage
{
	public Flyout4Page()
	{
		InitializeComponent();
	}
    private async void NavigateToMainPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///FirstPage");
    }
}