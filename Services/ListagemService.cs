using API_DEVinCar_Graphql.Data.Enums;
using API_DEVinCar_Graphql.Data.Models;
using API_DEVinCar_Graphql.Models;
using API_DEVinCar_Graphql.Repositories.Interfaces;

namespace API_DEVinCar_Graphql.Services
{
    public class ListagemService : IListagemService
    {
        private readonly ICamioneteRepository _camioneteRepository;
        private readonly ICarroRepository _carroRepository;
        private readonly IMotoTricicloRepository _motoRepository;

        public ListagemService(ICamioneteRepository camioneteRepository, ICarroRepository carroRepository, IMotoTricicloRepository motoRepository)
        {
            _camioneteRepository = camioneteRepository;
            _carroRepository = carroRepository;
            _motoRepository = motoRepository;
        }

        public async Task<IEnumerable<Veiculo>> GetAll(EVeiculo? tipoVeiculo)
        {
            List<Veiculo> veiculos = new();
            List<Carro> carros = new();
            List<Camionete> camionetes = new();
            List<MotoTriciclo> motos = new();

            switch (tipoVeiculo)
            {
                case EVeiculo.Carro:
                    carros = await _carroRepository.GetAll();
                    carros.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.Camionete:
                    camionetes = await _camioneteRepository.GetAll();
                    camionetes.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.MotoTriciclo:
                    motos = await _motoRepository.GetAll();
                    motos.ForEach(m => veiculos.Add(m));
                    break;

                default:
                    carros = await _carroRepository.GetAll();
                    carros.ForEach(c => veiculos.Add(c));

                    camionetes = await _camioneteRepository.GetAll();
                    camionetes.ForEach(c => veiculos.Add(c));

                    motos = await _motoRepository.GetAll();
                    motos.ForEach(m => veiculos.Add(m));
                    break;
            }

            return veiculos;
        }

        public async Task<IEnumerable<Veiculo>> GetAvailable(EVeiculo? tipoVeiculo)
        {
            List<Veiculo> veiculos = new();
            List<Carro> carros = new();
            List<Camionete> camionetes = new();
            List<MotoTriciclo> motos = new();

            switch (tipoVeiculo)
            {
                case EVeiculo.Carro:
                    carros = await _carroRepository.GetAvailable();
                    carros.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.Camionete:
                    camionetes = await _camioneteRepository.GetAvailable();
                    camionetes.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.MotoTriciclo:
                    motos = await _motoRepository.GetAvailable();
                    motos.ForEach(m => veiculos.Add(m));
                    break;

                default:
                    carros = await _carroRepository.GetAvailable();
                    carros.ForEach(c => veiculos.Add(c));

                    camionetes = await _camioneteRepository.GetAvailable();
                    camionetes.ForEach(c => veiculos.Add(c));

                    motos = await _motoRepository.GetAvailable();
                    motos.ForEach(m => veiculos.Add(m));
                    break;
            }

            return veiculos;
        }

        public async Task<IEnumerable<Veiculo>> GetSold(EVeiculo? tipoVeiculo)
        {
            List<Veiculo> veiculos = new();
            List<Carro> carros = new();
            List<Camionete> camionetes = new();
            List<MotoTriciclo> motos = new();

            switch (tipoVeiculo)
            {
                case EVeiculo.Carro:
                    carros = await _carroRepository.GetSold();
                    carros.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.Camionete:
                    camionetes = await _camioneteRepository.GetSold();
                    camionetes.ForEach(c => veiculos.Add(c));
                    break;

                case EVeiculo.MotoTriciclo:
                    motos = await _motoRepository.GetSold();
                    motos.ForEach(m => veiculos.Add(m));
                    break;

                default:
                    carros = await _carroRepository.GetSold();
                    carros.ForEach(c => veiculos.Add(c));

                    camionetes = await _camioneteRepository.GetSold();
                    camionetes.ForEach(c => veiculos.Add(c));

                    motos = await _motoRepository.GetSold();
                    motos.ForEach(m => veiculos.Add(m));
                    break;
            }

            return veiculos;
        }
    }
}
