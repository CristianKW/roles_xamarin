using roles.Models;
using roles.Services;
using roles.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace roles
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<IAuthenticationService, AuthenticationService>();
            MainPage = new AppShell();
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
