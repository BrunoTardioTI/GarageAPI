using Garage.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApi.Domain.Models
{
    public class Garagem
    {
        public List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
    }

}
