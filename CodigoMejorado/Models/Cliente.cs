using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMejorado.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }

        // Lista de cuentas asociadas al cliente (relación 1 a muchos)

        public List<Cuenta> Cuentas { get; set; } = new List<Cuenta>();

    }
}
