using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Seeds
{
    public static class CamioneteSeeder
    {
        public static List<Camionete> Seed = new()
        {
            new Camionete
            (
                potencia: 107,
                portas: 2,
                tipoCombustivel: ETipoCombustivel.Gasolina,
                capacidadeCacamba: 844,
                dataFabricacao: new DateTime(2021, 12, 13),
                name: "Strada",
                placa: "CAM-0397",
                valor: 109990.00,
                cor: "Prata"
            ) { Id = 1},
            new Camionete
            (
                potencia: 204,
                portas: 4,
                tipoCombustivel: ETipoCombustivel.Diesel,
                capacidadeCacamba: 1570,
                dataFabricacao: new DateTime(2020, 06, 21),
                name: "Hilux",
                placa: "CAM-0397",
                valor: 260390.00,
                cor: "Vermelho"
            ) { Id = 2},
            new Camionete
            (
                potencia: 71,
                portas: 2,
                tipoCombustivel: ETipoCombustivel.Diesel,
                capacidadeCacamba: 580,
                dataFabricacao: new DateTime(2021, 12, 13),
                name: "Saveiro",
                placa: "CAM-0397",
                valor: 99000.00,
                cor: "Azul"
            ) { Id = 3},
        };
    }
}
