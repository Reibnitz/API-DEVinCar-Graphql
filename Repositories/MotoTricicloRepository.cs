using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_DEVinCar_Graphql.Repositories
{

    public class MotoTricicloRepository : IMotoTricicloRepository
    {
        private readonly DEVInCarContext _context;

        public MotoTricicloRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public async Task<List<MotoTriciclo>> GetAll()
        {
            return await _context.MotoTriciclos.ToListAsync();
        }

        public async Task<List<MotoTriciclo>> GetAvailable()
        {
            return await _context.MotoTriciclos.Where(moto => moto.Disponivel == true).ToListAsync();
        }

        public async Task<List<MotoTriciclo>> GetSold()
        {
            return await _context.MotoTriciclos.Where(moto => moto.Disponivel == false).ToListAsync();
        }

        public async Task<bool> Add(MotoTriciclo entity)
        {
            _context.MotoTriciclos.Add(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten == 0)
                return false;

            return true;
        }

        public async Task<bool> Sell(Guid id)
        {
            MotoTriciclo? motoTriciclo = await GetById(id);
            if (motoTriciclo == null)
                return false;

            motoTriciclo.Disponivel = false;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangeColor(Guid id, string color)
        {
            MotoTriciclo? motoTriciclo = await GetById(id);
            if (motoTriciclo == null)
                return false;

            motoTriciclo.Cor = color;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangePrice(Guid id, double price)
        {
            MotoTriciclo? motoTriciclo = await GetById(id);
            if (motoTriciclo == null)
                return false;

            motoTriciclo.Valor = price;
            await _context.SaveChangesAsync();

            return true;
        }

        private async Task<MotoTriciclo?> GetById(Guid id)
        {
            return await _context.MotoTriciclos.FirstOrDefaultAsync(mt => mt.Id == id);
        }
    }
}
