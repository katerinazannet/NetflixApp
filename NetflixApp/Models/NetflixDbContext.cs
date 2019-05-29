using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NetflixApp.Models
{
    public class NetflixDbContext : DbContext
    {
        public DbSet<Serie> Series { get; set; }
    }
}