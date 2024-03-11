using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string name;
        private string password;
        private UserRolesEnum role;
        private string fNumber;
        private string email;
        private int _id;
        private DateTime expires;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
           
        }

        public string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        public UserRolesEnum Role
        {
            get { return role; }
            set { role = value; }
        }

        public string FNumber
        {
            get { return fNumber; }
            set { fNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime Expires
        {
            get { return expires; }
            set { expires = value; }
        }

    }
}
