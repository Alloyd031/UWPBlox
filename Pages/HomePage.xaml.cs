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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPBlox.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }
        private void AddFriends_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddFriendsPage));
        }
        private void PlayCoolGameButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(JoiningServerPage));

            JoiningServerPage JoinServerPage = Frame.Content as JoiningServerPage;
            if (JoinServerPage != null)
            {
                FontIcon GameIcon = JoinServerPage.FindName("GameIcon") as FontIcon;
                TextBlock GameName = JoinServerPage.FindName("GameName") as TextBlock;
                GameName.Text = "Some Cool Game :3";
                GameIcon.Glyph = "\uE7FC";
            }
        }
        private void PlayWinSimulatorButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(JoiningServerPage));

            JoiningServerPage JoinServerPage = Frame.Content as JoiningServerPage;
            if(JoinServerPage != null)
            {
                FontIcon GameIcon = JoinServerPage.FindName("GameIcon") as FontIcon;
                TextBlock GameName = JoinServerPage.FindName("GameName") as TextBlock;
                GameName.Text = "WinSimulator";
                GameIcon.Glyph = "\uEC4E";
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
    }
}
