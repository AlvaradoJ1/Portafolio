using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ciclos
{
    class Program
        
    {
        /*
           Programa que 
          Leer tres número y dicer cual es el mayor
         */
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Digite el primer número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tercer número");
            num3 = int.Parse(Console.ReadLine());

            /* num1>=num2 y num1>=num3  --> num1
             * num2>=num1 y num2>=num3  --> num2
             * num3>=num1 y num3>=num2  --> num3
             * 
             */

            if((num1>=num2) && (num1>=num3)){
                Console.WriteLine("El número mayor es " + num1);
            }else{
                if ((num2 >= num1) && (num2 >= num3))
                {
                    Console.WriteLine("El número mayor es " + num2);
                } else {
                    Console.WriteLine("El número mayor es " + num3);
                }// fin si
            }// fin si
            Console.ReadKey();
        }//fin main
    }// fin clase
}//Fin nanes
