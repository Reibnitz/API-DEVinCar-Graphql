using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Dtos
{
    public class CreateMotoTricicloDto
    {
        public double Potencia { get; set; }
        public int Rodas { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
        public string Cor { get; set; }
        public bool Disponivel { get; set; }

        public static implicit operator MotoTriciclo(CreateMotoTricicloDto mt)
        {
            return new MotoTriciclo
            {
                DataFabricacao = mt.DataFabricacao,
                Nome = mt.Nome,
                Placa = mt.Placa,
                Valor = mt.Valor,
                Cor = mt.Cor,
                Disponivel = mt.Disponivel,
                Potencia = mt.Potencia,
                Rodas = mt.Rodas
            };
        }
    }
}
