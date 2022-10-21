using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Seeds
{
    public static class CarroSeeder
    {
        public static List<Carro> Seed = new()
        {
            new Carro
            {
                Potencia = 71,
                Portas = 4,
                Flex = true,
                DataFabricacao = new DateTime(2022, 05, 13),
                Nome = "Kwid",
                Placa = "ABC-1234",
                Valor = 59999.90,
                Cor = "Vermelho",
                Disponivel = false,
                Id = 1
            },
            new Carro
            {
                Potencia = 65,
                Portas = 2,
                Flex = true,
                DataFabricacao = new DateTime(2013, 09, 23),
                Nome = "Uno",
                Placa = "XYZ-6789",
                Valor = 24999.90,
                Cor = "Vermelho",
                Disponivel = false,
                Id = 2
            },
            new Carro
            {
                Potencia = 71,
                Portas = 4,
                Flex = false,
                DataFabricacao = new DateTime(2017, 11, 07),
                Nome = "Ka",
                Placa = "AAA-1111",
                Valor = 49999.90,
                Cor = "Preto",
                Disponivel = true,
                Id = 3
            },
        };
    }
}
