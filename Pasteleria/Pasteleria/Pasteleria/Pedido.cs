using System;
using System.Collections.Generic;
using System.Text;
//Juan Cristobal Alvarado Orduz
namespace Pasteleria
{
    public class Pedido
    {
        //ATRIBUTOS
        private string referencia; 
        private string cedula;
        private Cliente cliente;
        private double precio;

        //METODO CONSTRUCTOR
        public Pedido(string referencia, string cedula, Cliente cliente, /*string direccion, string telefono,*/ double precio)
        {
            this.referencia = referencia;
            this.cedula = cedula;
            this.cliente = cliente;
           /*this.direccion = direccion;
            this.telefono = telefono;*/
            this.precio = precio;
        }

        public string getReferencia()
        {
            return referencia;
        }
        public void setReferencia(string nuevaReferencia)
        {
            referencia = nuevaReferencia;
        }

        public string getCedula()
        {
            return cedula;
        }
        public void setCedula(string nuevaCedula)
        {
            cedula = nuevaCedula;
        }

        /*public string getDireccion()
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
        public void setTelefono(string nuevoTelefono)
        {
            telefono = nuevoTelefono;
        }*/

        public double getPrecio()
        {
            return precio;
        }
        public void setPrecio(double nuevoPrecio)
        {
            precio = nuevoPrecio;
        }
        public Cliente getCliente()
        {
            return cliente;
        }
        public void setCliente(Cliente nuevoCliente)
        {
            cliente = nuevoCliente;
        }

        
        //METODO TOSTRING
        public override string ToString()
        {
            return "[Referencia: " + referencia + " -Cedula: "+ cliente.getCedula() +" -Nombre del cliente: " + cliente.getNombre() +" -Direccion: " + cliente.getDireccion() + " -Telefono: " + cliente.getTelefono() + " -Precio: " + precio + "]";
        }
    }
}
