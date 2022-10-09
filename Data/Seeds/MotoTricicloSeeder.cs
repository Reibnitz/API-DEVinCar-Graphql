using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Seeds
{
    public static class MotoTricicloSeeder
    {
        public static List<MotoTriciclo> Seed = new()
        {
            new MotoTriciclo
            (
                potencia: 8.33,
                rodas: 2,
                dataFabricacao: new DateTime(2016, 07, 03),
                name: "Biz",
                placa: "ASD-4123",
                valor: 8900.00,
                cor: "Azul"
            ) { Id = 1},
            new MotoTriciclo
            (
                potencia: 14.9,
                rodas: 2,
                dataFabricacao: new DateTime(2018, 10, 09),
                name: "CG-160",
                placa: "FED-5193",
                valor: 10520.00,
                cor: "Preto"
            ) { Id = 2},
            new MotoTriciclo
            (
                potencia: 21,
                rodas: 3,
                dataFabricacao: new DateTime(2017, 01, 07),
                name: "Spider",
                placa: "BSC-9297",
                valor: 16999.00,
                cor: "Preto"
            ) { Id = 3},
        };
    }
}
