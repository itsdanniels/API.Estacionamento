using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Estacionamento.Models.DTOs
{
    public struct VeiculoDTO
    {
        [Required]
        [MaxLength(8)]
        [MinLength(7)]
        public string Placa { get; set; }

        [Required]
        public TipoVeiculo Tipo { get; set; }
        public string Proprietario { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
    }
}
