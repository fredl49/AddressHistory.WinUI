using AddressHistory.WinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AddressHistory.WinUI.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class WebView2Page : Page
{
    public WebView2ViewModel ViewModel
    {
        get;
    }

    public WebView2Page()
    {
        ViewModel = App.GetService<WebView2ViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
