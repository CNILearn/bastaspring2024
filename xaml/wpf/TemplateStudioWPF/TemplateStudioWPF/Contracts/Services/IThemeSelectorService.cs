using TemplateStudioWPF.Models;

namespace TemplateStudioWPF.Contracts.Services;

public interface IThemeSelectorService
{
    void InitializeTheme();

    void SetTheme(AppTheme theme);

    AppTheme GetCurrentTheme();
}
