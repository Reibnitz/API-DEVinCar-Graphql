﻿// <auto-generated />
using System;
using API_DEVinCar_Graphql.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_DEVinCar_Graphql.Migrations
{
    [DbContext(typeof(DEVInCarContext))]
    partial class DEVInCarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("TipoVeiculo")
                        .HasColumnType("int");

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
                            Id = new Guid("c53f421e-451b-4f34-a85b-4fe0ae871786"),
                            CapacidadeCacamba = 844,
                            Chassi = new Guid("f5d09161-665a-4bc7-b814-e944f97f8eda"),
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
                            Id = new Guid("ae762e66-5c35-4731-82b9-ba4ac374c3c3"),
                            CapacidadeCacamba = 1570,
                            Chassi = new Guid("4720aa28-ad3f-4edb-a58c-b289eb20cc55"),
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
                            Id = new Guid("7f9bec68-a0ac-4be4-9162-a0aeee2f9c2e"),
                            CapacidadeCacamba = 580,
                            Chassi = new Guid("ee09ae16-ffc1-4153-a963-1bf115288500"),
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
                            Id = new Guid("97a3bab5-23c2-4d56-905c-73e7272077e7"),
                            Chassi = new Guid("87c34833-142e-4d40-9ca8-d9d27a466b4c"),
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
                            Id = new Guid("340bedd5-45f6-4f22-9860-9e977870b987"),
                            Chassi = new Guid("4f3b5f27-f9cb-4752-a8b3-34dfc75dddda"),
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
                            Id = new Guid("c17ab273-351e-464c-b7f6-c158a1ecd9b2"),
                            Chassi = new Guid("03a2e6ed-36f4-420e-952f-d105bb2ec47c"),
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
                            Id = new Guid("638290e2-fea7-421f-bb79-6fb2dbce50d7"),
                            Chassi = new Guid("8c27a3db-c322-43e5-9c54-7d8861a8bd3a"),
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
                            Id = new Guid("064eb80f-9837-408a-8b19-6f13ceec28b8"),
                            Chassi = new Guid("ab91645f-01cf-4af0-a1a1-ee87895a8d11"),
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
                            Id = new Guid("a56c8cae-1f7e-4f6e-980a-b6c1e63efdea"),
                            Chassi = new Guid("07b09595-bef1-4dbf-8949-59f557df2d8a"),
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
