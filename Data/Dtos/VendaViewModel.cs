using API_DEVinCar_Graphql.Data.Models;

namespace API_DEVinCar_Graphql.Data.Dtos
{
    public class VendaViewModel
    {
        public Venda Venda { get; set; }
        public VeiculoSubscriptionViewModel Veiculo { get; set; }
    }
}
