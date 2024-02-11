using System.Windows.Controls;

using TemplateStudioWPF.ViewModels;

namespace TemplateStudioWPF.Views;

public partial class ListDetailsPage : Page
{
    public ListDetailsPage(ListDetailsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
