using System;
using Final_project_webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace Final_project_webapi.Data
{  
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    FName = "guille",
                    LName= "William",
                    Email = "guille@gmail.com",
                    Phone = 3241324,
                    UserType = UserType.Owner,
                    
                },
                new User
                {
                    UserId = 2,
                    FName = "daniel",
                    LName = "William",
                    Email = "daniel@gmail.com",
                    Phone = 3241324,
                    UserType = UserType.Owner,
                }
            );
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

    }
}
