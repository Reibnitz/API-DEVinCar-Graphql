using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Services.Interfaces
{
    public interface IVeiculoMutationsService
    {
        Task<bool> ChangeColourAsync(Guid veiculoId, string colour);
        Task<bool> ChangePriceAsync(Guid veiculoId, double price);
        Task<Camionete?> CreateVehicleAsync(Camionete camionete);
        Task<Carro?> CreateVehicleAsync(Carro carro);
        Task<MotoTriciclo?> CreateVehicleAsync(MotoTriciclo moto);
        Task<Venda?> SellVehicle(Guid veiculoId, string cpf, DateTime data);
    }
}