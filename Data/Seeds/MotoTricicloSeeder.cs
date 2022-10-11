using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Seeds
{
    public static class MotoTricicloSeeder
    {
        public static List<MotoTriciclo> Seed = new()
        {
            new MotoTriciclo
            {
                Potencia = 8.33,
                Rodas = 2,
                DataFabricacao = new DateTime(2016, 07, 03),
                Nome = "Biz",
                Placa = "ASD-4123",
                Valor = 8900.00,
                Cor = "Azul",
                Disponivel = true,
                Id = Guid.NewGuid()
            },
            new MotoTriciclo
            {
                Potencia = 14.9,
                Rodas = 2,
                DataFabricacao = new DateTime(2018, 10, 09),
                Nome = "CG-160",
                Placa = "FED-5193",
                Valor = 10520.00,
                Cor = "Preto",
                Disponivel = true,
                Id = Guid.NewGuid()
            },
            new MotoTriciclo
            {
                Potencia = 21,
                Rodas = 3,
                DataFabricacao = new DateTime(2017, 01, 07),
                Nome = "Spider",
                Placa = "BSC-9297",
                Valor = 16999.00,
                Cor = "Preto",
                Disponivel = false,
                Id = Guid.NewGuid()
            },
        };
    }
}
