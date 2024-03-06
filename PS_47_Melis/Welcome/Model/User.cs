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

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public bool VerifyPassword(string inputPassword)
        {
            string inputHash = HashPassword(inputPassword);
            return password.Equals(inputHash);
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
