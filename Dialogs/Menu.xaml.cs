using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPBlox.MenuPages;
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
    public sealed partial class Menu : ContentDialog
    {
        public Menu()
        {
            this.InitializeComponent();
        }
        private void Resume_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private async void Leave_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            LeaveQuestion dialog = new LeaveQuestion();
            await dialog.ShowAsync();
        }
        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(People));
        }
        private void People_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(People));
        }
        private async void ResetCharacter_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            ResetQuestion dialog = new ResetQuestion();
            await dialog.ShowAsync();
        }
    }
}
