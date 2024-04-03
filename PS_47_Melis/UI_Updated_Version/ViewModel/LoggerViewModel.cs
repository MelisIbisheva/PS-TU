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
    public class LoggerViewModel : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<DatabaseLog> _loggers;
        public LoggerViewModel()
        {
            LoggerModel model = new LoggerModel();
            Loggers = model.GetData();
        }
        public ObservableCollection<DatabaseLog> Loggers
        {
            get { return _loggers; }
            set { _loggers = value; PropChanged(nameof(Loggers)); }
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
