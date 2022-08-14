using Api.Estacionamento.Models;
using Api.Estacionamento.Models.DTOs;
using System.Threading.Tasks;

namespace Api.Estacionamento.Services.Interfaces
{
    public interface IEstacionamentoService
    {
        Task<Veiculo> GetVeiculoNoPatio(string placa);
        Task<bool> CadastroVeiculo(VeiculoDTO veiculo);
        Task<bool> SaidaVeiculo(string placa);
    }
}
