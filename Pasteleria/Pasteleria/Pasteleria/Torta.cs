using System;
using System.Collections.Generic;
using System.Text;
//Juan Cristobal Alvarado Orduz
namespace Pasteleria
{
    public class Torta
    {
        //ATRIBUTOS
        private string idt;
        private string tipo_decoracion;
        private string sabor;
        private int cantidad_porciones; // Es la cantidad de personas en las que se puede dividir la torta, y lo dejo string por que no necesito hacer calculos con ella
        private int cantidad_disponible; // esta variable representa la cantidad de torta que se hicieron con las mismas referencias

        //METODO CONSTRUCTOR
        public Torta(string idt, string tipo_decoracion, string sabor, int cantidad_porciones, int cantidad_disponible)
        {
            this.idt = idt;
            this.tipo_decoracion = tipo_decoracion;
            this.sabor = sabor;
            this.cantidad_porciones = cantidad_porciones;
            this.cantidad_disponible = cantidad_disponible;
        }

        public string getIdt()
        {
            return idt;
        }
        public void setIdt(string nuevaIdt)
        {
            idt = nuevaIdt;
        }

        public string getTipo_decoracion()
        {
            return tipo_decoracion;
        }
        public void setTipo_decoracion(string nuevoTipo_decoracion)
        {
            tipo_decoracion = nuevoTipo_decoracion;
        }

        public string getSabor()
        {
            return sabor;
        }
        public void setSabor(string nuevoSabor)
        {
            sabor = nuevoSabor;
        }

        public int getCantidad_porciones()
        {
            return cantidad_porciones;
        }
        public void setCantidad_porciones(int nuevaCantidad_porciones)
        {
            cantidad_porciones = nuevaCantidad_porciones;
        }

        public int getCantidad_disponible()
        {
            return cantidad_disponible;
        }
        public void setCantidad_disponible(int nuevaCantidad_disponible)
        {
            cantidad_disponible = nuevaCantidad_disponible;
        }

       
        //METODO TOSTRING
        public override string ToString()
        {
            return "[Id de la torta; " + idt + " -Tipo de decoración: " + tipo_decoracion +
                " -Sabor: " + sabor + " -Cantidad de porciones: " + cantidad_porciones + " -Disponibles: " + cantidad_disponible + "]";

        }
    }
}
