using API_DEVinCar_Graphql.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_DEVinCar_Graphql.Models
{
    public class MotoTriciclo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo Potencia de preenchimento obrigatório")]
        public double Potencia { get; set; }

        [Required(ErrorMessage = "Campo Rodas de preenchimento obrigatório")]
        public int Rodas { get; set; }

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

        public static implicit operator Veiculo(MotoTriciclo mt)
        {
            return new Veiculo
            {
                Id = mt.Id,
                Chassi = mt.Chassi,
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