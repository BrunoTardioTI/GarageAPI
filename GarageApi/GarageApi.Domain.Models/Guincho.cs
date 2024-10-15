using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Domain.Models
{
    public class Guincho
    {
        public Guid Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string Cnpj { get; set; }
        public string TelefoneContato { get; set; }
        public string EnderecoBase { get; set; } // Local onde o Guincho está baseado
        public string AreaAtuacao { get; set; } // Área geográfica onde o guincho oferece serviço (ex: cidade, estado)

        // Informações sobre disponibilidade do guincho
        public bool Disponivel { get; set; } = true;

        // Relacionamento com os veículos atendidos pelo guincho
        public List<VeiculoSocorrido> VeiculosSocorridos { get; set; } = new List<VeiculoSocorrido>();
    }

    public class VeiculoSocorrido
    {
        public Guid Id { get; set; }
        public Guid VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        public DateTime DataSocorro { get; set; }
        public string LocalSocorro { get; set; }
        public string Observacoes { get; set; }
    }
}
