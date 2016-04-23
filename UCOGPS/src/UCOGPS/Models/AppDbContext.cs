using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCOGPS.Models
{
    public class AppDbContext : DbContext
    {
        private static bool _created = false;

        public AppDbContext()
        {
            if (!_created)
                Database.EnsureCreated();
        }

        public DbSet<User> User { get; set; }
        public DbSet<Building> Building { get; set; }
    }
}
