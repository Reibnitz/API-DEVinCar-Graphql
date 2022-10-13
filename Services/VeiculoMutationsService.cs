using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using API_DEVinCar_Graphql.Services.Interfaces;

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

        public async Task<bool> ChangeColourAsync(Guid veiculoId, string colour)
        {
            Veiculo? veiculo = await SearchDbAsync(veiculoId);
            if (veiculo == null)
                return false;

            veiculo.Cor = colour;
            return await UpdateDbAsync(veiculo);
        }

        public async Task<bool> ChangePriceAsync(Guid veiculoId, double price)
        {
            Veiculo? veiculo = await SearchDbAsync(veiculoId);
            if (veiculo == null)
                return false;

            veiculo.Valor = price;
            return await UpdateDbAsync(veiculo);
        }

        public async Task<Venda?> SellVehicle(Guid veiculoId, string cpf, DateTime data)
        {
            Veiculo? veiculo = await SearchDbAsync(veiculoId);
            if (veiculo == null || veiculo.Disponivel == false)
                return null;

            veiculo.Disponivel = false;
            await UpdateDbAsync(veiculo);

            EVeiculoVendido tipo = (EVeiculoVendido)tipoVeiculo;

            Venda venda = new() { Cpf = cpf, Data = data, VeiculoId = veiculoId, TipoVeiculo = tipo };
            return await _vendaRepository.AddAsync(venda);
        }

        public async Task<Carro?> CreateVehicleAsync(Carro carro)
        {
            return await _carroRepository.AddAsync(carro);
        }

        public async Task<Camionete?> CreateVehicleAsync(Camionete camionete)
        {
            return await _camioneteRepository.AddAsync(camionete);
        }

        public async Task<MotoTriciclo?> CreateVehicleAsync(MotoTriciclo moto)
        {
            return await _motoRepository.AddAsync(moto);
        }

        private async Task<Veiculo?> SearchDbAsync(Guid veiculoId)
        {
            Carro? carro = await _carroRepository.GetByIdAsync(veiculoId);
            if (carro != null)
            {
                tipoVeiculo = EVeiculo.Carro;
                return carro;
            }

            Camionete? camionete = await _camioneteRepository.GetByIdAsync(veiculoId);
            if (camionete != null)
            {
                tipoVeiculo = EVeiculo.Camionete;
                return camionete;
            }

            MotoTriciclo? moto = await _motoRepository.GetByIdAsync(veiculoId);
            if (moto != null)
            {
                tipoVeiculo = EVeiculo.MotoTriciclo;
                return moto;
            }

            return null;
        }

        private async Task<bool> UpdateDbAsync(Veiculo veiculo)
        {
            bool result = false;

            switch (tipoVeiculo)
            {
                case EVeiculo.Carro:
                    result = await _carroRepository.UpdateAsync((Carro)veiculo!);
                    break;
                case EVeiculo.Camionete:
                    result = await _camioneteRepository.UpdateAsync((Camionete)veiculo!);
                    break;
                case EVeiculo.MotoTriciclo:
                    result = await _motoRepository.UpdateAsync((MotoTriciclo)veiculo!);
                    break;
            }

            return result;
        }
    }
}
