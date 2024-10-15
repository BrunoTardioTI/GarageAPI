using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Domain.Models
{
    public class PerfilUsuario
    {
        public Guid Id { get; set; }
        public PerfilUsuario Tipo { get; set; } // Enum para definir os tipos de perfil (Mecânico, Lojista, etc.)

        // Relacionamento com Mecânico, Lojista, etc.
        public Mecanico? MecanicoInfo { get; set; }
        public Lojista? LojistaInfo { get; set; }
        public Guincho? GuinchoInfo { get; set; }
    }

    public enum PerfilUsuario
    {
        Cliente,
        Mecanico,
        Guincho,
        Lojista,
        Administrador,
        EmpresaParceira
    }
}
