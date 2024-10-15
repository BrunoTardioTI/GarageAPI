using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Domain.Models
{
    public class Lojista
    {
        public Guid Id { get; set; }
        public string NomeLoja { get; set; }
        public string Cnpj { get; set; }
        public string TelefoneContato { get; set; }
        public string Endereco { get; set; }

        // Produtos ou serviços oferecidos
        public List<Produto> ProdutosDisponiveis { get; set; } = new List<Produto>();
        public List<Servico> ServicosDisponiveis { get; set; } = new List<Servico>();
    }

    public class Produto
    {
        public Guid Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public int EstoqueDisponivel { get; set; }
    }

    public class Servico
    {
        public Guid Id { get; set; }
        public string NomeServico { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
    }
}
