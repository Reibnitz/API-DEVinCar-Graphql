using API_DEVinCar_Graphql.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_DEVinCar_Graphql.Models
{
    public class Carro
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo Potencia é de preenchimento obrigatório")]
        public double Potencia { get; set; }

        [Required(ErrorMessage = "Campo Portas de preenchimento obrigatório")]
        public int Portas { get; set; }

        [Required(ErrorMessage = "Campo Flex de preenchimento obrigatório")]
        public bool Flex { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Formato de data inválido.")]
        [Required(ErrorMessage = "Campo DataFabricacao de preenchimento obrigatório")]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "Campo Name de preenchimento obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Placa de preenchimento obrigatório")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Campo Valor de preenchimento obrigatório")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Campo Cor de preenchimento obrigatório")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Campo Disponivel de preenchimento obrigatório")]
        public bool Disponivel { get; set; }

        public Guid Chassi { get; private set; } = Guid.NewGuid();

        public static implicit operator Veiculo(Carro c)
        {
            return new Veiculo
            {
                Id = c.Id,
                Chassi = c.Chassi,
                DataFabricacao = c.DataFabricacao,
                Nome = c.Nome,
                Placa = c.Placa,
                Valor = c.Valor,
                Cor = c.Cor,
                Disponivel = c.Disponivel,
                Potencia = c.Potencia,
                Portas = c.Portas,
                Flex = c.Flex,
            };
        }
    }
}
