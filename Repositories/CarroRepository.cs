using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace API_DEVinCar_Graphql.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private readonly DEVInCarContext _context;

        public CarroRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public async Task<List<Carro>> GetAllAsync()
        {
            return await _context.Carros.ToListAsync();
        }

        public async Task<List<Carro>> GetAvailableAsync()
        {
            return await _context.Carros.Where(carro => carro.Disponivel == true).ToListAsync();
        }

        public async Task<List<Carro>> GetSoldAsync()
        {
            return await _context.Carros.Where(carro => carro.Disponivel == false).ToListAsync();
        }

        public async Task<Carro?> AddAsync(Carro entity)
        {
            _context.Carros.Add(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten != 1)
                return null;

            return entity;
        }

        public async Task<bool> ChangeColorAsync(int id, string color)
        {
            Carro? carro = await GetByIdAsync(id);
            if (carro == null)
                return false;

            carro.Cor = color;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangePriceAsync(int id, double price)
        {
            Carro? carro = await GetByIdAsync(id);
            if (carro == null)
                return false;

            carro.Valor = price;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> SellAsync(int id)
        {
            Carro? carro = await GetByIdAsync(id);
            if (carro == null)
                return false;

            carro.Disponivel = false;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Carro?> GetByIdAsync(int id)
        {
            return await _context.Carros.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> UpdateAsync(Carro entity)
        {
            _context.Carros.Update(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten != 1)
                return false;

            return true;
        }
    }
}
