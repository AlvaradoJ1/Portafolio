using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoblesGym
{
    internal class Gimnasio
    {
        private long rut = 8565236562;
        private string name = "GYM ROBLES";
        private uint telefono = 3125861667;
        private string direccion = "carrera 1 # 8-13";
        double valorpagar { get; set; }
        public double mensualidad { get; set; }
        public double descuento { get; set; }
        public int salario { get; internal set; }
        public int estrato { get; set; }
        public string genero { get; set; }



        
        public double calcularvalorpagar(double mensualidad, double descuento)
        {
            valorpagar = mensualidad - descuento;
            return valorpagar;
        }
    }
}
