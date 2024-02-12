using System.Windows.Controls;

using TemplateStudioWPF.ViewModels;

namespace TemplateStudioWPF.Views;

public partial class DataGridPage : Page
{
    public DataGridPage(DataGridViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
