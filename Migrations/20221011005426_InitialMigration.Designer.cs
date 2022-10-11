﻿// <auto-generated />
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
    [Migration("20221011005426_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            Id = new Guid("a9e8c0e0-5fbb-4bf8-a5fb-4ac37e73c366"),
                            CapacidadeCacamba = 844,
                            Chassi = new Guid("ec2379f8-64bf-475a-9b2c-b14ef0c33941"),
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
                            Id = new Guid("4d0954c9-a839-42e1-ac63-ddba842a9ee2"),
                            CapacidadeCacamba = 1570,
                            Chassi = new Guid("56527178-f900-42bf-8e96-508ab6baa850"),
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
                            Id = new Guid("8ed91d54-c32f-4807-8c12-89069c880222"),
                            CapacidadeCacamba = 580,
                            Chassi = new Guid("5f3f5bac-7d48-438c-868e-a87baf09b752"),
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
                            Id = new Guid("6c4d47c7-dd86-495d-bc91-fb7636c75d95"),
                            Chassi = new Guid("1098f6c0-0d5c-4179-8ab7-4183a9909271"),
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
                            Id = new Guid("a51ce045-2fb7-4df0-bd7b-d429f969cd17"),
                            Chassi = new Guid("4c8e9245-af19-4b9b-9236-5e4546482cdf"),
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
                            Id = new Guid("7a5970e1-2748-455a-ad19-1877da5a0194"),
                            Chassi = new Guid("cc32b499-f2b1-4e25-923b-944075977a05"),
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
                            Id = new Guid("9c62c42d-82f9-4158-8ff3-307d660603f9"),
                            Chassi = new Guid("0b3d6b03-355b-461d-89db-f28dd3209b99"),
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
                            Id = new Guid("7042adac-000f-4d15-ba08-460e37674d0d"),
                            Chassi = new Guid("96f46267-0e99-4b17-a1d2-e82671bd94ec"),
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
                            Id = new Guid("2007b3ca-f4d7-480a-afab-f37e8baa7b68"),
                            Chassi = new Guid("04ee22ba-812b-4419-a764-ff139a90fb3e"),
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