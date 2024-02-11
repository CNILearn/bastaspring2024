using Microsoft.UI.Xaml.Controls;

using TemplateStudioWinUI.ViewModels;

namespace TemplateStudioWinUI.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
