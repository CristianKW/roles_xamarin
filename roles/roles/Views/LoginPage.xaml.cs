using roles.Models;
using roles.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace roles.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        IAuthenticationService authService = DependencyService.Get<IAuthenticationService>();
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        public async void btnLogin(object sender, EventArgs e)
        {
            await authService.Login("admin", "admin123");

            if (authService.IsUserLoggedIn() && authService.GetUserRole() == UserRole.Admin)
            {
                MessagingCenter.Send<LoginPage>(this, "isAdmin");
            } else if (authService.IsUserLoggedIn() && authService.GetUserRole() == UserRole.RegularUser)
            {
                MessagingCenter.Send<LoginPage>(this, "isUser");
            }

            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}