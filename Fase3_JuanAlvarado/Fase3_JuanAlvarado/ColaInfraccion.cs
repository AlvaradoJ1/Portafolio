using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_JuanAlvarado
{
    internal class ColaInfraccion
    {
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }
        public DateTime añoVehiculo { get; set; }
        public DateTime fechaComparendi { get; set; }
        public double valor { get; set; }

    }
}
