using Core.Entities.Concrete;
using Entities.Log.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NBS
{
    public class NBSDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            optionsBuilder.UseSqlServer(@"Server=89.252.137.24;Database=NBSDB;User ID=sa;Password=Yuskan2085@;MultipleActiveResultSets=true");
        }


        public DbSet<Location> Locations { get; set; }
        public DbSet<AppVersion> Versions { get; set; }

    }
}
