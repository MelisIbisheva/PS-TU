using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using Welcome.Others;
using Welcome.Model;

namespace DataLayer.Database
{
     public class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }
        public DbSet<DatabaseLog> Logs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcom.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            

            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            //create a user
            var user = new DatabaseUser()
            {
                Id = 1,
                Name = "John Doe",
                Password = "1234",
                Role = UserRolesEnum.ADMIN,
                FNumber = "121221034",
                Email = "john09@gmail.com",
                Expires = DateTime.Now.AddYears(10)
                
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user);

            var user2 = new DatabaseUser()
            {
                Id = 2,
                Name = "Aleks Smith",
                Password = "12345",
                Role = UserRolesEnum.STUDENT,
                FNumber = "121221035",
                Email = "aleks21@gmail.com",
                Expires = DateTime.Now.AddYears(4)
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user2);

            var user3 = new DatabaseUser()
            {
                Id = 3,
                Name = "Emily Jameson",
                Password = "123",
                Role = UserRolesEnum.PROFESSOR,
                FNumber = "121221054",
                Email = "emily12@gmail.com",
                Expires = DateTime.Now.AddYears(8)
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user3);
        }

        


    }
}
