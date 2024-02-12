using System.Windows.Controls;

namespace TemplateStudioWPF.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
