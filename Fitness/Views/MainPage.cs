using System;

using Xamarin.Forms;

namespace Fitness
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page homePage ,itemsPage, aboutPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    homePage = new NavigationPage(new HomePage())
                    {
                        Title = "Home"
                    };

                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };
                    itemsPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    break;
                default:
                    homePage = new HomePage()
                    {
                        Title = "Home"
                    };

                    itemsPage = new ItemsPage()
                    {
                        Title = "Browse"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };
                    break;
            }

            Children.Add(homePage);
            Children.Add(itemsPage);
            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
