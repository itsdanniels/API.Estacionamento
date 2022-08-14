using Api.Estacionamento.Models;
using Api.Estacionamento.Models.DTOs;
using Api.Estacionamento.Repositories.Interfaces;
using Api.Estacionamento.Repositories.Scripts;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Api.Estacionamento.Repositories
{
    public class EstacionamentoRepository : IEstacionamentoRepository
    {
        private readonly IConfiguration _connection;

        public EstacionamentoRepository(IConfiguration connection)
        {
            _connection = connection;
        }

        public async Task<Veiculo> GetVeiculoNoPatio(string placa)
        {

            var param = new DynamicParameters();

            param.Add("@Placa", placa, DbType.String, ParameterDirection.Input, size: 7);

            using var conn = new SqlConnection(_connection.GetConnectionString("LocalDb"));

            return await conn.QueryFirstOrDefaultAsync<Veiculo>(EstacionamentoScripts.GetVeiculoPorPlaca, param);
        }

        public async Task<bool> CadastroVeiculo(VeiculoDTO veiculo)
        {
            using var conn = new SqlConnection(_connection.GetConnectionString("LocalDb"));

            return await conn.ExecuteAsync(EstacionamentoScripts.CadastrarVeiculoNoPatio,
                new { Placa = veiculo.Placa, Tipo = veiculo.Tipo, Proprietario = veiculo.Proprietario, Modelo = veiculo.Modelo, Cor = veiculo.Cor}) > 0;
        }

        public async Task<bool> SaidaVeiculo(string placa)
        {
            using var conn = new SqlConnection(_connection.GetConnectionString("LocalDb"));

            return await conn.ExecuteAsync(EstacionamentoScripts.CadastrarSaidaVeiculo, new { Placa = placa }) > 0;
        }
    }
}
