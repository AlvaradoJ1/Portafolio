using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ciclos4
{
    class Program
    {
        /*
         * Leer un número entero y diga si es 
         * número primo
         *   tengo n
         *  Si div 2,3,4,5,6,7.... (n-1)
         *   
         * ejemplo
         *  n=7
         *  7%2=1
         *  7%3=1
         *  7%4=3
         *  7%5=2
         *  7%6=1  Es Primo
         *  
         * Ejemplo
         *   n=21
         *  21%2=1
         *  21%3=0  No es primo
         *  */
        static void Main(string[] args)
        {
            int k;
            bool primo = true;

            Console.WriteLine("Digite el  número");
            int n = int.Parse(Console.ReadLine());

            k=2;
            while(k<n&&primo==true){
            //while(k<n&&primo){

                if (n % k == 0) { 
                  // ya no es primo
                    primo = false;
                }// fin si
                k++;
            }// fin while

            if (primo == true) {
                //if (primo) { 
                 Console.WriteLine("El número "+ n+ " es primo");
            } else {
                Console.WriteLine("El número " + n + " NO es primo");
            }
            Console.ReadKey();
        }// fin main
    }
}
