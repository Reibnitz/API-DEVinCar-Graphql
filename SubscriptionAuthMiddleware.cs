using HotChocolate.AspNetCore.Subscriptions.Messages;
using HotChocolate.AspNetCore.Subscriptions;
using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace API_DEVinCar_Graphql
{
    public class SubscriptionAuthMiddleware : ISocketSessionInterceptor
    {
        public async ValueTask OnCloseAsync(ISocketConnection connection, CancellationToken cancellationToken) { }
        public async ValueTask OnRequestAsync(ISocketConnection connection, IQueryRequestBuilder requestBuilder, CancellationToken cancellationToken) { }

        public async ValueTask<ConnectionStatus> OnConnectAsync(ISocketConnection connection, InitializeConnectionMessage message, CancellationToken cancellationToken)
        {
            try
            {
                bool hasToken =  message.Payload.ContainsKey("authorization");
                
                if (hasToken == false)
                    return ConnectionStatus.Reject("Unauthorized (no token provided)");

                string jwtHeader = message.Payload["authorization"] as string;

                if (string.IsNullOrEmpty(jwtHeader) || !jwtHeader.StartsWith("Bearer "))
                    return ConnectionStatus.Reject("Unauthorized");

                var token = jwtHeader.Replace("Bearer ", "");
                var opts = connection.HttpContext.RequestServices.GetRequiredService<JwtBearerOptions>();

                var claims = new JwtBearerBacker(opts).IsJwtValid(token);
                if (claims == null)
                    return ConnectionStatus.Reject("Unauthorized (invalid token)");
                return ConnectionStatus.Accept();
            }
            catch (Exception ex)
            {
                return ConnectionStatus.Reject(ex.Message);
            }
        }
    }
}
