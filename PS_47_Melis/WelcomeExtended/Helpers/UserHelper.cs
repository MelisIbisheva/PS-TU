using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    static class UserHelper
    {
        public static string ToString(this User user)
        {
            return $"User name: {user.Name}\n" +
                $"Faculty number: {user.FNumber}\n" +
                $"Role: {user.Role}\n" +
                $"Email: {user.Email}\n" +
                $"Active status: {user.Expires}";
        }

        public static bool ValidateCredentials(this UserData userData, string name, string password)
        {
            if (name == null)
            {
                throw new Exception($"The name field cannot be empty");
            }
            else if (password == null)
            {
                throw new Exception($"The password field cannot be empty");
            }
            else
            {

                return userData.ValidateUser(name, password);
            }
        }

        public static User GetUser(this UserData userData, string name, string password) {
           return userData.GetUser(name, password);

        }
    }
}
