using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DEVinCar_Graphql.Migrations
{
    public partial class InitialMigration : Migration
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
                    Chassi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Chassi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Chassi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoTriciclos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Camionetes",
                columns: new[] { "Id", "CapacidadeCacamba", "Chassi", "Cor", "DataFabricacao", "Name", "Placa", "Portas", "Potencia", "TipoCombustivel", "Valor" },
                values: new object[,]
                {
                    { 1, 844, new Guid("ff0eb4c0-4622-4df3-bb83-e85262e14b74"), "Prata", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strada", "CAM-0397", 2, 107.0, 0, 109990.0 },
                    { 2, 1570, new Guid("0776ea6b-a2dd-4e2a-8a85-a855c9eb1780"), "Vermelho", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hilux", "CAM-0397", 4, 204.0, 1, 260390.0 },
                    { 3, 580, new Guid("e326a6ee-f2cc-406c-8ea7-075d91f41582"), "Azul", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saveiro", "CAM-0397", 2, 71.0, 1, 99000.0 }
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Flex", "Name", "Placa", "Portas", "Potencia", "Valor" },
                values: new object[,]
                {
                    { 1, new Guid("638a9b66-8c4b-43a9-9c60-199fe48f07a9"), "Vermelho", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Kwid", "ABC-1234", 4, 71.0, 59999.900000000001 },
                    { 2, new Guid("d008bd48-af1a-41b5-9538-51aeb970a279"), "Vermelho", new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Uno", "XYZ-6789", 2, 65.0, 24999.900000000001 },
                    { 3, new Guid("b3394c00-b5d9-4991-92eb-8f67fa037ce9"), "Preto", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ka", "AAA-1111", 4, 71.0, 49999.900000000001 }
                });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Name", "Placa", "Potencia", "Rodas", "Valor" },
                values: new object[,]
                {
                    { 1, new Guid("5b3aa894-99e9-4452-983c-56a5e40ab3ba"), "Azul", new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biz", "ASD-4123", 8.3300000000000001, 2, 8900.0 },
                    { 2, new Guid("d2417027-c057-49fe-b851-ccd18bca34d7"), "Preto", new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "CG-160", "FED-5193", 14.9, 2, 10520.0 },
                    { 3, new Guid("14e98e79-c120-483d-9354-c17800747041"), "Preto", new DateTime(2017, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider", "BSC-9297", 21.0, 3, 16999.0 }
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
        }
    }
}
