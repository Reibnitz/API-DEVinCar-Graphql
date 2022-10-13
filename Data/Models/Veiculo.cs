using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Models;
using HotChocolate.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace API_DEVinCar_Graphql.Data.Models
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        [Authorize]
        public Guid Chassi { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Nome { get; set; }
        [Authorize]
        public string Placa { get; set; }
        public double Valor { get; set; }
        public string Cor { get; set; }
        public bool Disponivel { get; set; }
        public double Potencia { get; set; }
        public int? Portas { get; set; }
        public ECombustivel? TipoCombustivel { get; set; }
        public int? CapacidadeCacamba { get; set; }
        public bool? Flex { get; set; }
        public int? Rodas { get; set; }

        public static explicit operator MotoTriciclo?(Veiculo v)
        {
            if (v.Rodas == null)
                return null;

            return new MotoTriciclo
            {
                Id = v.Id,
                Chassi = v.Chassi,
                DataFabricacao = v.DataFabricacao,
                Nome = v.Nome,
                Placa = v.Placa,
                Valor = v.Valor,
                Cor = v.Cor,
                Disponivel = v.Disponivel,
                Potencia = v.Potencia,
                Rodas = (int)v.Rodas
            };
        }

        public static explicit operator Carro?(Veiculo v)
        {
            if (v.Flex == null)
                return null;

            return new Carro
            {
                Id = v.Id,
                Chassi = v.Chassi,
                DataFabricacao = v.DataFabricacao,
                Nome = v.Nome,
                Placa = v.Placa,
                Valor = v.Valor,
                Cor = v.Cor,
                Disponivel = v.Disponivel,
                Potencia = v.Potencia,
                Portas = (int)v.Portas,
                Flex = (bool)v.Flex,
            };
        }

        public static explicit operator Camionete?(Veiculo v)
        {
            if (v.CapacidadeCacamba == null)
                return null;

            return new Camionete
            {
                Id = v.Id,
                Chassi = v.Chassi,
                DataFabricacao = v.DataFabricacao,
                Nome = v.Nome,
                Placa = v.Placa,
                Valor = v.Valor,
                Cor = v.Cor,
                Disponivel = v.Disponivel,
                Potencia = v.Potencia,
                CapacidadeCacamba = (int)v.CapacidadeCacamba,
                TipoCombustivel = (ECombustivel)v.TipoCombustivel,
                Portas = (int)v.Portas
            };
        }

    }
}