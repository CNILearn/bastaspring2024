using System.Windows.Controls;

using TemplateStudioWPF.ViewModels;

namespace TemplateStudioWPF.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
