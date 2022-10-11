using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Seeds
{
    public static class CamioneteSeeder
    {
        public static List<Camionete> Seed = new()
        {
            new Camionete
            {
                Potencia = 107,
                Portas = 2,
                TipoCombustivel = ECombustivel.Gasolina,
                CapacidadeCacamba = 844,
                DataFabricacao = new DateTime(2021, 12, 13),
                Nome = "Strada",
                Placa = "CAM-0397",
                Valor = 109990.00,
                Cor = "Prata",
                Disponivel = true,
                Id = Guid.NewGuid()
            },
            new Camionete
            {
                Potencia = 204,
                Portas = 4,
                TipoCombustivel = ECombustivel.Diesel,
                CapacidadeCacamba = 1570,
                DataFabricacao = new DateTime(2020, 06, 21),
                Nome = "Hilux",
                Placa = "CAM-0397",
                Valor = 260390.00,
                Cor = "Vermelho",
                Disponivel = false,
                Id = Guid.NewGuid()
            },
            new Camionete
            {
                Potencia = 71,
                Portas = 2,
                TipoCombustivel = ECombustivel.Diesel,
                CapacidadeCacamba = 580,
                DataFabricacao = new DateTime(2021, 12, 13),
                Nome = "Saveiro",
                Placa = "CAM-0397",
                Valor = 99000.00,
                Cor = "Azul",
                Disponivel = true,
                Id = Guid.NewGuid()
            },
        };
    }
}
