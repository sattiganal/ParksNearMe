using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParksNearMe.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<ParkUser> users { get; set; }
        public DbSet<FavPark> FavParks { get; set; }
        public DbSet<UserFavPark> userFavs { get; set; }

    }
}
