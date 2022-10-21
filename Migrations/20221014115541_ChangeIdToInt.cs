using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DEVinCar_Graphql.Migrations
{
    public partial class ChangeIdToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Camionetes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Potencia = table.Column<double>(type: "float", nullable: false),
                    Portas = table.Column<int>(type: "int", nullable: false),
                    TipoCombustivel = table.Column<int>(type: "int", nullable: false),
                    CapacidadeCacamba = table.Column<int>(type: "int", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    Chassi = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camionetes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Potencia = table.Column<double>(type: "float", nullable: false),
                    Portas = table.Column<int>(type: "int", nullable: false),
                    Flex = table.Column<bool>(type: "bit", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    Chassi = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotoTriciclos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Potencia = table.Column<double>(type: "float", nullable: false),
                    Rodas = table.Column<int>(type: "int", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    Chassi = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoTriciclos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeiculoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoVeiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Camionetes",
                columns: new[] { "Id", "CapacidadeCacamba", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Portas", "Potencia", "TipoCombustivel", "Valor" },
                values: new object[,]
                {
                    { 1, 844, new Guid("84ef5d8a-e9d0-4383-b3cd-aaf4664a82be"), "Prata", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Strada", "CAM-0397", 2, 107.0, 0, 109990.0 },
                    { 2, 1570, new Guid("a3dc3c2b-5a73-41c5-8a00-4125ce3e47e3"), "Vermelho", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hilux", "CAM-0397", 4, 204.0, 1, 260390.0 },
                    { 3, 580, new Guid("8be076ae-d989-4d60-9612-5791395ac969"), "Azul", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saveiro", "CAM-0397", 2, 71.0, 1, 99000.0 }
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Flex", "Nome", "Placa", "Portas", "Potencia", "Valor" },
                values: new object[,]
                {
                    { 1, new Guid("bdacb84e-8a29-47db-a0fa-f7c6dd2c2db4"), "Vermelho", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kwid", "ABC-1234", 4, 71.0, 59999.900000000001 },
                    { 2, new Guid("5fcceea7-8346-4927-8409-06a596433f4b"), "Vermelho", new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Uno", "XYZ-6789", 2, 65.0, 24999.900000000001 },
                    { 3, new Guid("f8992d7a-82e8-4525-a835-9bade808d198"), "Preto", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ka", "AAA-1111", 4, 71.0, 49999.900000000001 }
                });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Potencia", "Rodas", "Valor" },
                values: new object[,]
                {
                    { 1, new Guid("287f00e6-ea6e-4f37-a9ea-0936f6d75d7d"), "Azul", new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Biz", "ASD-4123", 8.3300000000000001, 2, 8900.0 },
                    { 2, new Guid("f7dd0745-66f0-4e75-91f9-33b01c24d5a0"), "Preto", new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "CG-160", "FED-5193", 14.9, 2, 10520.0 },
                    { 3, new Guid("97068bbc-fdee-4740-8ebe-ae56ef5dae63"), "Preto", new DateTime(2017, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spider", "BSC-9297", 21.0, 3, 16999.0 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "123456", "Yan" },
                    { 2, "654321", "Fernando" },
                    { 3, "qwerty", "Lucas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camionetes");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "MotoTriciclos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
