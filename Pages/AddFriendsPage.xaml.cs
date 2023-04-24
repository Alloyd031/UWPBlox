using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPBlox.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddFriendsPage : Page
    {
        public AddFriendsPage()
        {
            this.InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mp = contentFrame.Content as MainPage;
            Grid grid = mp.Content as Grid;
            Grid PagesPanel = grid.FindName("PagesPanel") as Grid;
            Frame ContentFrame = grid.FindName("ContentFrame") as Frame;
            PagesPanel.Visibility = Visibility.Visible;
            ContentFrame.Margin = new Thickness(64, 0, 0, 0);
            this.Frame.GoBack();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mp = contentFrame.Content as MainPage;
            Grid grid = mp.Content as Grid;
            Grid PagesPanel = grid.FindName("PagesPanel") as Grid;
            Frame ContentFrame = grid.FindName("ContentFrame") as Frame;
            PagesPanel.Visibility = Visibility.Collapsed;
            ContentFrame.Margin = new Thickness(0, 0, 0, 0);
        }
    }
}
