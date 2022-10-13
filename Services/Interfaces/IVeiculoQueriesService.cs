using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;

namespace API_DEVinCar_Graphql.Services.Interfaces
{
    public interface IVeiculoQueriesService
    {
        Task<IEnumerable<Veiculo>> GetAvailableAsync(EVeiculo? tipoVeiculo);
        Task<IEnumerable<Veiculo>> GetSoldAsync(EVeiculo? tipoVeiculo);
        Task<IEnumerable<Veiculo>> GetAllAsync(EVeiculo? tipoVeiculo);
    }
}