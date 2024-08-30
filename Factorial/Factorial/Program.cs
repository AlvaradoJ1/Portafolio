using System;

namespace Factorial
{
    class Program
    {/*Calcular la factorial un número ingresado por teclado y del valor 
        obtenido se deberá obtener la raíz cuadrada y raíz cúbica. Por ejemplo, 
        la factorial de 5 es 5*4*3*2*1= 120. Recibe el número 5 y retorna 
        120.

      */
        static void Main(string[] args)
        {
            int numero;
            double factorial = 1;
            double raizcuadrada;
            double raizcubica;

            Console.WriteLine("Digite número ");
            numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("El numero invalido por favor intente con otro");
            }
            else
            {
                for (int i = numero; i > 1; i--)
                {
                    factorial = factorial * i;
                }
            }
            raizcuadrada = Math.Pow(factorial,1 / 2d);
            raizcubica = Math.Pow(factorial,1 / 3d);

            Console.WriteLine("El factorial de: " +numero +" es:" + factorial);
            Console.WriteLine("La razi cuadrada es: " + raizcuadrada);
            Console.WriteLine("La raiz cubica es: " + raizcubica);


        }
    }
}
