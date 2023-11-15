using AddressHistory.WinUI.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace AddressHistory.WinUI.Views;

public sealed partial class LifeEventsDetailsPage : Page
{
    public LifeEventsDetailsViewModel ViewModel
    {
        get;
    }

    public LifeEventsDetailsPage()
    {
        ViewModel = App.GetService<LifeEventsDetailsViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
