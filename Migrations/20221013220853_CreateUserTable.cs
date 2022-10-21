using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DEVinCar_Graphql.Migrations
{
    public partial class CreateUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Camionetes",
                columns: new[] { "Id", "CapacidadeCacamba", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Portas", "Potencia", "TipoCombustivel", "Valor" },
                values: new object[,]
                {
                    { new Guid("0a06a528-b0d4-478f-9e46-8fbdcf968656"), 1570, new Guid("57cc67e5-8d02-4f59-bb56-fea7c3234578"), "Vermelho", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hilux", "CAM-0397", 4, 204.0, 1, 260390.0 },
                    { new Guid("618a7c35-d24b-4abb-a7f0-ab817f4b0b4f"), 844, new Guid("7235ccf6-3d11-43cd-a1c0-3fb1b0a5457a"), "Prata", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Strada", "CAM-0397", 2, 107.0, 0, 109990.0 },
                    { new Guid("6ddebc97-c982-42ec-b4a7-595c5e2c2780"), 580, new Guid("9a2cb7aa-b622-4d7e-83b2-a269e93fb282"), "Azul", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saveiro", "CAM-0397", 2, 71.0, 1, 99000.0 }
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Flex", "Nome", "Placa", "Portas", "Potencia", "Valor" },
                values: new object[,]
                {
                    { new Guid("2e01ffcc-45d8-403b-a9cc-479759c97863"), new Guid("88fb13f8-3ece-4557-ac90-a5517b39a825"), "Preto", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ka", "AAA-1111", 4, 71.0, 49999.900000000001 },
                    { new Guid("87908bb1-babc-4962-95c8-cd7f3567cf40"), new Guid("95cf1da5-f23b-41f4-9e66-dd882b3576a0"), "Vermelho", new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Uno", "XYZ-6789", 2, 65.0, 24999.900000000001 },
                    { new Guid("e3237070-74bb-4f97-b2e1-393d088ee5e6"), new Guid("cb2f670a-b60e-44a6-a201-8479ca22703e"), "Vermelho", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kwid", "ABC-1234", 4, 71.0, 59999.900000000001 }
                });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "Chassi", "Cor", "DataFabricacao", "Disponivel", "Nome", "Placa", "Potencia", "Rodas", "Valor" },
                values: new object[,]
                {
                    { new Guid("1b263804-998e-44cf-a818-6b376d6cfedc"), new Guid("7b16cf57-91c0-4be3-a8ca-f93ecda23832"), "Preto", new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "CG-160", "FED-5193", 14.9, 2, 10520.0 },
                    { new Guid("5d6b5502-a08e-48db-8057-b635ba5cf400"), new Guid("89e26b63-660f-44b1-a620-9b2247df0a4b"), "Preto", new DateTime(2017, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spider", "BSC-9297", 21.0, 3, 16999.0 },
                    { new Guid("e7eb6563-8ca1-446d-9e3b-28617196fec5"), new Guid("3ea9c277-4e2c-4d0e-9079-bd735a094d7e"), "Azul", new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Biz", "ASD-4123", 8.3300000000000001, 2, 8900.0 }
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
                name: "Usuarios");

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("0a06a528-b0d4-478f-9e46-8fbdcf968656"));

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("618a7c35-d24b-4abb-a7f0-ab817f4b0b4f"));

            migrationBuilder.DeleteData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: new Guid("6ddebc97-c982-42ec-b4a7-595c5e2c2780"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("2e01ffcc-45d8-403b-a9cc-479759c97863"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("87908bb1-babc-4962-95c8-cd7f3567cf40"));

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: new Guid("e3237070-74bb-4f97-b2e1-393d088ee5e6"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("1b263804-998e-44cf-a818-6b376d6cfedc"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("5d6b5502-a08e-48db-8057-b635ba5cf400"));

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: new Guid("e7eb6563-8ca1-446d-9e3b-28617196fec5"));

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
    }
}
