using System;

namespace Api.Estacionamento.Models.DTOs
{
    public class VeiculoDTO
    {
        public string Placa { get; set; }
        public TipoVeiculo Tipo { get; set; }
        public string Proprietario { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
    }
}
