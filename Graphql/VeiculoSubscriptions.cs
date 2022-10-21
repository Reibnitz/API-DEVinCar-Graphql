using API_DEVinCar_Graphql.Data.Dtos;
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
        public VendaViewModel TipoVeiculoVendido([Topic] EVeiculoVendido tipoVeiculo, [EventMessage] VendaViewModel venda)
        {
            return venda;
        }

        [GraphQLName("VeiculoVendido")]
        [GraphQLDescription("Retorna veículo vendido")]
        [Subscribe]
        public VendaViewModel VeiculoVendido([EventMessage] VendaViewModel venda)
        {
            return venda;
        }

        [GraphQLName("TipoVeiculoAdicionado")]
        [GraphQLDescription("Retorna veículo adicionado filtrado por tipo")]
        [Subscribe]
        public VeiculoSubscriptionViewModel TipoVeiculoAdicionado([Topic] EVeiculo tipoVeiculo, [EventMessage] Veiculo veiculo)
        {
            return (VeiculoSubscriptionViewModel) veiculo;
        }

        [GraphQLName("VeiculoAdicionado")]
        [GraphQLDescription("Retorna veículo adicionado")]
        [Subscribe]
        public VeiculoSubscriptionViewModel VeiculoAdicionado([EventMessage] Veiculo veiculo)
        {
            return (VeiculoSubscriptionViewModel) veiculo;
        }
    }
}
