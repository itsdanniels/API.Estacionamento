using Api.Estacionamento.Models;
using Api.Estacionamento.Models.DTOs;
using System.Threading.Tasks;

namespace Api.Estacionamento.Repositories.Interfaces
{
    public interface IEstacionamentoRepository
    {
        Task<Veiculo> GetVeiculoNoPatio(string placa);
        Task<bool> CadastroVeiculo(VeiculoDTO veiculo);
        Task<bool> SaidaVeiculo(string placa);
    }
}
