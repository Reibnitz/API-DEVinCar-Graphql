using API_DEVinCar_Graphql.Models;

namespace API_DEVinCar_Graphql.Data.Dtos
{
    public class CreateCarroDto
    {
        public double Potencia { get; set; }
        public int Portas { get; set; }
        public bool Flex { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
        public string Cor { get; set; }
        public bool Disponivel { get; set; }

        public static implicit operator Carro(CreateCarroDto c)
        {
            return new Carro
            {
                Potencia = c.Potencia,
                Portas = c.Portas,
                Flex = c.Flex,
                DataFabricacao = c.DataFabricacao,
                Nome = c.Nome,
                Placa = c.Placa,
                Valor = c.Valor,
                Cor = c.Cor,
                Disponivel = c.Disponivel,
            };
        }
    }
}
