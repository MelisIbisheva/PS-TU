using DataLayer.Database;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Welcome.Others;

namespace UI_Updated_Version.View.Windows
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            using (DatabaseContext dbContext = new DatabaseContext())
            {
                if (Enum.TryParse<UserRolesEnum>(tbR.Text, out UserRolesEnum parsedRole))
                {
                    if (!UserExists(dbContext, tbN.Text))
                    {

                        dbContext.Add<DatabaseUser>(new DatabaseUser()
                        {
                            Name = tbN.Text,
                            Password = tbP.Text,
                            FNumber = tbFN.Text,
                            Role = parsedRole,
                            Email = tbEm.Text,
                            Expires = DateTime.Now.AddYears(1)
                        });
                        dbContext.Logs.Add(new DatabaseLog()
                        {
                            Message = $"{tbN.Text} Created!",
                        });
                        dbContext.SaveChanges();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("User exist");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid role");
                }


            }
        }
        private bool UserExists(DatabaseContext dbContext, string username)
        {
            return dbContext.Users.Any(u => u.Name == username);
        }


    }
}
