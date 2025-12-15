using AquaControl.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Infrastructure
{
    public class AquaControlDbContext : DbContext
    {
        //private const string dbPutanja = "C:\\Users\\Kenan\\Desktop\\AquaControl.db";
        private readonly string dbPutanja; //=@"Data Source=C:\Users\Kenan\Desktop\AquaControl.db";

        public AquaControlDbContext()
        {
            dbPutanja = ConfigurationManager.ConnectionStrings["AquaControlDB"].ConnectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlite(dbPutanja);
        }

        public DbSet<Mjesto> Mjesta { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Tarifa> Tarife { get; set; }
        public DbSet<MjerniUredjaj> MjerniUredjaji { get; set; }
        public DbSet<Inkasant> Inkasanti { get; set; }
        public DbSet<Ocitavanje> Ocitavanja { get; set; }
        public DbSet<Admin> Admini { get; set; }
        public DbSet<EvidencijaKvara> EvidencijaKvarova { get; set; }
        public DbSet<Firma> Firme { get; set; }
        public DbSet<Transakcija> Transakcije { get; set; }
    }
}
