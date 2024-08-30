using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoblesGym
{
    internal class Cliente
    {
        public int Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public int Sueldo { get; set; }
        public int Estrato { get; set; }
        public string Genero { get; set; }
        public int salario { get; internal set; }


        //METODO TOSTRING
        public override string ToString()
        {
            return "[id: " + Identificacion + " -Nombre: " + NombreCompleto +
                " -Sueldo: " + Sueldo + " -Estrato: " + Estrato + " - Genero: " + Genero + "]";
        }

    }
}
