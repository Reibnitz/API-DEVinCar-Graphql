using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Services;

namespace API_DEVinCar_Graphql.Graphql.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class ListagemQueries
    {
        [GraphQLName("Disponiveis")]
        [GraphQLDescription("Retorna lista de veículos disponíveis")]
        public async Task<IEnumerable<Veiculo>> GetAvailable(EVeiculo? tipoVeiculo, [Service] IListagemService listagemService)
        {
            return await listagemService.GetAvailable(tipoVeiculo);
        }

        [GraphQLName("Vendidos")]
        [GraphQLDescription("Retorna lista de veículos vendidos")]
        public async Task<IEnumerable<Veiculo>> GetSold(EVeiculo? tipoVeiculo, [Service] IListagemService listagemService)
        {
            return await listagemService.GetSold(tipoVeiculo);
        }

        [GraphQLName("MaiorPreco")]
        [GraphQLDescription("Retorna lista de veículos ordenados pelo maior preço")]
        public async Task<IEnumerable<Veiculo>> GetHighestPrices(EVeiculo? tipoVeiculo, [Service] IListagemService listagemService)
        {
            IEnumerable<Veiculo> veiculos = await listagemService.GetAll(tipoVeiculo);
            return veiculos.ToList().OrderByDescending(v => v.Valor);
        }

        [GraphQLName("MenorPreco")]
        [GraphQLDescription("Retorna lista de veículos odernados pelo menor preço")]
        public async Task<IEnumerable<Veiculo>> GetLowestPrices(EVeiculo? tipoVeiculo, [Service] IListagemService listagemService)
        {
            IEnumerable<Veiculo> veiculos = await listagemService.GetAll(tipoVeiculo);
            return veiculos.ToList().OrderBy(v => v.Valor);
        }
    }
}
