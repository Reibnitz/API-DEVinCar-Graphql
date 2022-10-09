using System.ComponentModel.DataAnnotations;

namespace API_DEVinCar_Graphql.Models
{
    public class Camionete
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Potencia de preenchimento obrigatório")]
        public double Potencia { get; set; }

        [Required(ErrorMessage = "Campo Portas de preenchimento obrigatório")]
        public int Portas { get; set; }

        [Required(ErrorMessage = "Campo TipoCombustivel de preenchimento obrigatório")]
        public ETipoCombustivel TipoCombustivel { get; set; }

        [Required(ErrorMessage = "Campo CapacidadeCacamba de preenchimento obrigatório")]
        public int CapacidadeCacamba { get; set; }

        public Guid Chassi { get; private set; }

        [DataType(DataType.DateTime, ErrorMessage = "Formato de data inválido.")]
        [Required(ErrorMessage = "Campo DataFabricacao de preenchimento obrigatório")]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "Campo Name de preenchimento obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Placa de preenchimento obrigatório")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Campo Valor de preenchimento obrigatório")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Campo Cor de preenchimento obrigatório")]
        public string Cor { get; set; }

        public Camionete(double potencia, int portas, ETipoCombustivel tipoCombustivel,
            int capacidadeCacamba, DateTime dataFabricacao, string name,
            string placa, double valor, string cor)
        {
            Potencia = potencia;
            Portas = portas;
            TipoCombustivel = tipoCombustivel;
            CapacidadeCacamba = capacidadeCacamba;
            DataFabricacao = dataFabricacao;
            Name = name;
            Placa = placa;
            Valor = valor;
            Cor = cor;
            Chassi = Guid.NewGuid();
        }
    }
}
