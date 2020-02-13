using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinHomework1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            //MainPage = new AppPage();
            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new SignUpPage();
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
