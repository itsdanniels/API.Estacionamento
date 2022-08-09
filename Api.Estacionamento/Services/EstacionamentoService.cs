using Api.Estacionamento.Models;
using Api.Estacionamento.Models.DTOs;
using Api.Estacionamento.Repositories;
using Api.Estacionamento.Repositories.Interfaces;
using Api.Estacionamento.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Api.Estacionamento.Services
{
    public class EstacionamentoService : IEstacionamentoService
    {
        private IEstacionamentoRepository _estacionamentoRepository { get; set; }

        public EstacionamentoService(IConfiguration connectionFactory)
        {
            _estacionamentoRepository = new EstacionamentoRepository(connectionFactory);
        }

        public Task<Veiculo> GetVeiculos(int id)
        {
            var dados = _estacionamentoRepository.GetVeiculos(id);

            return dados;
        }

        public Task<bool> CadastroVeiculo(VeiculoDTO veiculo)
        {
            var dados = _estacionamentoRepository.CadastroVeiculo(veiculo);

            return dados;
        }
    }
}
