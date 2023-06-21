using roles.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace roles.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private bool isUserLoggedIn = false;
        private UserRole userRole = UserRole.RegularUser;

        public async Task<bool> Login(string username, string password)
        {
            // Lógica de autenticación
            // ...

            // Ejemplo básico: establecer el estado de autenticación como verdadero si la autenticación es exitosa
            if (username == "usuario" && password == "contraseña")
            {
                isUserLoggedIn = true;
                userRole = UserRole.RegularUser;
            }
            else if (username == "admin" && password == "admin123")
            {
                isUserLoggedIn = true;
                userRole = UserRole.Admin;
            }

            return isUserLoggedIn;
        }

        public async Task Logout()
        {
            // Realizar acciones de cierre de sesión, como limpiar el estado de autenticación
            isUserLoggedIn = false;
            userRole = UserRole.RegularUser;
        }

        public bool IsUserLoggedIn()
        {
            return isUserLoggedIn;
        }

        public UserRole GetUserRole()
        {
            return userRole;
        }
    }
}
