using System.ComponentModel.DataAnnotations;

namespace API_DEVinCar_Graphql.Models
{
    public class Carro : ICarro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Potencia é de preenchimento obrigatório")]
        public double Potencia { get; set; }

        [Required(ErrorMessage = "Campo Portas de preenchimento obrigatório")]
        public int Portas { get; set; }

        [Required(ErrorMessage = "Campo Flex de preenchimento obrigatório")]
        public bool Flex { get; set; }

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

        public Carro(double potencia, int portas, bool flex, DateTime dataFabricacao,
            string nome, string placa, double valor, string cor, bool disponivel = true)
        {
            Potencia = potencia;
            Portas = portas;
            Flex = flex;
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
