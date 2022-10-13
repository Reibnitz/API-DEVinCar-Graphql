using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Graphql;
using API_DEVinCar_Graphql.Repositories;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using API_DEVinCar_Graphql.Services;
using API_DEVinCar_Graphql.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DEVInCarContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection"));
    opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
}
    );

builder.Services
    .AddScoped<ICarroRepository, CarroRepository>()
    .AddScoped<ICamioneteRepository, CamioneteRepository>()
    .AddScoped<IMotoTricicloRepository, MotoTricicloRepository>()
    .AddScoped<IVendaRepository, VendaRepository>()
    .AddScoped<IUsuarioRepository, UsuarioRepository>()
    .AddScoped<IUsuarioMutationService, UsuarioMutationService>()
    .AddScoped<ITokenService, TokenService>()
    .AddScoped<IVeiculoQueriesService, VeiculoQueriesService>()
    .AddScoped<IVeiculoMutationsService, VeiculoMutationsService>()
;

builder.Services
    .AddGraphQLServer()
    .AddAuthorization()
    .AddQueryType()
        .AddTypeExtension<VeiculoQueries>()
    .AddMutationType()
        .AddTypeExtension<VeiculoMutations>()
        .AddTypeExtension<LoginMutation>()
    .AddSubscriptionType()
        .AddTypeExtension<VeiculoSubscriptions>()
    .AddInMemorySubscriptions()
;

builder.Services
    .AddAuthorization()
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidAudience = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("TokenSettings").GetValue<string>("Key"))),
        };
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseWebSockets();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint => endpoint.MapGraphQL());

app.Run();
