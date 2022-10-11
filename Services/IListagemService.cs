using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;

namespace API_DEVinCar_Graphql.Services
{
    public interface IListagemService
    {
        Task<IEnumerable<Veiculo>> GetAvailable(EVeiculo? tipoVeiculo);
        Task<IEnumerable<Veiculo>> GetSold(EVeiculo? tipoVeiculo);
        Task<IEnumerable<Veiculo>> GetAll(EVeiculo? tipoVeiculo);
    }
}