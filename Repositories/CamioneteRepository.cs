using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Models;
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

        public async Task<IList<Camionete>> GetAll()
        {
            return await _context.Camionetes.ToListAsync();
        }

        public async Task<IList<Camionete>> GetAvailable()
        {
            return await _context.Camionetes.Where(camionete => camionete.Disponivel == true).ToListAsync();
        }

        public async Task<IList<Camionete>> GetSold()
        {
            return await _context.Camionetes.Where(camionete => camionete.Disponivel == false).ToListAsync();
        }
    }
}
