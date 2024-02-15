using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SelectedAvaloniaFeatures.ViewModels;

public partial class BindingViewModel : ViewModelBase
{
    [ObservableProperty]
    private int _count;

    public void IncreaseCount() =>
        Count++;

    public void DecreaseCount() =>
        Count--;

    [RelayCommand]
    public void IncreaseCountV2() =>
        Count++;

    [RelayCommand]
    public void DecreaseCountV2() =>
        Count--;
}
