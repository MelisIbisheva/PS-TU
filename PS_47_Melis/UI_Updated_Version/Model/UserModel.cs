using DataLayer.Database;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;


namespace UI_Updated_Version.Model
{
    public class UserModel : DatabaseUser
    {
        private ObservableCollection<DatabaseUser> data { get; set; }

        private readonly DatabaseContext dbContext;

        public string LogDatesAsString { get; set; }

        public UserModel()
        {
            data = new ObservableCollection<DatabaseUser>();
            dbContext = new DatabaseContext();

        }

        public ObservableCollection<DatabaseUser> GetData()
        {
            var list = dbContext.Users.ToList();
            foreach (var user in list)
            {
                data.Add(user);
            }
            return data;
        }

        
    }
}
