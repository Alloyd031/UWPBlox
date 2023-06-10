using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPBlox.GamesPages.WinSimulatorPages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Диалоговое окно содержимого" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPBlox.Dialogs
{
    public sealed partial class LogOut : ContentDialog
    {
        public LogOut()
        {
            this.InitializeComponent();
        }
        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mp = contentFrame.Content as MainPage;
            Grid gridmp = mp.Content as Grid;
            Grid PagesPanel = gridmp.FindName("PagesPanel") as Grid;
            Frame ContentFrame = gridmp.FindName("ContentFrame") as Frame;
            PagesPanel.Visibility = Visibility.Collapsed;
            ContentFrame.Margin = new Thickness(0, 0, 0, 0);
            ContentFrame.Navigate(typeof(Welcome));
            Hide();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
