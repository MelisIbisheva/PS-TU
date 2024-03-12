// See https://aka.ms/new-console-template for more information
using System;
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using Welcome.View;
using DataLayer.Database;
using DataLayer.Model;
using Microsoft.Extensions.Logging;
using DataLayer.Helpers;

namespace DataLayer
{

    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                ILogger logger = LoggerHelper.GetDbLogger("db");
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Name = "Maria",
                    Password = "1234",
                    Role = UserRolesEnum.STUDENT,
                    FNumber = "121221039",
                    Email = "maria12@gmail.com",
                    Expires = DateTime.Now.AddYears(2)

                }) ;
                context.SaveChanges();
                var users = context.Users.ToList();

                Console.WriteLine("Enter name: ");
                string enteredName = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string enteredPassword = Console.ReadLine();

                Console.WriteLine($"{enteredName} {enteredPassword}");
                var usss = context.Users.Where(x => x.Name == enteredName).Where(x => x.Password == enteredPassword).FirstOrDefault();

                if (usss != null)
                {
                    Console.WriteLine("Valid data");
                }
                else
                {
                    Console.WriteLine("Invalid data");
                }


                while (true)
                {
                    Console.WriteLine("Chose:");
                    Console.WriteLine("1: All");
                    Console.WriteLine("2: Add");
                    Console.WriteLine("3: Del");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            var allUsers = context.Users.ToList();
                            foreach (var sUser in allUsers)
                            {
                                Console.WriteLine(sUser.Name);
                            }
                            logger.LogInformation("listed users");
                            break;

                        case 2:
                            Console.WriteLine("Username:");
                            string addUname = Console.ReadLine();
                            Console.WriteLine("Password:");
                            string addPass = Console.ReadLine();
                            Console.WriteLine("FNumber:");
                            string fNum = Console.ReadLine();
                            Console.WriteLine("Email:");
                            string email = Console.ReadLine();

                            context.Add<DatabaseUser>(new DatabaseUser()
                            {
                                Name = addUname,
                                Password = addPass,
                                Role = UserRolesEnum.STUDENT,
                                FNumber = fNum,
                                Email = email,
                                Expires = DateTime.UtcNow
                            });
                            context.SaveChanges();
                            logger.LogInformation("added user");
                            break;
                        case 3:
                            Console.WriteLine("Username:");
                            string rUname = Console.ReadLine();
                            context.Remove<DatabaseUser>(context.Users.Where(x => x.Name == rUname).First());
                            context.SaveChanges();
                            logger.LogInformation("deleted user");
                            break;
                        case 4:
                            var allLogs = context.Logs.ToList();
                            foreach (var log in allLogs)
                            {
                                Console.WriteLine(log.Message);
                            }
                            logger.LogInformation("listed logs");
                            break;
                    }
                }

                

            }

        }
    }
}
