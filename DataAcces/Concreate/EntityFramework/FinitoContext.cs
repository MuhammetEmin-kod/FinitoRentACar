using Entity.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concreate.EntityFramework
{
    public class FinitoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CHM2CA4;Initial Catalog=FinitoCar;Integrated Security=True");
        }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<KullaniciGiris> KullaniciGirisleri { get; set; }
        public DbSet<Sozlesme> Sozlesmeler { get; set; }
    }


}
