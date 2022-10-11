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

        public async Task<List<Carro>> GetAll()
        {
            return await _context.Carros.ToListAsync();
        }

        public async Task<List<Carro>> GetAvailable()
        {
            return await _context.Carros.Where(carro => carro.Disponivel == true).ToListAsync();
        }

        public async Task<List<Carro>> GetSold()
        {
            return await _context.Carros.Where(carro => carro.Disponivel == false).ToListAsync();
        }

        public async Task<bool> Add(Carro entity)
        {
            _context.Carros.Add(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten == 0)
                return false;

            return true;
        }

        public async Task<bool> ChangeColor(Guid id, string color)
        {
            Carro? carro = await GetById(id);
            if (carro == null)
                return false;

            carro.Cor = color;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangePrice(Guid id, double price)
        {
            Carro? carro = await GetById(id);
            if (carro == null)
                return false;

            carro.Valor = price;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Sell(Guid id)
        {
            Carro? carro = await GetById(id);
            if (carro == null)
                return false;

            carro.Disponivel = false;
            await _context.SaveChangesAsync();

            return true;
        }

        private async Task<Carro?> GetById(Guid id)
        {
            return await _context.Carros.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
