using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_DEVinCar_Graphql.Models
{
    public class MotoTriciclo : IMotoTriciclo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Potencia de preenchimento obrigatório")]
        public double Potencia { get; set; }

        [Required(ErrorMessage = "Campo Rodas de preenchimento obrigatório")]
        public int Rodas { get; set; }

        public Guid Chassi { get; private set; }

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

        public bool Disponivel { get; set; }

        public MotoTriciclo(double potencia, int rodas, DateTime dataFabricacao,
            string nome, string placa, double valor, string cor, bool disponivel = true)
        {
            Potencia = potencia;
            Rodas = rodas;
            DataFabricacao = dataFabricacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cor = cor;
            Chassi = Guid.NewGuid();
            Disponivel = disponivel;
        }
    }
}