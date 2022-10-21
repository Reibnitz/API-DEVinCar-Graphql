using API_DEVinCar_Graphql.Data.Dtos;
using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using API_DEVinCar_Graphql.Services.Interfaces;
using GreenDonut;

namespace API_DEVinCar_Graphql.Services
{
    public class VeiculoMutationsService : IVeiculoMutationsService
    {
        private readonly ICarroRepository _carroRepository;
        private readonly ICamioneteRepository _camioneteRepository;
        private readonly IMotoTricicloRepository _motoRepository;
        private readonly IVendaRepository _vendaRepository;
        private EVeiculo tipoVeiculo;

        public VeiculoMutationsService(ICarroRepository carroRepository, ICamioneteRepository camioneteRepository,
            IMotoTricicloRepository motoRepository, IVendaRepository vendaRepository)
        {
            _carroRepository = carroRepository;
            _camioneteRepository = camioneteRepository;
            _motoRepository = motoRepository;
            _vendaRepository = vendaRepository;
        }

        public async Task<bool> ChangeColourAsync(string veiculoId, string colour)
        {
            Veiculo? veiculo = await SearchDbAsync(veiculoId);
            if (veiculo == null)
                return false;

            veiculo.Cor = colour;
            return await UpdateDbAsync(veiculo);
        }

        public async Task<bool> ChangePriceAsync(string veiculoId, double price)
        {
            Veiculo? veiculo = await SearchDbAsync(veiculoId);
            if (veiculo == null)
                return false;

            veiculo.Valor = price;
            return await UpdateDbAsync(veiculo);
        }

        public async Task<VendaViewModel?> SellVehicle(string veiculoId, string cpf, DateTime data)
        {
            Veiculo? veiculo = await SearchDbAsync(veiculoId);
            if (veiculo == null || veiculo.Disponivel == false)
                return null;

            veiculo.Disponivel = false;
            await UpdateDbAsync(veiculo);

            EVeiculoVendido tipo = (EVeiculoVendido)tipoVeiculo;

            Venda venda = new() { Cpf = cpf, Data = data, VeiculoId = veiculoId, TipoVeiculo = tipo };
            await _vendaRepository.AddAsync(venda);

            return new VendaViewModel() { Venda = venda, Veiculo = (VeiculoSubscriptionViewModel) veiculo };
        }

        public async Task<Veiculo?> CreateVehicleAsync(Carro carro)
        {
            Veiculo? result = await _carroRepository.AddAsync(carro);
            return result;
        }

        public async Task<Veiculo?> CreateVehicleAsync(Camionete camionete)
        {
            return await _camioneteRepository.AddAsync(camionete);
        }

        public async Task<Veiculo?> CreateVehicleAsync(MotoTriciclo moto)
        {
            return await _motoRepository.AddAsync(moto);
        }

        private async Task<Veiculo?> SearchDbAsync(string veiculoId)
        {
            string subid = veiculoId.Substring(4);
            int id = int.Parse(subid);

            switch (veiculoId)
            {
                case { } when veiculoId.StartsWith("CAR"):
                    tipoVeiculo = EVeiculo.Carro;
                    return await _carroRepository.GetByIdAsync(id);

                case { } when veiculoId.StartsWith("CAM"):
                    tipoVeiculo = EVeiculo.Camionete;
                    return await _camioneteRepository.GetByIdAsync(id);
                case { } when veiculoId.StartsWith("MOT"):
                    tipoVeiculo = EVeiculo.MotoTriciclo;
                    return await _motoRepository.GetByIdAsync(id);
            }

            return null;
        }

        private async Task<bool> UpdateDbAsync(Veiculo veiculo)
        {
            bool result = false;

            switch (veiculo.Id)
            {
                case { } when veiculo.Id.StartsWith("CAR"):
                    result = await _carroRepository.UpdateAsync((Carro)veiculo!);
                    break;
                case { } when veiculo.Id.StartsWith("CAM"):
                    result = await _camioneteRepository.UpdateAsync((Camionete)veiculo!);
                    break;
                case { } when veiculo.Id.StartsWith("MOT"):
                    result = await _motoRepository.UpdateAsync((MotoTriciclo)veiculo!);
                    break;
            }

            return result;
        }
    }
}
