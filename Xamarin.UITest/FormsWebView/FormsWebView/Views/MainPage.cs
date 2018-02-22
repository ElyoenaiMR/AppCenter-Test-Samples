using System;
using FormsWebView.Views;
using Xamarin.Forms;

namespace FormsWebView
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page itemsPage, aboutPage, webviewPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };

                    webviewPage = new NavigationPage(new WebViewPage())
                    {
                        Title = "WebViewPage"
                    };

                    itemsPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    webviewPage.Icon = "tab_feed.png";
                    break;
                
                
                default:
                    itemsPage = new ItemsPage()
                    {
                        Title = "Browse"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };

                    webviewPage = new WebViewPage()
                    {
                        Title = "WebViewPage"
                    };

                    break;
            }

            Children.Add(itemsPage);
            Children.Add(aboutPage);
            Children.Add(webviewPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
