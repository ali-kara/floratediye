using Core.Entities.Concrete;
using Entities.Log.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Log
{
    public class LogDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=89.252.137.24;Database=UreticiLogDB2;User ID=sa;Password=Yuskan2085@;MultipleActiveResultSets=true");
        }


        public DbSet<Country> Country { get; set; }
        public DbSet<Sube> Subeler { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<WebExceptionLogs> WebExceptionLogs { get; set; }
        public DbSet<Users> Kullanicilar { get; set; }
        public DbSet<Duyurular> Duyurular { get; set; }
        public DbSet<DuyurularKayit> DuyurularKayit { get; set; }

    }
}
