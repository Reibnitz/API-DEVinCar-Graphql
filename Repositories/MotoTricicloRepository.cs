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

        public async Task<List<MotoTriciclo>> GetAllAsync()
        {
            return await _context.MotoTriciclos.ToListAsync();
        }

        public async Task<List<MotoTriciclo>> GetAvailableAsync()
        {
            return await _context.MotoTriciclos.Where(moto => moto.Disponivel == true).ToListAsync();
        }

        public async Task<List<MotoTriciclo>> GetSoldAsync()
        {
            return await _context.MotoTriciclos.Where(moto => moto.Disponivel == false).ToListAsync();
        }

        public async Task<MotoTriciclo?> AddAsync(MotoTriciclo entity)
        {
            _context.MotoTriciclos.Add(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten != 1)
                return null;

            return entity;
        }

        public async Task<bool> SellAsync(int id)
        {
            MotoTriciclo? motoTriciclo = await GetByIdAsync(id);
            if (motoTriciclo == null)
                return false;

            motoTriciclo.Disponivel = false;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangeColorAsync(int id, string color)
        {
            MotoTriciclo? motoTriciclo = await GetByIdAsync(id);
            if (motoTriciclo == null)
                return false;

            motoTriciclo.Cor = color;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangePriceAsync(int id, double price)
        {
            MotoTriciclo? motoTriciclo = await GetByIdAsync(id);
            if (motoTriciclo == null)
                return false;

            motoTriciclo.Valor = price;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<MotoTriciclo?> GetByIdAsync(int id)
        {
            return await _context.MotoTriciclos.FirstOrDefaultAsync(mt => mt.Id == id);
        }

        public async Task<bool> UpdateAsync(MotoTriciclo entity)
        {
            _context.MotoTriciclos.Update(entity);
            int entriesWritten = await _context.SaveChangesAsync();

            if (entriesWritten != 1)
                return false;

            return true;
        }
    }
}
