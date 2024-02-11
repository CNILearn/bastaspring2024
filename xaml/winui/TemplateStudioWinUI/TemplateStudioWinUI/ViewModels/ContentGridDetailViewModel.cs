﻿using CommunityToolkit.Mvvm.ComponentModel;

using TemplateStudioWinUI.Contracts.ViewModels;
using TemplateStudioWinUI.Core.Contracts.Services;
using TemplateStudioWinUI.Core.Models;

namespace TemplateStudioWinUI.ViewModels;

public partial class ContentGridDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public ContentGridDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
