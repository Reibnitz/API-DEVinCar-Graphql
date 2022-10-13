using API_DEVinCar_Graphql.Data.Models;

namespace API_DEVinCar_Graphql.Services.Interfaces
{
    public interface IUsuarioMutationService
    {
        Task<string> Login(Login login);
    }
}