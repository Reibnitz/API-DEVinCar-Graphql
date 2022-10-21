using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Repositories.Interfaces
{
    public interface IVeiculoRepository<T> : IRepository<T>
    {
        Task<List<T>> GetAvailableAsync();
        Task<List<T>> GetSoldAsync();
        Task<bool> SellAsync(int id);
        Task<bool> ChangeColorAsync(int id, string color);
        Task<bool> ChangePriceAsync(int id, double price);
    }
}
