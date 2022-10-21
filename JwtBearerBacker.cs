using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace API_DEVinCar_Graphql
{
    public class JwtBearerBacker
    {
        public JwtBearerOptions Options { get; private set; }

        public JwtBearerBacker(JwtBearerOptions options)
        {
            this.Options = options;
        
        }

        public ClaimsPrincipal IsJwtValid(string token)
        {
            Options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidIssuer = "DEVinCar",
                ValidateAudience = true,
                ValidAudience = "API",
                ValidateLifetime = true,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("7f9bec68-a0ac-4be4-9162-a0aeee2f9c2e")),
            };

            List<Exception> validationFailures = null;
            SecurityToken validatedToken;
            foreach (var validator in Options.SecurityTokenValidators)
            {
                // Ensure we can even read the token at all
                if (validator.CanReadToken(token))
                {
                    try
                    {
                        // Try to return a ClaimsPrincipal if we can
                        // Otherwise an exception is thrown, caught and we continue on.
                        return validator
                            .ValidateToken(token, Options.TokenValidationParameters, out validatedToken);
                    }
                    catch (Exception ex)
                    {
                        // If the keys are invalid, refresh config
                        if (Options.RefreshOnIssuerKeyNotFound && Options.ConfigurationManager != null
                            && ex is SecurityTokenSignatureKeyNotFoundException)
                        {
                            Options.ConfigurationManager.RequestRefresh();
                        }

                        // Add to our list of failures. This was from the OG code
                        // Not sure what we need it for.
                        if (validationFailures == null)
                            validationFailures = new List<Exception>(1);

                        validationFailures.Add(ex);
                        continue;
                    }
                }
            }

            // No user could be found
            return null;
        }
    }
}
