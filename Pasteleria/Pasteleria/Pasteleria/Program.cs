using System;
//Juan Cristobal Alvarado Orduz
namespace Pasteleria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pasteleria pasteleria1 = new Pasteleria("1007801","DON CARLOS", "CARREA14 #14-23", "3125861667"); 
            string continuar = "s";
            while (continuar.Equals("s"))
            {
                Console.Write("Menú: " +
                    "\n1. Listar tortas." +
                    "\n2. Buscar torta." +
                    "\n3. Agregar torta." +
                    "\n4. Eliminar Torta" +
                    "\n5. Lista cliente." +
                    "\n6. Buscar Cliente." +
                    "\n7. Agregar cliente. " + 
                    "\n8. Eliminar cliente." +
                    "\n9. Listar pedido. " +
                    "\n10. Buscar pedido. " +
                    "\n11. agregar Pedido" + // se agrega el pedido mas no se havendido aun ya que se esta en proceso, por si lo cancelan o sucede algo con el cliente
                    "\n12. Eliminar pedido" +
                    "\n13. Realizar pedido" + // aqui ya si se vende el pedido, ya se realiza como tal la venta
                    "\n14. buscar ventas. " +
                    "\n" +
                    "\nDIGITE EL NUMERO DE LA ACCION A REALIZAR. \n");
                int opcion = System.Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            pasteleria1.listarTortas();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("escriba el id de la torta que deseas buscar\n");
                            string idt = Console.ReadLine();
                            Torta torta = pasteleria1.buscarTorta(idt);
                            if (torta != null)
                            {
                                Console.Write(torta);
                            }
                            else
                            {
                                Console.Write("la torta no se encuentra en la base de datos\n");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Escriba el id de la torta...\n");
                            string idt = Console.ReadLine();
                            Console.Write("Escriba el tipo de decoracion de la torta...\n");
                            string tipo_decoracion = Console.ReadLine();
                            Console.Write("Escriba el sabor de la torta...\n");
                            string sabor = Console.ReadLine();
                            Console.Write("Escriba la catidad de porciones de la torta...\n");
                            int cantidad_porciones = System.Convert.ToInt32(Console.ReadLine());
                            Console.Write("Escriba la catidad de la misma torta...\n");//la cantidad de tortas que se hicieron con las mismas referencias
                            int cantidad_disponible = System.Convert.ToInt32(Console.ReadLine());
                            pasteleria1.registrarTorta(idt, tipo_decoracion, sabor, cantidad_porciones, cantidad_disponible);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Escriba el id de la torta que desea eliminar\n");
                            string idt = Console.ReadLine();
                            pasteleria1.eliminarTorta(idt);
                            break;
                        }
                    case 5:
                        {
                            pasteleria1.listarClientes();
                            break;
                        }
                    case 6:
                        {
                            Console.Write("escriba la cedula del cliente que deseas buscar\n");
                            string cedula = Console.ReadLine();
                            Cliente cliente = pasteleria1.buscarCliente(cedula);
                            if (cliente != null)
                            {
                                Console.Write(cliente);
                            }
                            else
                            {
                                Console.Write("El cliente no se encuentra en la base de datos\n");
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Escriba la cedula del cliente...\n");
                            string cedula = Console.ReadLine();
                            Console.Write("Escriba el nombre del clinte...\n");
                            string nombre = Console.ReadLine();
                            Console.Write("Escriba la direccion del cliente...\n");
                            string direccion = Console.ReadLine();
                            Console.Write("Escriba el telefono del cliente...\n");
                            string telefono = Console.ReadLine();
                            pasteleria1.registrarCliente(cedula, nombre, direccion, telefono);
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Escriba la cedula del cliente que desea eliminar\n");
                            string cedula = Console.ReadLine();
                            pasteleria1.eliminarCliente(cedula);
                            break;
                        }
                    case 9:
                        {
                            pasteleria1.listarPedidos();
                            break;
                        }
                    case 10:
                        {
                            Console.Write("Escriba la referencia del pedido que deseas buscar\n");
                            string referencia = Console.ReadLine();
                            Pedido pedido = pasteleria1.buscarPedido(referencia);
                            if (pedido != null)
                            {
                                Console.Write(pedido);
                            }
                            else
                            {
                                Console.Write("El pedido no se encuentra en la base de datos\n");
                            }
                            break;
                        }
                    case 11:
                        {
                            Console.Write("Escriba la referencia del pedido...\n");
                            string referencia = Console.ReadLine();
                            Console.Write("Escriba la cedula del cliente...\n");
                            string cedula = Console.ReadLine(); 
                            /*Console.Write("Escriba la direccion del cliente...\n");
                            string direccion = Console.ReadLine(); 
                            Console.Write("Escriba el telefono del cliente...\n");
                            string telefono = Console.ReadLine();*/
                            Console.Write("Escriba el precio del pedido...\n");
                            double precio = System.Convert.ToInt32(Console.ReadLine());
                            pasteleria1.agregarPedido(referencia,  cedula, /*direccion, telefono,*/ precio) ;
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Escriba la referencia del pedido que desea eliminar\n");
                            string referencia = Console.ReadLine();
                            pasteleria1.eliminarPedido(referencia);
                            break;
                        }
                    case 13:
                        {
                            Console.Write("Escriba la cedula del cliente...\n");
                            string cedula = Console.ReadLine();
                            /*Console.Write("Escriba el id del pedido...\n");
                            string referencia = Console.ReadLine();*/
                            Console.Write("Escriba el id de la torta...\n");
                            string idt = Console.ReadLine();
                            pasteleria1.realizarPedido(cedula, idt);
                            break;
                        }
                    case 14:
                        {

                            pasteleria1.ventasDiarias();
                            break;
                        }
                }
                Console.Write("\n Si desea continuar oprima (s) de lo contrario oprima otra tecla.\n");
                continuar = (string)Console.ReadLine();
            }
        }
    }
}
