// <auto-generated />
using System;
using API_DEVinCar_Graphql.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_DEVinCar_Graphql.Migrations
{
    [DbContext(typeof(DEVInCarContext))]
    [Migration("20221012192153_AddTableVendas")]
    partial class AddTableVendas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_DEVinCar_Graphql.Data.Models.Venda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VeiculoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("API_DEVinCar_Graphql.Models.Camionete", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CapacidadeCacamba")
                        .HasColumnType("int");

                    b.Property<Guid>("Chassi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Portas")
                        .HasColumnType("int");

                    b.Property<double>("Potencia")
                        .HasColumnType("float");

                    b.Property<int>("TipoCombustivel")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Camionetes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae2facd6-a5d9-49a9-83ef-f99050161de9"),
                            CapacidadeCacamba = 844,
                            Chassi = new Guid("550f4814-3e3c-43d8-8768-2d18c0da334b"),
                            Cor = "Prata",
                            DataFabricacao = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            Nome = "Strada",
                            Placa = "CAM-0397",
                            Portas = 2,
                            Potencia = 107.0,
                            TipoCombustivel = 0,
                            Valor = 109990.0
                        },
                        new
                        {
                            Id = new Guid("691faf5d-4408-4ff9-9ba7-4b006b32a7fd"),
                            CapacidadeCacamba = 1570,
                            Chassi = new Guid("1ff4df30-5bff-4489-844a-af644717eef7"),
                            Cor = "Vermelho",
                            DataFabricacao = new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = false,
                            Nome = "Hilux",
                            Placa = "CAM-0397",
                            Portas = 4,
                            Potencia = 204.0,
                            TipoCombustivel = 1,
                            Valor = 260390.0
                        },
                        new
                        {
                            Id = new Guid("c4fd12d2-7947-4c7a-a0b6-b19adc02ea36"),
                            CapacidadeCacamba = 580,
                            Chassi = new Guid("893af09e-fdb0-4f98-af7f-b50ae1026a93"),
                            Cor = "Azul",
                            DataFabricacao = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            Nome = "Saveiro",
                            Placa = "CAM-0397",
                            Portas = 2,
                            Potencia = 71.0,
                            TipoCombustivel = 1,
                            Valor = 99000.0
                        });
                });

            modelBuilder.Entity("API_DEVinCar_Graphql.Models.Carro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Chassi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<bool>("Flex")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Portas")
                        .HasColumnType("int");

                    b.Property<double>("Potencia")
                        .HasColumnType("float");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Carros");

                    b.HasData(
                        new
                        {
                            Id = new Guid("182916d4-7aec-404d-8cc3-cb9165761018"),
                            Chassi = new Guid("b29819e9-71d6-49c1-ae81-40efa8e8366b"),
                            Cor = "Vermelho",
                            DataFabricacao = new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = false,
                            Flex = true,
                            Nome = "Kwid",
                            Placa = "ABC-1234",
                            Portas = 4,
                            Potencia = 71.0,
                            Valor = 59999.900000000001
                        },
                        new
                        {
                            Id = new Guid("b1575318-11ee-4fd4-97e2-d936802eadbc"),
                            Chassi = new Guid("f0a8141d-fc5f-4d91-a4af-d66b80a5b0b4"),
                            Cor = "Vermelho",
                            DataFabricacao = new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = false,
                            Flex = true,
                            Nome = "Uno",
                            Placa = "XYZ-6789",
                            Portas = 2,
                            Potencia = 65.0,
                            Valor = 24999.900000000001
                        },
                        new
                        {
                            Id = new Guid("b9938358-60ab-4395-ba6e-c4f3a86e6720"),
                            Chassi = new Guid("10a365e6-5608-4e70-9f3b-af60455f1d40"),
                            Cor = "Preto",
                            DataFabricacao = new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            Flex = false,
                            Nome = "Ka",
                            Placa = "AAA-1111",
                            Portas = 4,
                            Potencia = 71.0,
                            Valor = 49999.900000000001
                        });
                });

            modelBuilder.Entity("API_DEVinCar_Graphql.Models.MotoTriciclo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Chassi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Potencia")
                        .HasColumnType("float");

                    b.Property<int>("Rodas")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MotoTriciclos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a3ddf35-5538-48e6-ab0f-6ae4f7653f54"),
                            Chassi = new Guid("41505bca-4c51-49bb-8caa-73836e08140d"),
                            Cor = "Azul",
                            DataFabricacao = new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            Nome = "Biz",
                            Placa = "ASD-4123",
                            Potencia = 8.3300000000000001,
                            Rodas = 2,
                            Valor = 8900.0
                        },
                        new
                        {
                            Id = new Guid("172d9b02-e41c-4cb2-95f9-a891d5f6dc84"),
                            Chassi = new Guid("4546550b-f44e-4e4e-923d-d79a63d31549"),
                            Cor = "Preto",
                            DataFabricacao = new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            Nome = "CG-160",
                            Placa = "FED-5193",
                            Potencia = 14.9,
                            Rodas = 2,
                            Valor = 10520.0
                        },
                        new
                        {
                            Id = new Guid("eabc2dcf-9646-4120-bd55-5063fc54cb47"),
                            Chassi = new Guid("0bc5474d-ea03-4b26-b2be-8abeb17a441f"),
                            Cor = "Preto",
                            DataFabricacao = new DateTime(2017, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Disponivel = false,
                            Nome = "Spider",
                            Placa = "BSC-9297",
                            Potencia = 21.0,
                            Rodas = 3,
                            Valor = 16999.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
