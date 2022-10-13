﻿namespace API_DEVinCar_Graphql.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        Task<T?> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
    }
}