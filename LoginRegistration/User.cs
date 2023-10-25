using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Login_Registration.Wpf
{
    class User
    {
        private string login;
        private string password;
        private string confirmPassword;

        public User() { }
        public User(string login, string password, string confirmPassword)
        {
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        public string Login 
        {
            set 
            {
                if (IsLoggIn(value)) 
                {
                    login = value;
                    return;
                }
                throw new InvalidOperationException("Incorrect login");
            }
            get 
            {
                return login;
            }
        }
        public string Password
        {
            set
            {
                if (IsPassword(value)) 
                {
                    password = value;
                }
                else
                    throw new InvalidOperationException("Incorrect password\nThe password should be kept from 8 to 15 characters");
            }
            get
            {
                return password;
            }
        }
        public string ConfirmPassword
        {
            set
            {
                if (IsPassword(value))
                {
                    confirmPassword = value;
                }
                if (password != confirmPassword )
                {
                    throw new InvalidOperationException("Passwords do not match");
                }
            }
            get
            {
                return confirmPassword;
            }
        }

        private bool IsLoggIn(string inputLogin) 
        {
            Regex isLoginRegex = new("^([A-Za-z][A-Za-z0-9]{4,9})$");
            return isLoginRegex.IsMatch(inputLogin);
        }
        private bool IsPassword(string inputPassword)
        {
            Regex isPasswordRegex = new("^([A-Za-z0-9]{8,14})$");
            return isPasswordRegex.IsMatch(inputPassword);
        }

    }
}
