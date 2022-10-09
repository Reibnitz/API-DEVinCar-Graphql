using System.ComponentModel.DataAnnotations;

namespace API_DEVinCar_Graphql.Models
{
    public class Camionete
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Potencia { get; set; }

        [Required]
        public int Portas { get; set; }

        [Required]
        public ETipoCombustivel TipoCombustivel { get; set; }

        [Required]
        public int CapacidadeCacamba { get; set; }

        [Required]
        public Guid Chassi { get; set; }

        [Required]
        public DateOnly DataFabricacao { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Placa { get; set; }

        [Required]
        public double Valor { get; set; }

        [Required]
        public string Cor { get; set; }
    }
}
