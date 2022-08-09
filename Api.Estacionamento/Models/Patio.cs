using System.Collections.Generic;

namespace Api.Estacionamento.Models
{
    public class Patio
    {
        public double TotalFaturado { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
