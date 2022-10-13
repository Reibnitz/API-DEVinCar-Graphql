using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_DEVinCar_Graphql.Data.Models
{
    public class Usuario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Campo Username de preenchimento obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Campo Password de preenchimento obrigatório")]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
