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

namespace UI_Updated_Version.View.Windows
{
    /// <summary>
    /// Interaction logic for RemoveUserWindow.xaml
    /// </summary>
    public partial class RemoveUserWindow : Window
    {
        public RemoveUserWindow()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            using (DatabaseContext dbContext = new DatabaseContext())
            {
                string rUname = tbN.Text;
                dbContext.Remove<DatabaseUser>(dbContext.Users.Where(x => x.Name == rUname).First());
                dbContext.SaveChanges();
                dbContext.Logs.Add(new DatabaseLog()
                {
                    Message = $"{tbN.Text} Deleted!",
                });
                dbContext.SaveChanges();

            }

        }
    }
}
