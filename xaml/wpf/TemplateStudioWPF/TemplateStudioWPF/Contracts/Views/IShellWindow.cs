using System.Windows.Controls;

namespace TemplateStudioWPF.Contracts.Views;

public interface IShellWindow
{
    Frame GetNavigationFrame();

    void ShowWindow();

    void CloseWindow();
}
