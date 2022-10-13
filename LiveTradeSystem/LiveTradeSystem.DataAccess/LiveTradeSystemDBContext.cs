using LiveTradeSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTradeSystem.DataAccess
{
    public class LiveTradeSystemDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=89.252.137.24;Database=CanliSatisDB;User ID=sa;Password=Yuskan2085@;MultipleActiveResultSets=true");
            }
        }

        public DbSet<Alicilar> Alicilar { get; set; }
        public DbSet<DepoGiris> DepoGiris { get; set; }
        public DbSet<Sandalye> Sandalye { get; set; }
        public DbSet<Satis> Satis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Satis>().Property(e => e.ToplamTutar).HasPrecision(18, 2);
            modelBuilder.Entity<Satis>().Property(e => e.DalFiyat).HasPrecision(18, 2);
            modelBuilder.Entity<Satis>().Property(e => e.SatisFiyat).HasPrecision(18, 2);

            modelBuilder.Entity<Sandalye>().Property(e => e.KalanKredi).HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
