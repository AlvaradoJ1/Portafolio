using System;

namespace Matriculas
{ 
    class Program
    {/*Se requiere desarrollar una solución básica de programación que permita 
matricular un número X de estudiantes. Al finalizar, la solución de 
programación debe mostrar los siguientes resultados:
2
• Cantidad de estudiantes inscritos por programa académico.
• Total de créditos inscritos en el tercer período académico del 2020.
• Valor total pagado por los estudiantes sin tener en cuenta el 
descuento.
• Valor total de descuentos aplicados por la universidad a los 
estudiantes.
• Valor neto de las inscripciones del primer semestre del 2020.
    */
        static void Main(string[] args)
        {
            string nombre;
            int cantidad;
            int programa;
            int pago;
            int ingenieria_de_sistemas = 0;
            int psicologia = 0;
            int economia = 0;
            int comunicacion_social = 0;
            int administracion_de_empresas = 0;
            double descuento = 0;
            double total = 0;
            int valor = 0;
            int creditos = 0;

            Console.WriteLine("Digite el número de estudiantes a matricular ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Escriba el nombre del estudiante número  " +i);
                nombre = Console.ReadLine();

                Console.WriteLine("Digite el número del programa academico que desea matricular ");
                Console.WriteLine("1. Ingeniería de sistemas ");
                Console.WriteLine("2. Psicología");
                Console.WriteLine("3. Economía ");
                Console.WriteLine("4. Comunicación Social ");
                Console.WriteLine("5. Administración de Empresas ");
                programa = int.Parse(Console.ReadLine());

                if (programa == 1)
                {
                    Console.WriteLine("Digite el número de la forma de pago ");
                    Console.WriteLine("1. Pago en efectivo ");
                    Console.WriteLine("2. Pago en linea ");
                    pago = int.Parse(Console.ReadLine());

                    if (pago == 1)
                    {
                        descuento = descuento + (20 * 200000) * 0.18;
                        valor = valor + (20 * 200000);
                        total = total + ((20 * 200000 - (20 * 200000) * 0.18));
                        creditos = creditos + 20;
                    }
                    else
                    {
                        valor = valor + (20 * 200000);
                        total = total + (20 * 200000);
                        creditos = creditos + 20;
                    }
                }
                else if (programa == 2)
                {
                    Console.WriteLine("Digite el número de la forma de pago ");
                    Console.WriteLine("1. Pago en efectivo ");
                    Console.WriteLine("2. Pago en linea ");
                    pago = int.Parse(Console.ReadLine());

                    if (pago == 1)
                    {
                        descuento = descuento + (16 * 200000) * 0.12;
                        valor = valor + (16 * 200000);
                        total = total + ((16 * 200000 - (16 * 200000) * 0.12));
                        creditos = creditos + 16;
                    }
                    else
                    {
                        valor = valor + (16 * 200000);
                        total = total + (16 * 200000);
                        creditos = creditos + 16;
                    }
                }
                else if (programa == 3)
                {
                    Console.WriteLine("Digite el número de la forma de pago ");
                    Console.WriteLine("1. Pago en efectivo ");
                    Console.WriteLine("2. Pago en linea ");
                    pago = int.Parse(Console.ReadLine());

                    if (pago == 1)
                    {
                        descuento = descuento + (18 * 200000) * 0.1;
                        valor = valor + (18 * 200000);
                        total = total + ((18 * 200000 - (18 * 200000) * 0.1));
                        creditos = creditos + 18;
                    }
                    else
                    {
                        valor = valor + (18 * 200000);
                        total = total + (18 * 200000);
                        creditos = creditos + 18;
                    }
                }
                else if (programa == 4)
                {
                    Console.WriteLine("Digite el número de la forma de pago ");
                    Console.WriteLine("1. Pago en efectivo ");
                    Console.WriteLine("2. Pago en linea ");
                    pago = int.Parse(Console.ReadLine());

                    if (pago == 1)
                    {
                        descuento = descuento + (18 * 200000) * 0.05;
                        valor = valor + (18 * 200000);
                        total = total + ((18 * 200000 - (18 * 200000) * 0.05));
                        creditos = creditos + 18;
                    }
                    else
                    {
                        valor = valor + (18 * 200000);
                        total = total + (18 * 200000);
                        creditos = creditos + 18;
                    }
                }
                else if (programa == 5)
                {
                    Console.WriteLine("Digite el número de la forma de pago ");
                    Console.WriteLine("1. Pago en efectivo ");
                    Console.WriteLine("2. Pago en linea ");
                    pago = int.Parse(Console.ReadLine());

                    if (pago == 1)
                    {
                        descuento = descuento + (20 * 200000) * 0.15;
                        valor = valor + (20 * 200000);
                        total = total + ((20 * 200000 - (20 * 200000) * 0.15));
                        creditos = creditos + 20;
                    }
                    else
                    {
                        valor = valor + (20 * 200000);
                        total = total + (20 * 200000);
                        creditos = creditos + 20;
                    }
                }
                else
                {
                    Console.WriteLine("NO HAY UN PROGRAMA REGISTRADO EN ESTE VALOR " );
                    i = i -1;
                }

            }
            Console.WriteLine("La cantidad de estudiantes matriculados es de: " + cantidad);
            Console.WriteLine("El total de creditos inscritos en el tercer semestre es de: " +creditos);
            Console.WriteLine("El valor total pagado por los estudiantes sin el descuento es de: "  + valor);
            Console.WriteLine("El valor total de descuentos aplicados por la universidad a los estudiantes es de: " + descuento);
            Console.WriteLine("El valor neto de las inscripciones del primer semestre es de: "  + total);
        }
    }
}
