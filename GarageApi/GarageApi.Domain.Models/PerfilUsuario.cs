using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Domain.Models
{
    public class PerfilUsuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();  // ID para cada perfil específico

        public Tipo TipoPerfil { get; set; }  // Enum para definir o tipo de perfil

        // Relacionamento opcional com informações adicionais dependendo do tipo
        public Mecanico? MecanicoInfo { get; set; }
        public Lojista? LojistaInfo { get; set; }
        public Guincho? GuinchoInfo { get; set; }
    }

    public enum Tipo
    {
        Cliente ,
        Mecanico,
        Guincho,
        Lojista,
        Administrador,
        EmpresaParceira
    }
}
