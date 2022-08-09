using Api.Estacionamento.Models;
using Api.Estacionamento.Models.DTOs;
using System.Threading.Tasks;

namespace Api.Estacionamento.Repositories.Interfaces
{
    public interface IEstacionamentoRepository
    {
        Task<Veiculo> GetVeiculos(int id);
        Task<bool> CadastroVeiculo(VeiculoDTO veiculo);
    }
}
