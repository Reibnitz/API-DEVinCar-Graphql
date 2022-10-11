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

        public async Task<List<Camionete>> GetAll()
        {
            return await _context.Camionetes.ToListAsync();
        }

        public async Task<List<Camionete>> GetAvailable()
        {
            return await _context.Camionetes.Where(carro => carro.Disponivel == true).ToListAsync();
        }

        public async Task<List<Camionete>> GetSold()
        {
            return await _context.Camionetes.Where(carro => carro.Disponivel == false).ToListAsync();
        }

        public async Task<bool> Add(Camionete entity)
        {
            _context.Camionetes.Add(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten == 0)
                return false;

            return true;
        }

        public async Task<bool> ChangeColor(Guid id, string color)
        {
            Camionete? camionete = await GetById(id);
            if (camionete == null)
                return false;

            camionete.Cor = color;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangePrice(Guid id, double price)
        {
            Camionete? camionete = await GetById(id);
            if (camionete == null)
                return false;

            camionete.Valor = price;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Sell(Guid id)
        {
            Camionete? camionete = await GetById(id);
            if (camionete == null)
                return false;

            camionete.Disponivel = false;
            await _context.SaveChangesAsync();

            return true;
        }

        private async Task<Camionete?> GetById(Guid id)
        {
            return await _context.Camionetes.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
