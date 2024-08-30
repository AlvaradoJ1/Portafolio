using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ciclos3
{
    class Program
    {
        /* Leer 5 números y sumar los que son impares
         
           5 | 2
              ----------
           1    2
         */
        static void Main(string[] args)
        {
            int suma = 0, valor;
            int i;


            i=1; // ** inicializar la variable de la condición **
            while(i<=5)
            {
                Console.WriteLine("Digite el número " + i);
                valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 1)
                { // es impar porque el residuo es 1
                    suma = suma + valor;
                }// fin si

               i++;// ** actualizar la variable de la cuenta **
            }// fin while

            Console.WriteLine("La suma de Impares es " + suma);
            Console.ReadKey();
        }// fiman
    }
}
