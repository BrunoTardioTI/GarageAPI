using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Domain.Models
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public string NumeroChassi { get; set; }

        // Relacionamento com o proprietário do veículo
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Histórico de Manutenção
        public List<HistoricoManutencaoVeiculo> HistoricoManutencao { get; set; } = new List<HistoricoManutencaoVeiculo>();
    }
}
