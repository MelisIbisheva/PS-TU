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
using UI_Updated_Version.View.Windows;


namespace UI_Updated_Version
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnGoToUserInformation_Click(object sender, RoutedEventArgs e)
        {
            var userScreen = new UserInformationWindow();
            userScreen.Show();
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            var userScreen = new AddUserWindow();   
            userScreen.Show();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var userScreen = new RemoveUserWindow();
            userScreen.Show();
        }

        private void btnLogs_Click(object sender, RoutedEventArgs e)
        {
            var userScreen = new LogsWindow();
            userScreen.Show();

        }
    }
}
