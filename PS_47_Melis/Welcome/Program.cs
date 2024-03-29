﻿using System;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Name = "Mel";
            user1.Password = "123";

            user1.Role = UserRolesEnum.STUDENT;
            user1.FNumber = "121221011";
            user1.Email = "mel@gmail.com";

            UserViewModel uVM = new UserViewModel(user1);
            UserView userV = new UserView(uVM);
            userV.Display();
            Console.ReadKey();
        }
    }
}
