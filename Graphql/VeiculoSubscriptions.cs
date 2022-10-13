using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;

namespace API_DEVinCar_Graphql.Graphql
{
    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class VeiculoSubscriptions
    {
        [GraphQLName("TipoVeiculoVendido")]
        [GraphQLDescription("Retorna veículo vendido filtrado por tipo")]
        [Subscribe]
        public Venda TipoVeiculoVendido([Topic] EVeiculoVendido tipoVeiculo, [EventMessage] Venda venda)
        {
            return venda;
        }

        [GraphQLName("VeiculoVendido")]
        [GraphQLDescription("Retorna veículo vendido")]
        [Subscribe]
        public Venda VeiculoVendido([EventMessage] Venda venda)
        {
            return venda;
        }

        [GraphQLName("TipoVeiculoAdicionado")]
        [GraphQLDescription("Retorna veículo adicionado filtrado por tipo")]
        [Subscribe]
        public Veiculo TipoVeiculoAdicionado([Topic] EVeiculo tipoVeiculo, [EventMessage] Veiculo veiculo)
        {
            return veiculo;
        }

        [GraphQLName("VeiculoAdicionado")]
        [GraphQLDescription("Retorna veículo adicionado")]
        [Subscribe]
        public Veiculo VeiculoAdicionado([EventMessage] Veiculo veiculo)
        {
            return veiculo;
        }
    }
}
