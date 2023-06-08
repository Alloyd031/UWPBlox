using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPBlox.Pages;
using UWPBlox.Dialogs;
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPBlox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonForegroundColor = Colors.White;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveForegroundColor = Colors.Gray;
            titleBar.ButtonHoverBackgroundColor = Colors.DarkGray;
            titleBar.ButtonHoverForegroundColor = Colors.White;
            titleBar.ButtonPressedBackgroundColor = Colors.Black;
            titleBar.ButtonPressedForegroundColor = Colors.DarkGray;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(HomePage));
        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(HomePage));
        }
        private void DiscoverButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(DiscoverPage));
        }
        private void AvatarButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(AvatarPage));
        }
        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(ConnectPage));
        }
        private void MoreButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(MorePage));
        }
    }
}
