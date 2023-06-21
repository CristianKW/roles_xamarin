using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace roles.Models
{
    internal interface IAuthenticationService
    {
        Task<bool> Login(string username, string password);
        Task Logout();
        bool IsUserLoggedIn();
        UserRole GetUserRole();
    }
}
