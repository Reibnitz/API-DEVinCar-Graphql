using API_DEVinCar_Graphql.Data.Dtos;
using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Services.Interfaces;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Subscriptions;

namespace API_DEVinCar_Graphql.Graphql
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VeiculoMutations
    {
        [Authorize]
        [GraphQLName("VenderVeiculo")]
        [GraphQLDescription("Retorna resultado da solicitação de venda e veiculo vendido")]
        public async Task<VendaViewModel?> VenderVeiculo(string veiculoId, string cpf, DateTime data, [Service] IVeiculoMutationsService service, [Service] ITopicEventSender eventSender)
        {
            VendaViewModel? result = await service.SellVehicle(veiculoId, cpf, data);

            if (result != null)
            {
                await eventSender.SendAsync(nameof(VeiculoSubscriptions.VeiculoVendido), result).ConfigureAwait(false);
                await eventSender.SendAsync(result.Venda.TipoVeiculo, result).ConfigureAwait(false);
            }

            return result;
        }

        [GraphQLName("AlterarCor")]
        [GraphQLDescription("Retorna resultado da solicitação de troca de cor")]
        public async Task<string> AlterarCor(string veiculoId, string cor, [Service] IVeiculoMutationsService service)
        {
            bool result = await service.ChangeColourAsync(veiculoId, cor);

            return result ? "Operação realizada com sucesso" : "ERRO - Id inválido";
        }

        [GraphQLName("AlterarValor")]
        [GraphQLDescription("Retorna resultado da solicitação de troca de valor")]
        public async Task<string> AlterarValor(string veiculoId, double valor, [Service] IVeiculoMutationsService service)
        {
            bool result = await service.ChangePriceAsync(veiculoId, valor);

            return result ? "Operação realizada com sucesso" : "ERRO - Id inválido";
        }

        [Authorize]
        [GraphQLName("NovoCarro")]
        [GraphQLDescription("Retorna resultado da inclusão de novo veículo")]
        public async Task<Veiculo?> NovoVeiculo(CreateCarroDto carro, [Service] IVeiculoMutationsService service, [Service] ITopicEventSender eventSender)
        {
            Veiculo? result = await service.CreateVehicleAsync(carro);

            if (result != null)
            {
                await eventSender.SendAsync(nameof(VeiculoSubscriptions.VeiculoAdicionado), result).ConfigureAwait(false);
                await eventSender.SendAsync(EVeiculo.Carro, result).ConfigureAwait(false);
            }

            return result;
        }

        [Authorize]
        [GraphQLName("NovaCamionete")]
        [GraphQLDescription("Retorna resultado da inclusão de novo veículo")]
        public async Task<Veiculo?> NovoVeiculo(CreateCamioneteDto camionete, [Service] IVeiculoMutationsService service, [Service] ITopicEventSender eventSender)
        {
            Veiculo? result = await service.CreateVehicleAsync(camionete);

            if (result != null)
            {
                await eventSender.SendAsync(nameof(VeiculoSubscriptions.VeiculoAdicionado), result).ConfigureAwait(false);
                await eventSender.SendAsync(EVeiculo.Carro, result).ConfigureAwait(false);
            }

            return result;
        }

        [Authorize]
        [GraphQLName("NovaMotoTriciclo")]
        [GraphQLDescription("Retorna resultado da inclusão de novo veículo")]
        public async Task<Veiculo?> NovoVeiculo(CreateMotoTricicloDto motoTriciclo, [Service] IVeiculoMutationsService service, [Service] ITopicEventSender eventSender)
        {
            Veiculo? result = await service.CreateVehicleAsync(motoTriciclo);

            if (result != null)
            {
                await eventSender.SendAsync(nameof(VeiculoSubscriptions.VeiculoAdicionado), result).ConfigureAwait(false);
                await eventSender.SendAsync(EVeiculo.MotoTriciclo, result).ConfigureAwait(false);
            }

            return result;
        }
    }
}
