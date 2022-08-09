using Api.Estacionamento.Models;
using Api.Estacionamento.Models.DTOs;
using System.Threading.Tasks;

namespace Api.Estacionamento.Services.Interfaces
{
    public interface IEstacionamentoService
    {
        Task<Veiculo> GetVeiculos(int id);
        Task<bool> CadastroVeiculo(VeiculoDTO veiculo);
    }
}
