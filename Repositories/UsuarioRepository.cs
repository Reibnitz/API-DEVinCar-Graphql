using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_DEVinCar_Graphql.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DEVInCarContext _context;

        public UsuarioRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public async Task<bool> Login(Login login)
        {
            bool result = await _context.Usuarios.AnyAsync(u =>
                u.Username == login.Username &&
                u.Password == login.Password);

            return result;
        }
    }
}
