using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApi.Domain.Models
{
    public class EmpresaParceira
    {
        public string NomeSistema { get; set; }
        public string TokenAutenticacao { get; set; } // Token usado para autenticação via API
    }
}
