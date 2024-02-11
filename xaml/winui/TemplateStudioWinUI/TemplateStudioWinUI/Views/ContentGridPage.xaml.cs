using Microsoft.UI.Xaml.Controls;

using TemplateStudioWinUI.ViewModels;

namespace TemplateStudioWinUI.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
