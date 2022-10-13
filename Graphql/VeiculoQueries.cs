using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Services.Interfaces;

namespace API_DEVinCar_Graphql.Graphql
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class VeiculoQueries
    {
        [GraphQLName("Disponiveis")]
        [GraphQLDescription("Retorna lista de veículos disponíveis")]
        public async Task<IEnumerable<Veiculo>> GetAvailable(EVeiculo? tipoVeiculo, [Service] IQueriesService listagemService)
        {
            return await listagemService.GetAvailableAsync(tipoVeiculo);
        }

        [GraphQLName("Vendidos")]
        [GraphQLDescription("Retorna lista de veículos vendidos")]
        public async Task<IEnumerable<Veiculo>> GetSold(EVeiculo? tipoVeiculo, [Service] IQueriesService listagemService)
        {
            return await listagemService.GetSoldAsync(tipoVeiculo);
        }

        [GraphQLName("MaiorPreco")]
        [GraphQLDescription("Retorna lista de veículos ordenados pelo maior preço")]
        public async Task<IEnumerable<Veiculo>> GetHighestPrices(EVeiculo? tipoVeiculo, [Service] IQueriesService listagemService)
        {
            IEnumerable<Veiculo> veiculos = await listagemService.GetAllAsync(tipoVeiculo);
            return veiculos.ToList().OrderByDescending(v => v.Valor);
        }

        [GraphQLName("MenorPreco")]
        [GraphQLDescription("Retorna lista de veículos odernados pelo menor preço")]
        public async Task<IEnumerable<Veiculo>> GetLowestPrices(EVeiculo? tipoVeiculo, [Service] IQueriesService listagemService)
        {
            IEnumerable<Veiculo> veiculos = await listagemService.GetAllAsync(tipoVeiculo);
            return veiculos.ToList().OrderBy(v => v.Valor);
        }
    }
}
