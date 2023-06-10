using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPBlox.Pages
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Continue : Page
    {
        public Continue()
        {
            this.InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
        private void SomeCoolGameInfo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GameInfo));

            GameInfo GameInfo = Frame.Content as GameInfo;
            if (GameInfo != null)
            {
                FontIcon GameIcon = GameInfo.FindName("GameIcon") as FontIcon;
                TextBlock GameName = GameInfo.FindName("GameName") as TextBlock;
                TextBlock GameDescription = GameInfo.FindName("GameDescription") as TextBlock;
                GameName.Text = "Some Cool Game :3";
                GameIcon.Glyph = "\uE7FC";
                GameDescription.Text = "Just a cool game, what else? :3";
            }
        }
        private void WinSimulatorInfo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GameInfo));

            GameInfo GameInfo = Frame.Content as GameInfo;
            if (GameInfo != null)
            {
                FontIcon GameIcon = GameInfo.FindName("GameIcon") as FontIcon;
                TextBlock GameName = GameInfo.FindName("GameName") as TextBlock;
                TextBlock GameDescription = GameInfo.FindName("GameDescription") as TextBlock;
                GameName.Text = "WinSimulator";
                GameIcon.Glyph = "\uEC4E";
                GameDescription.Text = "Simulate your favorite OS!";
            }
        }
    }
}
