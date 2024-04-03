using DataLayer.Database;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Updated_Version.Model
{
    public class LoggerModel
    {
        private ObservableCollection<DatabaseLog> data { get; set; }

        private readonly DatabaseContext dbContext;

        public LoggerModel()
        {
            data = new ObservableCollection<DatabaseLog>();
            dbContext = new DatabaseContext();
        }

        public ObservableCollection<DatabaseLog> GetData()
        {
            var list = dbContext.Logs.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                data.Add(list[i]);
            }
            return data;
            // Retrieve data from the database
            // Populate Users ObservableCollection
        }
    }
}
