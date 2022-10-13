using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Services.Interfaces;

namespace API_DEVinCar_Graphql.Graphql
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class LoginMutation
    {
        [GraphQLName("Login")]
        [GraphQLDescription("Retorna resultado da solicitação de login")]
        public async Task<string> Login(Login login, [Service] IUsuarioMutationService service)
        {
            return await service.Login(login);
        }
    }
}
