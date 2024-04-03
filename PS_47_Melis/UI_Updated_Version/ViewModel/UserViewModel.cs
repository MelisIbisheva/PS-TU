using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UI_Updated_Version.Model;

namespace UI_Updated_Version.ViewModel
{
    public class UserViewModel : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<DatabaseUser> _users;
        public UserViewModel()
        {
            UserModel model = new UserModel();
            Users = model.GetData();
        }
        public ObservableCollection<DatabaseUser> Users
        {
            get { return _users; }
            set { _users = value; PropChanged(nameof(Users)); }
        }
        public void PropChanged(String propertyName)
        {
            //Did WPF registerd to listen to this event
            if (PropertyChanged != null)
            {
                //Tell WPF that this property changed
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
