using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;

namespace API_DEVinCar_Graphql.Services
{
    public interface IListagemService
    {
        Task<IEnumerable<Veiculo>> GetDisponiveis(EVeiculo? tipoVeiculo);
    }
}