using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogRegPage.Models
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;

        }

        public void Seed()
        {
            modelBuilder.Entity<Score>().HasData(
                new Score() 
                { Id = 1, 
                    ScoreGameOne = 1, 
                    ScoreGameTwo = 1 } 
                );
            modelBuilder.Entity<User>().HasData(
                   new User() 
                   { Id = 1, UserName = "admin",
                       Password = "admin", 
                       UserType = "Admin ",
                       Grade = "1", 
                       ScoreId = 1 } 
                   );
        }
    }
}
