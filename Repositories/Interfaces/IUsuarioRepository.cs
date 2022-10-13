using API_DEVinCar_Graphql.Data.Models;

namespace API_DEVinCar_Graphql.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<bool> Login(Login login);
    }
}