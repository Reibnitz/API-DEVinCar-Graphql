using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Repositories
{
    public interface IRepository<T>
    {
        Task<IList<T>> GetAll();
        Task<IList<T>> GetAvailable();
        Task<IList<T>> GetSold();
    }
}
