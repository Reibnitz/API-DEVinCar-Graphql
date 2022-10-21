using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DEVinCar_Graphql.Migrations
{
    public partial class AddTableVendas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("4d0954c9-a839-42e1-ac63-ddba842a9ee2"));

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("8ed91d54-c32f-4807-8c12-89069c880222"));

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("a9e8c0e0-5fbb-4bf8-a5fb-4ac37e73c366"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("6c4d47c7-dd86-495d-bc91-fb7636c75d95"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("7a5970e1-2748-455a-ad19-1877da5a0194"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("a51ce045-2fb7-4df0-bd7b-d429f969cd17"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("2007b3ca-f4d7-480a-afab-f37e8baa7b68"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("7042adac-000f-4d15-ba08-460e37674d0d"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("9c62c42d-82f9-4158-8ff3-307d660603f9"));

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { new Guid("691faf5d-4408-4ff9-9ba7-4b006b32a7fd"), 1570, new Guid("1ff4df30-5bff-4489-844a-af644717eef7"), "Vermelho", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hilux", "CAM-0397", 4, 204.0, 1, 260390.0 },
                    { new Guid("ae2facd6-a5d9-49a9-83ef-f99050161de9"), 844, new Guid("550f4814-3e3c-43d8-8768-2d18c0da334b"), "Prata", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Strada", "CAM-0397", 2, 107.0, 0, 109990.0 },
                    { new Guid("c4fd12d2-7947-4c7a-a0b6-b19adc02ea36"), 580, new Guid("893af09e-fdb0-4f98-af7f-b50ae1026a93"), "Azul", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saveiro", "CAM-0397", 2, 71.0, 1, 99000.0 }
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Flex", "Nome", "Placa", "Portas", "Potencia", "Valor" },
                values: new object[,]
                {
                    { new Guid("182916d4-7aec-404d-8cc3-cb9165761018"), new Guid("b29819e9-71d6-49c1-ae81-40efa8e8366b"), "Vermelho", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kwid", "ABC-1234", 4, 71.0, 59999.900000000001 },
                    { new Guid("b1575318-11ee-4fd4-97e2-d936802eadbc"), new Guid("f0a8141d-fc5f-4d91-a4af-d66b80a5b0b4"), "Vermelho", new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Uno", "XYZ-6789", 2, 65.0, 24999.900000000001 },
                    { new Guid("b9938358-60ab-4395-ba6e-c4f3a86e6720"), new Guid("10a365e6-5608-4e70-9f3b-af60455f1d40"), "Preto", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ka", "AAA-1111", 4, 71.0, 49999.900000000001 }
                });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Potencia", "Rodas", "Valor" },
                values: new object[,]
                {
                    { new Guid("172d9b02-e41c-4cb2-95f9-a891d5f6dc84"), new Guid("4546550b-f44e-4e4e-923d-d79a63d31549"), "Preto", new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "CG-160", "FED-5193", 14.9, 2, 10520.0 },
                    { new Guid("8a3ddf35-5538-48e6-ab0f-6ae4f7653f54"), new Guid("41505bca-4c51-49bb-8caa-73836e08140d"), "Azul", new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Biz", "ASD-4123", 8.3300000000000001, 2, 8900.0 },
                    { new Guid("eabc2dcf-9646-4120-bd55-5063fc54cb47"), new Guid("0bc5474d-ea03-4b26-b2be-8abeb17a441f"), "Preto", new DateTime(2017, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spider", "BSC-9297", 21.0, 3, 16999.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("691faf5d-4408-4ff9-9ba7-4b006b32a7fd"));

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("ae2facd6-a5d9-49a9-83ef-f99050161de9"));

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("c4fd12d2-7947-4c7a-a0b6-b19adc02ea36"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("182916d4-7aec-404d-8cc3-cb9165761018"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("b1575318-11ee-4fd4-97e2-d936802eadbc"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("b9938358-60ab-4395-ba6e-c4f3a86e6720"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("172d9b02-e41c-4cb2-95f9-a891d5f6dc84"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("8a3ddf35-5538-48e6-ab0f-6ae4f7653f54"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("eabc2dcf-9646-4120-bd55-5063fc54cb47"));

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
    }
}
