﻿using API_DEVinCar_Graphql.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace API_DEVinCar_Graphql.Data.Models
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public Guid Chassi { get;  set; }
        public DateTime DataFabricacao { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
        public string Cor { get; set; }
        public bool Disponivel { get; set; }
        public double Potencia { get; set; }
        public int Portas { get; set; }
        public ECombustivel TipoCombustivel { get; set; }
        public int CapacidadeCacamba { get; set; }
        public bool Flex { get; set; }
        public int Rodas { get; set; }
    }
}