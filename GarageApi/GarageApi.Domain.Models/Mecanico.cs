using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Domain.Models
{
    public class Mecanico
    {
        public Guid Id { get; set; }
        public string NomeOficina { get; set; }
        public string Endereco { get; set; }
        public string Cnpj { get; set; }
        public string Especialidades { get; set; } // Ex: Suspensão, Freios, etc.

        // Relacionamento com os veículos que realiza manutenção
        public List<Veiculo> VeiculosEmManutencao { get; set; } = new List<Veiculo>();
    }
}
