using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ciclos2
{
    class Program
    {
        /* Leer 5 número y sumar los que son impares
         
           5 | 2
              ----------
           1    2
         */
        static void Main(string[] args)
        {
            int suma = 0, valor;

           
            for (int i = 1; i <= 5; i = i + 1)
            {
                Console.WriteLine("Digite el número "+i);
                valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 1) { // es impar porque el residuo es 1
                    suma = suma + valor;
                }// fin si
            }// fin for

            Console.WriteLine("La suma de Impares es " + suma);
            Console.ReadKey();

        }// Fin main
    }
}
