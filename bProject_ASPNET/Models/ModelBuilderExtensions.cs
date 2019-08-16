using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bProject_ASPNET.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed( this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                       new User
                       {
                           ID = 3,
                           Name = "First User",
                           UserHobby = Hobby.Basketball,
                           Email = "firstuser@gmail.com"
                       }
            );
        }
    }
}
