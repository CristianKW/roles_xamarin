using roles.Models;
using roles.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Xamarin.Forms;

namespace roles.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        IAuthenticationService authService = DependencyService.Get<IAuthenticationService>();
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await authService.Login("admin", "admin123");
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
