using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_DEVinCar_Graphql.Repositories
{
    public class CamioneteRepository : ICamioneteRepository
    {
        private readonly DEVInCarContext _context;

        public CamioneteRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public async Task<List<Camionete>> GetAllAsync()
        {
            return await _context.Camionetes.ToListAsync();
        }

        public async Task<List<Camionete>> GetAvailableAsync()
        {
            return await _context.Camionetes.Where(carro => carro.Disponivel == true).ToListAsync();
        }

        public async Task<List<Camionete>> GetSoldAsync()
        {
            return await _context.Camionetes.Where(carro => carro.Disponivel == false).ToListAsync();
        }

        public async Task<Camionete?> AddAsync(Camionete entity)
        {
            _context.Camionetes.Add(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten != 1)
                return null;

            return entity;
        }

        public async Task<bool> ChangeColorAsync(int id, string color)
        {
            Camionete? camionete = await GetByIdAsync(id);
            if (camionete == null)
                return false;

            camionete.Cor = color;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangePriceAsync(int id, double price)
        {
            Camionete? camionete = await GetByIdAsync(id);
            if (camionete == null)
                return false;

            camionete.Valor = price;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> SellAsync(int id)
        {
            Camionete? camionete = await GetByIdAsync(id);
            if (camionete == null)
                return false;

            camionete.Disponivel = false;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Camionete?> GetByIdAsync(int id)
        {
            return await _context.Camionetes.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> UpdateAsync(Camionete entity)
        {
            _context.Camionetes.Update(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten != 1)
                return false;

            return true;
        }
    }
}
