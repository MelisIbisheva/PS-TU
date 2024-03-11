// See https://aka.ms/new-console-template for more information
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using Welcome.View;
using static WelcomeExtended.Others.Delegates;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;

namespace WelcomeExtended
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            try
            {
                UserData userData = new UserData();

                User studentUser = new User()
                {
                    Name = "Student",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };
                userData.AddUser(studentUser);

                User studentUser2 = new User()
                {
                    Name = "Student2",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };
                userData.AddUser(studentUser2);

                User teacherUser = new User()
                {
                    Name = "Teacher",
                    Password = "1234",
                    Role = UserRolesEnum.PROFESSOR,
                    Expires = DateTime.Now.AddDays(1)
                    
                };
                userData.AddUser(teacherUser);

                User adminUser = new User()
                {
                    Name = "Admin",
                    Password = "12345",
                    Role = UserRolesEnum.ADMIN
                };
                userData.AddUser(adminUser);

                Console.Write("Enter name: ");
                var name = Console.ReadLine();
                Console.Write("Enter password: ");
                var password = Console.ReadLine();

                bool existUser = UserHelper.ValidateCredentials(userData, name, password);
                User user1 = UserHelper.GetUser(userData, name, password);
               

                if (existUser)
                {
                    User user = UserHelper.GetUser(userData,name,password);
                    Console.WriteLine(UserHelper.ToString(user));
                }
                else
                {
                    throw new Exception("User not found!");
                }
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Log);
                log(e.Message);

            }
          
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }

    }
}
