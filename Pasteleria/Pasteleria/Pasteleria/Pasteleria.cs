using System;
using System.Collections.Generic;
using System.Text;

//Juan Cristobal Alvarado Orduz
namespace Pasteleria
{
    public class Pasteleria
    {
        //ATRIBUTOS
        private string nit;
        private string nombre;
        private string direccion;
        private string telefono;
        private int venta; //es un contador que cuenta las ventas que se hacen por eso es int
        //lo dejo aqui por que en pedidos solo son los pedidos mas no se venden, ya que lo pense en forma de que puedan cancelar el pedido y asi no se tome como que se vendio
        private List<Cliente> clientes;
        private List<Torta> tortas;
        private List<Pedido> pedidos;

        //CONSTRUCTOR
        public Pasteleria (string nit, string nombre, string direccion, string telefono)
        {
            this.nit = nit;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.venta = 0; //No esta en el constructor de arriba, por que es un digito que se inicializa en 0, si bien le entendi en el video que nos dio de apoyo
            this.clientes = new List<Cliente>(); //No esta en el constructor de arriba, por que es un digito que se agrega automaticamente, si bien le entendi en el video que nos dio de apoyo
            this.tortas = new List<Torta>(); //No esta en el constructor de arriba, por que es un digito que se agrega automaticamente, si bien le entendi en el video que nos dio de apoyo
            this.pedidos = new List<Pedido>(); //No esta en el constructor de arriba, por que es un digito que se agrega automaticamente, si bien le entendi en el video que nos dio de apoyo
        }
        public string getNit()
        {
            return nit;
        }
        public void setNit(string nuevoNit)
        {
            nit = nuevoNit;
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
        public void setTelefono(string nuevoTelefono)
        {
            telefono = nuevoTelefono;
        }

        public int getVenta()
        {
            return venta;
        }
        public void setVenta(int nuevaVenta)
        {
            venta = nuevaVenta;
        }

        public List<Cliente> getClientes()
        {
            return clientes;
        }
        public void setClientes(List<Cliente> nuevosClientes)
        {
            clientes = nuevosClientes;
        }

        public List<Torta> getTortas()
        {
            return tortas;
        }
        public void setTortas(List<Torta> nuevasTortas)
        {
            tortas = nuevasTortas;
        }

        public List<Pedido> getPedidos()
        {
            return pedidos;
        }
        public void set(List<Pedido> nuevosPedidos)
        {
            pedidos = nuevosPedidos;
        }


        //METODOS DE LOS CLIENTE
        public void listarClientes()
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(clientes[i]);
            }
        }

        public Cliente buscarCliente(string cedula)
        {
            Cliente respuesta = null;
            bool centinela = false;
            for (int i = 0; i < clientes.Count && centinela == false; i++)
            {
                if (clientes[i].getCedula().Equals(cedula))
                {
                    respuesta = clientes[i];
                    centinela = true;
                }
            }
            return respuesta;
        }
        public void registrarCliente(string cedula, string nombre, string direccion, string telefono)
        {
            Cliente buscado = buscarCliente(cedula);
            if (buscado == null)
            {
                Cliente nuevo = new Cliente(cedula, nombre, direccion, telefono);
                clientes.Add(nuevo);
                Console.Write("El cliente se registro correctamente.\n ");
            }
            else
            {
                Console.Write("El cliente ya se encuentra registrado.\n");
            }
        }

        public void eliminarCliente(string id)
        {
            Cliente buscado = buscarCliente(id);
            if (buscado == null)
            {
                Console.Write("El cliente no se encuentra en la base de datos.\n");
            }
            else
            {
                clientes.Remove(buscado);
                Console.Write("El cliente se elimino correctamente.\n");
            }
        }


        //METODOS DE LAS TORTAS
        public void listarTortas()
        {
            for (int i = 0; i < tortas.Count; i++)
            {
                Console.WriteLine(tortas[i]);
            }
        }

        public Torta buscarTorta(string idt)
        {
            Torta respuesta = null;
            bool centinela = false;
            for (int i = 0; i < tortas.Count && centinela == false; i++)
            {
                if (tortas[i].getIdt().Equals(idt))
                {
                    respuesta = tortas[i];
                    centinela = true;
                }
            }
            return respuesta;
        }
        public void registrarTorta(string idt, string tipo_decoracion, string sabor, int cantidad_porciones, int cantidad_disponible)
        {
            Torta buscada = buscarTorta(idt);
            if (buscada == null)
            {
                Torta nuevo = new Torta(idt, tipo_decoracion, sabor, cantidad_porciones, cantidad_disponible);
                tortas.Add(nuevo);
                Console.Write("La torta se registro correctamente.\n ");
            }
            else
            {
                Console.Write("La torta ya se encuentra registrada.\n");
            }
        }

        public void eliminarTorta(string idt)
        {
            Torta buscada = buscarTorta(idt);
            if (buscada == null)
            {
                Console.Write("La torta no se encuentra en la base de datos.\n");
            }
            else
            {
                tortas.Remove(buscada);
                Console.Write("La torta se elimino correctamente.\n");
            }
        }
        //METODOS DE LOS PEDIDOS
        public void listarPedidos()
        {
            for (int i = 0; i < pedidos.Count; i++)
            {
                Console.WriteLine(pedidos[i]);
            }
        }

        public Pedido buscarPedido(string referencia)
        {
            Pedido respuesta = null;
            bool centinela = false;
            for (int i = 0; i < pedidos.Count && centinela == false; i++)
            {
                if (pedidos[i].getReferencia().Equals(referencia))
                {
                    respuesta = pedidos[i];
                    centinela = true;
                }
            }
            return respuesta;
        }
        public void agregarPedido(string referencia, string cedula, /*string direccion, string telefono,*/ double precio)
        {
           

            Pedido buscado = buscarPedido(referencia);
            Cliente cliente = buscarCliente(cedula);
            if (buscado == null)
            {
                if(cliente != null)
                {
                    Pedido nuevo = new Pedido(referencia, cedula, cliente,/* direccion, telefono,*/ precio);
                    pedidos.Add(nuevo);
                    Console.Write("El pedido se registro correctamente.\n ");
                }
                else
                {
                    Console.Write("El cliente no se encuentra registrado.\n");

                }
            }
            else
            {
                Console.Write("El pedido ya se encuentra registrada.\n");
            }
        }

        public void eliminarPedido(string referencia)
        {
            Pedido buscado = buscarPedido(referencia);
            if (buscado == null)
            {
                Console.Write("El pedido no se encuentra en la base de datos.\n");
            }
            else
            {
                pedidos.Remove(buscado);
                Console.Write("El pedido se elimino correctamente.\n");
            }
        }

        //METODOS DE LAS SOLUCIONES DEL FUNCIONAMIENTO
        public void realizarPedido(string cedula, string idt)
        {
            Cliente buscadoC = buscarCliente(cedula);
            Torta buscada = buscarTorta(idt);

            if(buscadoC != null && buscada != null && buscada.getCantidad_disponible() > 0)
            {
                buscada.setCantidad_disponible(buscada.getCantidad_disponible() - 1);
                buscadoC.setCedula(buscadoC.getCedula());

                Console.Write("Se realizo el pedido con exito");

                DateTime fecha = DateTime.Today;

                venta = venta + 1;
            }
            else
            {
                Console.Write("No se pudo realizar el pedido");
            }
        }
        public void ventasDiarias ()
        {
            Console.Write("las ventas del dia son: " + venta);
        }
    }
}
