using Microsoft.EntityFrameworkCore;
using ProjeAppSube1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAppSube1
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ProjeDbSube1;Integrated Security=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OgrenciDers>().HasKey(od => new { od.OgrenciID, od.DersID });//birden fazla alanın birleşiminden oluşuyor: OgrenciID ve DersID.haskey primarykey
            modelBuilder.Entity<Ders>().HasKey(d => d.DersID); //her dersin benzersiz bir şekilde tanımlanmasını sağlar.
            modelBuilder.Entity<Sinif>().HasKey(s => s.SinifId);//amaç Her sınıfın adı benzersizdir ve bu alan sınıfları ayırt etmek için kullanılır.
        }
    }
}
