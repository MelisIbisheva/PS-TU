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
    /// Interaction logic for UserInformationWindow.xaml
    /// </summary>
    public partial class UserInformationWindow : Window
    {
        public UserInformationWindow()
        {
            InitializeComponent();
        }

        private void TogglePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (togglePasswordButton.IsChecked == true)
            {
                students.Columns[6].Visibility = Visibility.Visible;
                togglePasswordButton.Content = "Hide Password";
            }
            else
            {
                students.Columns[6].Visibility = Visibility.Hidden;
                togglePasswordButton.Content = "Show Password";
            }
        }
        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
