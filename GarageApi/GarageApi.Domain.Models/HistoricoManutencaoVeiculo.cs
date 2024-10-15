using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Domain.Models
{
    public class HistoricoManutencaoVeiculo
    {
        public Guid Id { get; set; }
        public Guid VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        public Guid MecanicoId { get; set; }
        public Mecanico Mecanico { get; set; }

        public DateTime DataManutencao { get; set; }
        public string DescricaoServico { get; set; }
        public decimal Valor { get; set; }
    }
}
