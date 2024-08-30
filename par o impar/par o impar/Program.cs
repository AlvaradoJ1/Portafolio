using System;

namespace par_o_impar
{
    class Program
    {/* Diseñe una solución básica con POO que permita resolver: si un 
        número es par o impar y obtener su valor al cuadrado y al cubo.
        */
        static void Main(string[] args)
        {
            int n1;
            double cuadrado;
            double cubo;

            Console.WriteLine("Digite número ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 1)
            {
                cuadrado = Math.Pow(n1, 2);
                cubo = Math.Pow(n1, 3);
                Console.WriteLine("El número es IMPAR");
                Console.WriteLine("El cuadrado del número es: " +cuadrado);
                Console.WriteLine("El cubo del número es: " +cubo);
            }
            else
            {
                cuadrado = Math.Pow(n1, 2);
                cubo = Math.Pow(n1, 3);
                Console.WriteLine("El número es PAR");
                Console.WriteLine("El cuadrado del número es: " + cuadrado);
                Console.WriteLine("El cubo del número es: " + cubo);

            }
        }
    }
}
