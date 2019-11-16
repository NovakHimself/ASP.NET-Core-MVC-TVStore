using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVStore.Models
{
    public class TVContext : DbContext
    {
        public DbSet<TV> TVs { get; set; }
        public DbSet<Order> Orders { get; set; }

        public TVContext(DbContextOptions<TVContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
