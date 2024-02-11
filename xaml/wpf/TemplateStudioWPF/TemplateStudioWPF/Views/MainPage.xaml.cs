using System.Windows.Controls;

using TemplateStudioWPF.ViewModels;

namespace TemplateStudioWPF.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
