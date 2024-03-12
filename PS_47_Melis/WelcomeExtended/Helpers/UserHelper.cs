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
    public static class UserHelper
    {
        public static string ToString(this User user)
        {
            return $"User name: {user.Name}\n" +
                $"User password: {user.Password}\n" +
                $"Faculty number: {user.Role}\n" +
                $"Role: {user.FNumber}\n" +
                $"Email: {user.Email}\n" +
                $"Expires: {user.Expires.ToString()}";
        }

        public static bool ValidateCredentials(this UserData userData, string name, string password)
        {
            if (name == null || name == "")
            {
                throw new Exception($"The name cannot be empty");
            }
            else if (password == null || name=="")
            {
                throw new Exception($"The password cannot be empty");
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
