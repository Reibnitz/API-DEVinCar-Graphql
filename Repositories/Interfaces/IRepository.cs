using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<List<T>> GetAvailable();
        Task<List<T>> GetSold();
        Task<bool> Sell(Guid id);
        Task<bool> ChangeColor(Guid id, string color);
        Task<bool> ChangePrice(Guid id, double price);
        Task<bool> Add(T entity);
    }
}
