// See https://aka.ms/new-console-template for more information
using System;
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using Welcome.View;
using DataLayer.Database;
using DataLayer.Model;

namespace DataLayer
{

    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Name = "Melis",
                    Password = "1234",
                    Expires = DateTime.Now,
                    Role = UserRolesEnum.STUDENT

                }) ;
                context.SaveChanges();
                var users = context.Users.ToList();

                Console.WriteLine("Enter name: ");
                string enteredName = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string enteredPassword = Console.ReadLine();

                var isValidUser = context.Users.Any(user =>
                user.Name.Equals(enteredName, StringComparison.OrdinalIgnoreCase) &&
                user.Password == enteredPassword);

                if (isValidUser)
                {
                    Console.WriteLine("Valid user!");
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }


                Console.ReadKey();

            }

        }
    }
}
