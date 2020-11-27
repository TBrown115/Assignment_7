using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new TabbedPage1());
            navPage.BarBackgroundColor = Color.FromHex("075E54");

            MainPage = navPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

