using System;
using System.Collections.Generic;
using System.Text;
// Juan Cristobal Alvarado Orduz 
namespace Pasteleria
{
   public class Cliente
   {
        //ATRIBUTOS
        private string cedula;
        private string nombre;
        private string direccion;
        private string telefono;

        //METODO CONSTRUCTOR
        public  Cliente(string cedula, string nombre, string direccion, string telefono )
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }
       
        public string getCedula()
        {
            return cedula;
        }
        public void setCedula(string nuevaCedula)
        {
            cedula = nuevaCedula;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string nuevaDireccion)
        {
            direccion = nuevaDireccion;
        }

        public string getTelefono()
        {
            return telefono;
        }
        public void setTelefno(string nuevoTelefono)
        {
            telefono = nuevoTelefono;
        }

       
    //METODO TOSTRING
    public override string ToString()
        {
            return "[id: " + cedula + " -Nombre: " + nombre + 
                " -Direccion: " + direccion + " -Celular: " + telefono + "]" ;
        }
    }
}
