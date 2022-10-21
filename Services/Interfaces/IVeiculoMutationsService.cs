using API_DEVinCar_Graphql.Data.Dtos;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Services.Interfaces
{
    public interface IVeiculoMutationsService
    {
        Task<bool> ChangeColourAsync(string veiculoId, string colour);
        Task<bool> ChangePriceAsync(string veiculoId, double price);
        Task<Veiculo?> CreateVehicleAsync(Camionete camionete);
        Task<Veiculo?> CreateVehicleAsync(Carro carro);
        Task<Veiculo?> CreateVehicleAsync(MotoTriciclo moto);
        Task<VendaViewModel?> SellVehicle(string veiculoId, string cpf, DateTime data);
    }
}