using System;

namespace Api.Estacionamento.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public TipoVeiculo Tipo { get; set; }
        public string Modelo { get; set; }
        public string Proprietario { get; set; }
    }
}
