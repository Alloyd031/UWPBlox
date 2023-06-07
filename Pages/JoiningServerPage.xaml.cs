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
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI;

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
            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mp = contentFrame.Content as MainPage;
            Grid gridmp = mp.Content as Grid;
            Grid PagesPanel = gridmp.FindName("PagesPanel") as Grid;
            Frame ContentFrame = gridmp.FindName("ContentFrame") as Frame;
            PagesPanel.Visibility = Visibility.Collapsed;
            ContentFrame.Margin = new Thickness(0, 0, 0, 0);
            JoinServerProgress.IsIndeterminate = true;
        }
    }
}
