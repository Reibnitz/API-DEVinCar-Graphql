using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DEVinCar_Graphql.Migrations
{
    public partial class AddTipoVeiculoToVendas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "TipoVeiculo",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Camionetes",
                columns: new[] { "Id", "CapacidadeCacamba", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Portas", "Potencia", "TipoCombustivel", "Valor" },
                values: new object[,]
                {
                    { new Guid("7f9bec68-a0ac-4be4-9162-a0aeee2f9c2e"), 580, new Guid("ee09ae16-ffc1-4153-a963-1bf115288500"), "Azul", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saveiro", "CAM-0397", 2, 71.0, 1, 99000.0 },
                    { new Guid("ae762e66-5c35-4731-82b9-ba4ac374c3c3"), 1570, new Guid("4720aa28-ad3f-4edb-a58c-b289eb20cc55"), "Vermelho", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hilux", "CAM-0397", 4, 204.0, 1, 260390.0 },
                    { new Guid("c53f421e-451b-4f34-a85b-4fe0ae871786"), 844, new Guid("f5d09161-665a-4bc7-b814-e944f97f8eda"), "Prata", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Strada", "CAM-0397", 2, 107.0, 0, 109990.0 }
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Flex", "Nome", "Placa", "Portas", "Potencia", "Valor" },
                values: new object[,]
                {
                    { new Guid("340bedd5-45f6-4f22-9860-9e977870b987"), new Guid("4f3b5f27-f9cb-4752-a8b3-34dfc75dddda"), "Vermelho", new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Uno", "XYZ-6789", 2, 65.0, 24999.900000000001 },
                    { new Guid("97a3bab5-23c2-4d56-905c-73e7272077e7"), new Guid("87c34833-142e-4d40-9ca8-d9d27a466b4c"), "Vermelho", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kwid", "ABC-1234", 4, 71.0, 59999.900000000001 },
                    { new Guid("c17ab273-351e-464c-b7f6-c158a1ecd9b2"), new Guid("03a2e6ed-36f4-420e-952f-d105bb2ec47c"), "Preto", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ka", "AAA-1111", 4, 71.0, 49999.900000000001 }
                });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Potencia", "Rodas", "Valor" },
                values: new object[,]
                {
                    { new Guid("064eb80f-9837-408a-8b19-6f13ceec28b8"), new Guid("ab91645f-01cf-4af0-a1a1-ee87895a8d11"), "Preto", new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "CG-160", "FED-5193", 14.9, 2, 10520.0 },
                    { new Guid("638290e2-fea7-421f-bb79-6fb2dbce50d7"), new Guid("8c27a3db-c322-43e5-9c54-7d8861a8bd3a"), "Azul", new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Biz", "ASD-4123", 8.3300000000000001, 2, 8900.0 },
                    { new Guid("a56c8cae-1f7e-4f6e-980a-b6c1e63efdea"), new Guid("07b09595-bef1-4dbf-8949-59f557df2d8a"), "Preto", new DateTime(2017, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spider", "BSC-9297", 21.0, 3, 16999.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("7f9bec68-a0ac-4be4-9162-a0aeee2f9c2e"));

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("ae762e66-5c35-4731-82b9-ba4ac374c3c3"));

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("c53f421e-451b-4f34-a85b-4fe0ae871786"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("340bedd5-45f6-4f22-9860-9e977870b987"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("97a3bab5-23c2-4d56-905c-73e7272077e7"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("c17ab273-351e-464c-b7f6-c158a1ecd9b2"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("064eb80f-9837-408a-8b19-6f13ceec28b8"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("638290e2-fea7-421f-bb79-6fb2dbce50d7"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("a56c8cae-1f7e-4f6e-980a-b6c1e63efdea"));

            migrationBuilder.DropColumn(
                name: "TipoVeiculo",
                table: "Vendas");

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
    }
}
