using API_DEVinCar_Graphql.Data.Models;

namespace API_DEVinCar_Graphql.Data.Seeds
{
    public class UsuarioSeeder
    {
        public static List<Usuario> Seed = new()
        {
            new Usuario
            {
                Username = "Yan",
                Password = "123456",
                Id = 1
            },
            new Usuario
            {
                Username = "Fernando",
                Password = "654321",
                Id = 2
            },
            new Usuario
            {
                Username = "Lucas",
                Password = "qwerty",
                Id = 3
            }
        };
    }
}
