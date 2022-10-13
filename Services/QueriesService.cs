using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;
using API_DEVinCar_Graphql.Services.Interfaces;

namespace API_DEVinCar_Graphql.Services
{
    public class QueriesService : IQueriesService
    {
        private readonly ICamioneteRepository _camioneteRepository;
        private readonly ICarroRepository _carroRepository;
        private readonly IMotoTricicloRepository _motoRepository;

        public QueriesService(ICamioneteRepository camioneteRepository, ICarroRepository carroRepository, IMotoTricicloRepository motoRepository)
        {
            _camioneteRepository = camioneteRepository;
            _carroRepository = carroRepository;
            _motoRepository = motoRepository;
        }

        public async Task<IEnumerable<Veiculo>> GetAllAsync(EVeiculo? tipoVeiculo)
        {
            List<Veiculo> veiculos = new();
            List<Carro> carros = new();
            List<Camionete> camionetes = new();
            List<MotoTriciclo> motos = new();

            switch (tipoVeiculo)
            {
                case EVeiculo.Carro:
                    carros = await _carroRepository.GetAllAsync();
                    carros.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.Camionete:
                    camionetes = await _camioneteRepository.GetAllAsync();
                    camionetes.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.MotoTriciclo:
                    motos = await _motoRepository.GetAllAsync();
                    motos.ForEach(m => veiculos.Add(m));
                    break;

                default:
                    carros = await _carroRepository.GetAllAsync();
                    carros.ForEach(c => veiculos.Add(c));

                    camionetes = await _camioneteRepository.GetAllAsync();
                    camionetes.ForEach(c => veiculos.Add(c));

                    motos = await _motoRepository.GetAllAsync();
                    motos.ForEach(m => veiculos.Add(m));
                    break;
            }

            return veiculos;
        }

        public async Task<IEnumerable<Veiculo>> GetAvailableAsync(EVeiculo? tipoVeiculo)
        {
            List<Veiculo> veiculos = new();
            List<Carro> carros = new();
            List<Camionete> camionetes = new();
            List<MotoTriciclo> motos = new();

            switch (tipoVeiculo)
            {
                case EVeiculo.Carro:
                    carros = await _carroRepository.GetAvailableAsync();
                    carros.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.Camionete:
                    camionetes = await _camioneteRepository.GetAvailableAsync();
                    camionetes.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.MotoTriciclo:
                    motos = await _motoRepository.GetAvailableAsync();
                    motos.ForEach(m => veiculos.Add(m));
                    break;

                default:
                    carros = await _carroRepository.GetAvailableAsync();
                    carros.ForEach(c => veiculos.Add(c));

                    camionetes = await _camioneteRepository.GetAvailableAsync();
                    camionetes.ForEach(c => veiculos.Add(c));

                    motos = await _motoRepository.GetAvailableAsync();
                    motos.ForEach(m => veiculos.Add(m));
                    break;
            }

            return veiculos;
        }

        public async Task<IEnumerable<Veiculo>> GetSoldAsync(EVeiculo? tipoVeiculo)
        {
            List<Veiculo> veiculos = new();
            List<Carro> carros = new();
            List<Camionete> camionetes = new();
            List<MotoTriciclo> motos = new();

            switch (tipoVeiculo)
            {
                case EVeiculo.Carro:
                    carros = await _carroRepository.GetSoldAsync();
                    carros.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.Camionete:
                    camionetes = await _camioneteRepository.GetSoldAsync();
                    camionetes.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.MotoTriciclo:
                    motos = await _motoRepository.GetSoldAsync();
                    motos.ForEach(m => veiculos.Add(m));
                    break;

                default:
                    carros = await _carroRepository.GetSoldAsync();
                    carros.ForEach(c => veiculos.Add(c));

                    camionetes = await _camioneteRepository.GetSoldAsync();
                    camionetes.ForEach(c => veiculos.Add(c));

                    motos = await _motoRepository.GetSoldAsync();
                    motos.ForEach(m => veiculos.Add(m));
                    break;
            }

            return veiculos;
        }
    }
}
