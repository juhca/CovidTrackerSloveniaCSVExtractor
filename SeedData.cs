using IndigoLabs2.Models;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace IndigoLabs2
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new List<User>
            {
                new User { Id = 1, Password = "admin", Username = "admin"},
                new User { Id = 2, Password = "000000", Username = "tomas"},
                new User { Id = 3, Password = "000000", Username = "uporabnik01"},
                new User { Id = 4, Password = "000000", Username = "uporabnik02"}
            });

        }
    }
}
