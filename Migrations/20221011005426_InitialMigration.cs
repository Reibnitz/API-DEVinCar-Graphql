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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Camionetes",
                columns: new[] { "Id", "CapacidadeCacamba", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Portas", "Potencia", "TipoCombustivel", "Valor" },
                values: new object[,]
                {
                    { new Guid("4d0954c9-a839-42e1-ac63-ddba842a9ee2"), 1570, new Guid("56527178-f900-42bf-8e96-508ab6baa850"), "Vermelho", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hilux", "CAM-0397", 4, 204.0, 1, 260390.0 },
                    { new Guid("8ed91d54-c32f-4807-8c12-89069c880222"), 580, new Guid("5f3f5bac-7d48-438c-868e-a87baf09b752"), "Azul", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saveiro", "CAM-0397", 2, 71.0, 1, 99000.0 },
                    { new Guid("a9e8c0e0-5fbb-4bf8-a5fb-4ac37e73c366"), 844, new Guid("ec2379f8-64bf-475a-9b2c-b14ef0c33941"), "Prata", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Strada", "CAM-0397", 2, 107.0, 0, 109990.0 }
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Flex", "Nome", "Placa", "Portas", "Potencia", "Valor" },
                values: new object[,]
                {
                    { new Guid("6c4d47c7-dd86-495d-bc91-fb7636c75d95"), new Guid("1098f6c0-0d5c-4179-8ab7-4183a9909271"), "Vermelho", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kwid", "ABC-1234", 4, 71.0, 59999.900000000001 },
                    { new Guid("7a5970e1-2748-455a-ad19-1877da5a0194"), new Guid("cc32b499-f2b1-4e25-923b-944075977a05"), "Preto", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ka", "AAA-1111", 4, 71.0, 49999.900000000001 },
                    { new Guid("a51ce045-2fb7-4df0-bd7b-d429f969cd17"), new Guid("4c8e9245-af19-4b9b-9236-5e4546482cdf"), "Vermelho", new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Uno", "XYZ-6789", 2, 65.0, 24999.900000000001 }
                });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Potencia", "Rodas", "Valor" },
                values: new object[,]
                {
                    { new Guid("2007b3ca-f4d7-480a-afab-f37e8baa7b68"), new Guid("04ee22ba-812b-4419-a764-ff139a90fb3e"), "Preto", new DateTime(2017, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spider", "BSC-9297", 21.0, 3, 16999.0 },
                    { new Guid("7042adac-000f-4d15-ba08-460e37674d0d"), new Guid("96f46267-0e99-4b17-a1d2-e82671bd94ec"), "Preto", new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "CG-160", "FED-5193", 14.9, 2, 10520.0 },
                    { new Guid("9c62c42d-82f9-4158-8ff3-307d660603f9"), new Guid("0b3d6b03-355b-461d-89db-f28dd3209b99"), "Azul", new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Biz", "ASD-4123", 8.3300000000000001, 2, 8900.0 }
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
