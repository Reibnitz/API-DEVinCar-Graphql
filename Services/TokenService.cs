using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace API_DEVinCar_Graphql.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateToken(Login login)
        {
            var issuedAt = DateTime.UtcNow;
            var expires = issuedAt.AddHours(3);
            var handler = new JwtSecurityTokenHandler();

            var properties = new SecurityTokenDescriptor()
            {
                Issuer = _configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
                IssuedAt = issuedAt,
                Expires = expires,
                Audience = _configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_configuration.GetSection("TokenSettings").GetValue<string>("Key"))
                    ),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            return handler.WriteToken(handler.CreateToken(properties));
        }
    }
}
