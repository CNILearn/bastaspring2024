namespace ShellMixedSample.Pages;

public partial class Flyout3Page : ContentPage
{
	public Flyout3Page()
	{
		InitializeComponent();
	}

    private async void NavigateToMainPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///FirstPage");
    }
}