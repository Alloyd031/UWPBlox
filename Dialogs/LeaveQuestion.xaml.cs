using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPBlox.GamesPages;
using UWPBlox.Pages;
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
    public sealed partial class LeaveQuestion : ContentDialog
    {
        public LeaveQuestion()
        {
            this.InitializeComponent();
        }
        private async void Resume_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Menu dialog = new Menu();
            await dialog.ShowAsync();
        }
        private void Leave_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mp = contentFrame.Content as MainPage;
            Grid gridmp = mp.Content as Grid;
            Grid PagesPanel = gridmp.FindName("PagesPanel") as Grid;
            Frame ContentFrame = gridmp.FindName("ContentFrame") as Frame;
            PagesPanel.Visibility = Visibility.Visible;
            ContentFrame.Margin = new Thickness(64, 0, 0, 0);
            ContentFrame.Navigate(typeof(HomePage));
        }
    }
}
