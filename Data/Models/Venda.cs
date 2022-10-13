using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using API_DEVinCar_Graphql.Data.Enums;

namespace API_DEVinCar_Graphql.Data.Models
{
    public class Venda
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo VeiculoId de preenchimento obrigatório")]
        public Guid VeiculoId { get; set; }

        [Required(ErrorMessage = "Campo Cpf de preenchimento obrigatório")]
        public string Cpf { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Formato de data inválido.")]
        [Required(ErrorMessage = "Campo Data de preenchimento obrigatório")]
        public DateTime Data { get; set; }

        public EVeiculoVendido TipoVeiculo { get; set; }
    }
}
