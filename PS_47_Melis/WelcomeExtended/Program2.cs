// See https://aka.ms/new-console-template for more information
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using Welcome.View;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);

                view.Display();

                view.DisplayError();
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
