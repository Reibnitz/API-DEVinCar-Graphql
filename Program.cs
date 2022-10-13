using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Graphql;
using API_DEVinCar_Graphql.Repositories;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using API_DEVinCar_Graphql.Services;
using API_DEVinCar_Graphql.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DEVInCarContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection"));
    opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
}
    );

builder.Services
    .AddTransient<ICarroRepository, CarroRepository>()
    .AddTransient<ICamioneteRepository, CamioneteRepository>()
    .AddTransient<IMotoTricicloRepository, MotoTricicloRepository>()
    .AddTransient<IVendaRepository, VendaRepository>()
    .AddScoped<IQueriesService, QueriesService>()
    .AddScoped<IMutationsService, MutationsService>()
;

builder.Services
    .AddGraphQLServer()
    .AddAuthorization()
    .AddQueryType()
        .AddTypeExtension<VeiculoQueries>()
    .AddMutationType()
        .AddTypeExtension<VeiculoMutations>()
    .AddSubscriptionType()
        .AddTypeExtension<VeiculoSubscriptions>()
    .AddInMemorySubscriptions()
;

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseWebSockets();

//app.UseAuthorization();

app.UseEndpoints(endpoint => endpoint.MapGraphQL());

app.Run();
