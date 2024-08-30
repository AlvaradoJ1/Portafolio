using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_JuanAlvarado
{
    internal class PilaClientes_
    {
        public Stack<int> Id;
        public Stack<string> Nombre;
        public Stack<string> Direccion;
        public Stack<int> Estrato;
        public Stack<string> Categoria;
        public Stack<string> Canal;
        public Stack<DateTime> Fecha;
        public Stack<double> Valor;

        //Métodos get y set

        public Stack<int> getId()
        {
            return Id;
        }
        public void setId(Stack<int> nuevoId)
        {
            Id = nuevoId;
        }
        public Stack<string> getNombre()
        {
            return Nombre;
        }
        public void setNombre(Stack<string> nuevoNombre)
        {
            Nombre = nuevoNombre;
        }
        public Stack<string> getDireccion()
        {
            return Direccion;
        }
        public void setDireccion(Stack<string> nuevaDireccion)
        {
           Direccion = nuevaDireccion;
        }
        public Stack<int> getEstrato()
        {
            return Estrato;
        }
        public void setEstrato(Stack<int> nuevoEstrato)
        {
           Estrato = nuevoEstrato;
        }
        public Stack<string> getCategoria()
        {
            return Categoria;
        }
        public void setCategoria(Stack<string> nuevaCategoria)
        {
            Categoria = nuevaCategoria;
        }
        public Stack<string> getCanal()
        {
            return Canal;
        }
        public void setCanal(Stack<string> nuevoCanal)
        {
            Canal = nuevoCanal;
        }
        public Stack<DateTime> getFecha()
        {
            return Fecha;
        }
        public void setFecha(Stack<DateTime> nuevaFecha)
        {
           Fecha = nuevaFecha;
        }
        public Stack<Double> getValor()
        {
            return Valor;
        }
        public void setValor(Stack<Double> nuevoValor)
        {
           Valor = nuevoValor;
        }
    }
}
