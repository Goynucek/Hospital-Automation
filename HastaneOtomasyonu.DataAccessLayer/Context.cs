using HastaneOtomasyonu.EntityLayer.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.DataAccessLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-UQGF5P1\\SQLEXPRESS;database=HastaneDB;integrated security=true;TrustServerCertificate=true;");
        }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Hasta> Hastas { get; set; }
        public DbSet<Klinik> Kliniks { get; set; }
        public DbSet<Poliklinik> Polikliniks { get; set; }
        public DbSet<Muayane> Muayanes { get; set; }
        public DbSet<Giris> Girises { get; set; }
    }
}
