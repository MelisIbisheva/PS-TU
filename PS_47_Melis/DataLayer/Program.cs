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
                    Name = "user",
                    Password = "password",
                    Expires = DateTime.Now,
                    Role = UserRolesEnum.STUDENT

                }) ;
                context.SaveChanges();
                var users = context.Users.ToList();
                Console.ReadKey();

            }
        }
    }
}
