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

namespace eccube_UwpApp
{
    public sealed partial class MainPage : Page
    {
        private readonly Uri HomeUri = new Uri(@"http://demo3.ec-cube.net/");

        public MainPage()
        {
            this.InitializeComponent();

            ShowContent("");
        }

        private void ShowContent(string page)
        {
            Uri showUri = new Uri(HomeUri, page);
            webView.Source = showUri;
        }

        private void appBarButtonHome_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("");
        }

        private void appBarButtonMyPage_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("mypage");
        }

        private void appBarButtonProductList_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("products/list");
        }

        private void appBarButtonCart_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("cart");
        }

        private void appBarButtonFavorite_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("mypage/favorite");
        }
    }
}
