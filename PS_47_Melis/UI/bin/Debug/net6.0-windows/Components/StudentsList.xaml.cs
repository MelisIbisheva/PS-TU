using DataLayer.Database;
using DataLayer.Helpers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.Logging;
using DataLayer.Model;
using Welcome.Others;

namespace UI.Components
{
    /// <summary>
    /// Interaction logic for StudentsList.xaml
    /// </summary>
    public partial class StudentsList : UserControl
    {
       // private readonly DatabaseContext dbContext = new DatabaseContext();
        //private readonly ILogger logger = LoggerHelper.GetDbLogger("db");
        public StudentsList()
        {
            InitializeComponent();
            using (var ctx = new DatabaseContext())
            {
                var records = ctx.Users.ToList();
                students.DataContext = records;
            }
        }

       // private void RefreshStudentList()
       // {
      //      var records = dbContext.Users.ToList();
       //     students.DataContext = records;
       // }

        public void DisplayUsers()
        {
            using (var ctx = new DatabaseContext())
            {
                ctx.Database.EnsureCreated();
                var records = ctx.Users.ToList();
                students.DataContext = records;
            }
        }

       /* private void TogglePasswordButton_Click(object sender, RoutedEventArgs e)
        {
           if (togglePasswordButton.IsChecked == true)
            {
                students.Columns[2].Visibility = Visibility.Visible;
                togglePasswordButton.Content = "Hide Password";
            }
            else
            {
                students.Columns[2].Visibility = Visibility.Hidden;
                togglePasswordButton.Content = "Show Password";
            }
        }
       */
        private void students_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                ctx.Users.Remove((DatabaseUser)students.SelectedItem);
                ctx.SaveChanges();
            }
            DisplayUsers();
        }

    }
}
