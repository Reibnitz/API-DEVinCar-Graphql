using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Services;

namespace API_DEVinCar_Graphql.Graphql.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class ListagemQueries
    {
        private readonly IListagemService _listagemService;

        public ListagemQueries(IListagemService listagemService)
        {
            _listagemService = listagemService;
        }

        [GraphQLName("listar_disponiveis")]
        [GraphQLDescription("Retorna lista de veículos disponíveis conforme tipoVeiculo. Retorna todos os veículos disponíveis caso não tipoVeiculo seja informado")]
        public async Task<IEnumerable<Veiculo>> GetDisponiveis(EVeiculo? tipoVeiculo)
        {
            return await _listagemService.Disponiveis(tipoVeiculo);
        }
    }
}
