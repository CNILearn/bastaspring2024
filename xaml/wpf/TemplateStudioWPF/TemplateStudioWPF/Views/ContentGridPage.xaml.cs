using System.Windows.Controls;

using TemplateStudioWPF.ViewModels;

namespace TemplateStudioWPF.Views;

public partial class ContentGridPage : Page
{
    public ContentGridPage(ContentGridViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
