using roles.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace roles.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private bool isAdmin;
        private bool isUser;

        public bool IsAdmin { get => isAdmin; set => SetProperty(ref isAdmin, value); }
        public ShellViewModel()
        {
            MessagingCenter.Subscribe<LoginPage>(this, "isAdmin", (sender) =>
            {
                IsAdmin = true;
            });

            MessagingCenter.Subscribe<LoginPage>(this, "isUser", (sender) =>
            {
                IsAdmin = false;
            });
        }
    }
}