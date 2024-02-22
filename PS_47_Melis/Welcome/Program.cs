using System;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Name = "Mel";
            user1.Password = "123";

            user1.Role = Others.UserRolesEnum.STUDENT;
            user1.FNumber = "121221011";
            user1.Email = "mel@gmail.com";

            // Пример за проверка на парола
            string inputPassword = "123";
            bool isPasswordValid = user1.VerifyPassword(inputPassword);

            Console.WriteLine("Valid password: " + isPasswordValid);

            UserViewModel uVM = new UserViewModel(user1);
            UserView userV = new UserView(uVM);
            userV.Display();
            Console.ReadKey();
        }
    }
}
