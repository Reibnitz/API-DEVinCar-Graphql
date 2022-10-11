using API_DEVinCar_Graphql.Data;
using API_DEVinCar_Graphql.Graphql;
using API_DEVinCar_Graphql.Repositories;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using API_DEVinCar_Graphql.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DEVInCarContext>(
    opts => opts.UseSqlServer(
    builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services
    .AddScoped<ICarroRepository, CarroRepository>()
    .AddScoped<ICamioneteRepository, CamioneteRepository>()
    .AddScoped<IMotoTricicloRepository, MotoTricicloRepository>()
    .AddScoped<IListagemService, ListagemService>();

builder.Services
    .AddGraphQLServer()
    .AddAuthorization()
    .AddQueryType()
        .AddTypeExtension<VeiculoQueries>();

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
