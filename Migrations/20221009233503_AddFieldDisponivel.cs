using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DEVinCar_Graphql.Migrations
{
    public partial class AddFieldDisponivel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disponivel",
                table: "MotoTriciclos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Disponivel",
                table: "Carros",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Disponivel",
                table: "Camionetes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("875ace45-f2c8-4d93-b9f9-abe85391a233"), true });

            migrationBuilder.UpdateData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("c920752d-dcbe-4f99-aaa8-cab0cd7ae0ec"), true });

            migrationBuilder.UpdateData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("588ec46b-5ecb-4cf9-b3e7-51698375d288"), true });

            migrationBuilder.UpdateData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("75ad5e13-7b29-4c77-9d24-63d559306d5a"), true });

            migrationBuilder.UpdateData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("14c5cd27-4604-4644-8a58-ec68775edc7c"), true });

            migrationBuilder.UpdateData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("9650e290-84fb-493d-93af-c2adf7f77db9"), true });

            migrationBuilder.UpdateData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("33fcdad8-7244-4350-b32e-3c7c1cd8f3cd"), true });

            migrationBuilder.UpdateData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("5098cc08-873c-4948-b917-880e227dc57b"), true });

            migrationBuilder.UpdateData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Chassi", "Disponivel" },
                values: new object[] { new Guid("1c565562-5037-4851-aad2-657c6aff4162"), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "MotoTriciclos");

            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "Camionetes");

            migrationBuilder.UpdateData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Chassi",
                value: new Guid("2b1e1249-86bb-4f62-aafa-a5c7aa9753d6"));

            migrationBuilder.UpdateData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Chassi",
                value: new Guid("5801bba8-aeb9-4a83-8ff1-d9756bd45cd7"));

            migrationBuilder.UpdateData(
                table: "Camionetes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Chassi",
                value: new Guid("c47e66df-612a-44ff-922d-baef9c86fe4d"));

            migrationBuilder.UpdateData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 1,
                column: "Chassi",
                value: new Guid("abd68813-0f00-4021-b038-662ff5057a25"));

            migrationBuilder.UpdateData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 2,
                column: "Chassi",
                value: new Guid("a2a2583b-e389-4e5d-8a26-be2f2f6bae8c"));

            migrationBuilder.UpdateData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 3,
                column: "Chassi",
                value: new Guid("d3d60fbf-e7d4-44ab-a794-af1357225c0c"));

            migrationBuilder.UpdateData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Chassi",
                value: new Guid("7570d177-6363-43c2-98b4-1d03d7741a8d"));

            migrationBuilder.UpdateData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Chassi",
                value: new Guid("43c2aebe-6c0b-460f-963e-a08a2165759b"));

            migrationBuilder.UpdateData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Chassi",
                value: new Guid("55547fba-c977-42c5-9071-aa50266ed74c"));
        }
    }
}
