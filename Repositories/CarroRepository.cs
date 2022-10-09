using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Models;
using Microsoft.EntityFrameworkCore;

namespace API_DEVinCar_Graphql.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private readonly DEVInCarContext _context;

        public CarroRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public async Task<IList<Carro>> GetAll()
        {
            return await _context.Carros.ToListAsync();
        }

        public async Task<IList<Carro>> GetAvailable()
        {
            return await _context.Carros.Where(carro => carro.Disponivel == true).ToListAsync();
        }

        public async Task<IList<Carro>> GetSold()
        {
            return await _context.Carros.Where(carro => carro.Disponivel == false).ToListAsync();
        }
    }
}
