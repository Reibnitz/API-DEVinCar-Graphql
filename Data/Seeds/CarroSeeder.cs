using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Seeds
{
    public static class CarroSeeder
    {
        public static List<Carro> Seed = new()
        {
            new Carro
            (
                potencia: 71,
                portas: 4,
                flex: true,
                dataFabricacao: new DateTime(2022, 05, 13),
                name: "Kwid",
                placa: "ABC-1234",
                valor: 59999.90,
                cor: "Vermelho"
            ) { Id = 1},
            new Carro
            (
                potencia: 65,
                portas: 2,
                flex: true,
                dataFabricacao: new DateTime(2013, 09, 23),
                name: "Uno",
                placa: "XYZ-6789",
                valor: 24999.90,
                cor: "Vermelho"
            ) { Id = 2},
            new Carro
            (
                potencia: 71,
                portas: 4,
                flex: false,
                dataFabricacao: new DateTime(2017, 11, 07),
                name: "Ka",
                placa: "AAA-1111",
                valor: 49999.90,
                cor: "Preto"
            ) { Id = 3},
        };
    }
}
