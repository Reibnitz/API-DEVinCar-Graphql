using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Dtos
{
    public class CreateCamioneteDto
    {
        public double Potencia { get; set; }
        public int Portas { get; set; }
        public ECombustivel TipoCombustivel { get; set; }
        public int CapacidadeCacamba { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
        public string Cor { get; set; }
        public bool Disponivel { get; set; }

        public static implicit operator Camionete(CreateCamioneteDto c)
        {
            return new Camionete
            {
                DataFabricacao = c.DataFabricacao,
                Nome = c.Nome,
                Placa = c.Placa,
                Valor = c.Valor,
                Cor = c.Cor,
                Disponivel = c.Disponivel,
                Potencia = c.Potencia,
                CapacidadeCacamba = c.CapacidadeCacamba,
                TipoCombustivel = c.TipoCombustivel,
                Portas = c.Portas
            };
        }
    }
}
