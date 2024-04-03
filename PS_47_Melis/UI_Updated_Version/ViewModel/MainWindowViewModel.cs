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
    public class MainWindowViewModel : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<DatabaseUser> _users;
        private ObservableCollection<DatabaseLog> _loggers;
        private ObservableCollection<UserModel> _result;

        public MainWindowViewModel()
        {
            UserModel userModel = new UserModel();
            Users = userModel.GetData();
            LoggerModel loggerModel = new LoggerModel();
            Loggers = loggerModel.GetData();
         
        }

        public ObservableCollection<DatabaseUser> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                PropChanged(nameof(Users));
            }
        }

        public ObservableCollection<UserModel> Result
        {
            get { return _result; }
            set
            {
                _result = value;
                PropChanged(nameof(Result));
            }
        }
        public ObservableCollection<DatabaseLog> Loggers
        {
            get { return _loggers; }
            set
            {
                _loggers = value;
                PropChanged(nameof(Loggers));
            }
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
