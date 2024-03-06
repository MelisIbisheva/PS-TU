using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using Welcome.Others;

namespace DataLayer.Database
{
    internal class DatabaseContext : DbContext
    {
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

            //create a user
            var user = new DatabaseUser()
            {
                Id = 1,
                Name = "John Doe",
                Password = "1234",
                Role = UserRolesEnum.ADMIN,
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
                Expires = DateTime.Now.AddYears(8)
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user3);
        }

        public DbSet<DatabaseUser> Users { get; set; }


    }
}
