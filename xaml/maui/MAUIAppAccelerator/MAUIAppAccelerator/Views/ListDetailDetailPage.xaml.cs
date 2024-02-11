namespace MAUIAppAccelerator.Views;

public partial class ListDetailDetailPage : ContentPage
{
	public ListDetailDetailPage(ListDetailDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
