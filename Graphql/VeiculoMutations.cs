using API_DEVinCar_Graphql.Data.Dtos;
using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Services.Interfaces;
using HotChocolate.Subscriptions;

namespace API_DEVinCar_Graphql.Graphql
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VeiculoMutations
    {
        [GraphQLName("VenderVeiculo")]
        [GraphQLDescription("Retorna resultado da solicitação de venda")]
        public async Task<Venda?> VenderVeiculo(Guid veiculoId, string cpf, DateTime data, [Service] IMutationsService service, [Service] ITopicEventSender eventSender)
        {
            Venda result = await service.SellVehicle(veiculoId, cpf, data);

            if (result != null)
            {
                await eventSender.SendAsync(nameof(VeiculoSubscriptions.VeiculoVendido), result).ConfigureAwait(false);
                await eventSender.SendAsync(result.TipoVeiculo, result).ConfigureAwait(false);
            }

            return result;
        }

        [GraphQLName("AlterarCor")]
        [GraphQLDescription("Retorna resultado da solicitação de troca de cor")]
        public async Task<string> AlterarCor(Guid veiculoId, string cor, [Service] IMutationsService service)
        {
            bool result = await service.ChangeColourAsync(veiculoId, cor);

            return result ? "Operação realizada com sucesso" : "ERRO - Id inválido";
        }

        [GraphQLName("AlterarValor")]
        [GraphQLDescription("Retorna resultado da solicitação de troca de valor")]
        public async Task<string> AlterarValor(Guid veiculoId, double valor, [Service] IMutationsService service)
        {
            bool result = await service.ChangePriceAsync(veiculoId, valor);

            return result ? "Operação realizada com sucesso" : "ERRO - Id inválido";
        }

        [GraphQLName("NovoCarro")]
        [GraphQLDescription("Retorna resultado da inclusão de novo veículo")]
        public async Task<Carro?> NovoVeiculo(CreateCarroDto carro, [Service] IMutationsService service, [Service] ITopicEventSender eventSender)
        {
            Veiculo? result = await service.CreateVehicleAsync(carro);

            if (result != null)
            {
                await eventSender.SendAsync(nameof(VeiculoSubscriptions.VeiculoAdicionado), result).ConfigureAwait(false);
                await eventSender.SendAsync(EVeiculo.Carro, result).ConfigureAwait(false);
            }

            return (Carro?)result;
        }

        [GraphQLName("NovaCamionete")]
        [GraphQLDescription("Retorna resultado da inclusão de novo veículo")]
        public async Task<Camionete?> NovoVeiculo(CreateCamioneteDto camionete, [Service] IMutationsService service, [Service] ITopicEventSender eventSender)
        {
            Veiculo? result = await service.CreateVehicleAsync(camionete);

            if (result != null)
            {
                await eventSender.SendAsync(nameof(VeiculoSubscriptions.VeiculoAdicionado), result).ConfigureAwait(false);
                await eventSender.SendAsync(EVeiculo.Carro, result).ConfigureAwait(false);
            }

            return (Camionete?)result;
        }

        [GraphQLName("NovaMotoTriciclo")]
        [GraphQLDescription("Retorna resultado da inclusão de novo veículo")]
        public async Task<MotoTriciclo?> NovoVeiculo(CreateMotoTricicloDto motoTriciclo, [Service] IMutationsService service, [Service] ITopicEventSender eventSender)
        {
            Veiculo? result = await service.CreateVehicleAsync(motoTriciclo);

            if (result != null)
            {
                await eventSender.SendAsync(nameof(VeiculoSubscriptions.VeiculoAdicionado), result).ConfigureAwait(false);
                await eventSender.SendAsync(EVeiculo.MotoTriciclo, result).ConfigureAwait(false);
            }

            return (MotoTriciclo?)result;
        }
    }
}
