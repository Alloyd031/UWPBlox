using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPBlox.Dialogs;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPBlox.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class JoiningServerPage : Page
    {
        public JoiningServerPage()
        {
            this.InitializeComponent();
        }
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mp = contentFrame.Content as MainPage;
            Grid grid = mp.Content as Grid;
            Grid PagesPanel = grid.FindName("PagesPanel") as Grid;
            Frame ContentFrame = grid.FindName("ContentFrame") as Frame;
            PagesPanel.Visibility = Visibility.Collapsed;
            ContentFrame.Margin = new Thickness(0, 0, 0, 0);

            JoinServerProgress.IsIndeterminate = true;
            await Task.Delay(5000);
            ErrorDialog dialog = new ErrorDialog();
            await dialog.ShowAsync();
            this.Frame.GoBack();
            PagesPanel.Visibility = Visibility.Visible;
            ContentFrame.Margin = new Thickness(64, 0, 0, 0);
        }
    }
}
