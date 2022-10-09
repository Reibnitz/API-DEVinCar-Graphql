using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Models;
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

        public async Task<IList<MotoTriciclo>> GetAll()
        {
            return await _context.MotoTriciclos.ToListAsync();
        }

        public async Task<IList<MotoTriciclo>> GetAvailable()
        {
            return await _context.MotoTriciclos.Where(moto => moto.Disponivel == true).ToListAsync();
        }

        public async Task<IList<MotoTriciclo>> GetSold()
        {
            return await _context.MotoTriciclos.Where(moto => moto.Disponivel == false).ToListAsync();
        }
    }
}
