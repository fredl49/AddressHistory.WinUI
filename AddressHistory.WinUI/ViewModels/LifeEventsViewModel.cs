using System.Collections.ObjectModel;

using AddressHistory.WinUI.Contracts.ViewModels;
using AddressHistory.WinUI.Core.Contracts.Services;
using AddressHistory.WinUI.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace AddressHistory.WinUI.ViewModels;

public partial class LifeEventsViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public LifeEventsViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
