using API_DEVinCar_Graphql.Models;
using Microsoft.EntityFrameworkCore;

namespace API_DEVinCar_Graphql.Data
{
    public class DEVInCarContextext : DbContext
    {
        public DEVInCarContextext(DbContextOptions<DEVInCarContextext> options) : base(options)
        {

        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Camionete> Camionetes { get; set; }
        public DbSet<MotoTriciclo> MotoTriciclos { get; set; }
    }
}
