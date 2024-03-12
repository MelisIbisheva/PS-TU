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
using UI.Windows;

namespace UI
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogsWindow lw = new LogsWindow();
            lw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new RemoveUserWindow().Show();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new AddUserWindow().Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            studentsList.DisplayUsers();
        }
    }
}
