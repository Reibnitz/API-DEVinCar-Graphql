using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using API_DEVinCar_Graphql.Services.Interfaces;

namespace API_DEVinCar_Graphql.Services
{
    public class UsuarioMutationService : IUsuarioMutationService
    {
        private readonly IUsuarioRepository _repository;
        private readonly ITokenService _tokenService;

        public UsuarioMutationService(IUsuarioRepository repository, ITokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
        }

        public async Task<string> Login(Login login)
        {
            bool result = await _repository.Login(login);
            if (result == false)
                return "Usuário e/ou senha incorretos";

            string token = _tokenService.CreateToken(login);

            return token;
        }
    }
}
