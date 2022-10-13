using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Data.Seeds;
using API_DEVinCar_Graphql.Models;
using Microsoft.EntityFrameworkCore;

namespace API_DEVinCar_Graphql.Data
{
    public class DEVInCarContext : DbContext
    {
        public DEVInCarContext(DbContextOptions<DEVInCarContext> options) : base(options)
        {

        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Camionete> Camionetes { get; set; }
        public DbSet<MotoTriciclo> MotoTriciclos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Camionete>().HasData(CamioneteSeeder.Seed);
            builder.Entity<Carro>().HasData(CarroSeeder.Seed);
            builder.Entity<MotoTriciclo>().HasData(MotoTricicloSeeder.Seed);
            builder.Entity<Usuario>().HasData(UsuarioSeeder.Seed);
        }
    }
}
