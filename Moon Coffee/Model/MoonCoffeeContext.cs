using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Moon_Coffee.Model
{
    public partial class MoonCoffeeContext : DbContext
    {
        public MoonCoffeeContext()
            : base("name=MoonCoffeeContext")
        {
        }

        public virtual DbSet<BardakBoy> BardakBoy { get; set; }
        public virtual DbSet<Ekstra> Ekstra { get; set; }
        public virtual DbSet<Gecmis> Gecmis { get; set; }
        public virtual DbSet<Icerik> Icerik { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Masa> Masa { get; set; }
        public virtual DbSet<OdemeTuru> OdemeTuru { get; set; }
        public virtual DbSet<Satıs> Satıs { get; set; }
        public virtual DbSet<surup> surup { get; set; }
        public virtual DbSet<sut> sut { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
