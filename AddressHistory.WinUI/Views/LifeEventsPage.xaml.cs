using AddressHistory.WinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AddressHistory.WinUI.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class LifeEventsPage : Page
{
    public LifeEventsViewModel ViewModel
    {
        get;
    }

    public LifeEventsPage()
    {
        ViewModel = App.GetService<LifeEventsViewModel>();
        InitializeComponent();
    }
}
