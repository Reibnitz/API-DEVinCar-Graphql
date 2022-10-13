using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_DEVinCar_Graphql.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly DEVInCarContext _context;

        public VendaRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public async Task<Venda?> AddAsync(Venda entity)
        {
            _context.Vendas.Add(entity);
            int entitiesWritten = await _context.SaveChangesAsync();

            if (entitiesWritten != 1)
                return null;

            return entity;
        }

        public async Task<List<Venda>> GetAllAsync()
        {
            return await _context.Vendas.ToListAsync();
        }

        public async Task<Venda?> GetByIdAsync(Guid id)
        {
            return await _context.Vendas.FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<bool> UpdateAsync(Venda entity)
        {
            _context.Vendas.Update(entity);
            int entitiesWritten = await _context.SaveChangesAsync();

            if (entitiesWritten != 1)
                return false;

            return true;
        }
    }
}
