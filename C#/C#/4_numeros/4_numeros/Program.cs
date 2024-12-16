using System;

namespace _4_numeros
{
    class Program
    {/* Diseñe una solución básica con POO que permita resolver: que 
        indique cuál es el mayor de cuatro números enteros. Al número 
        mayor obtener su raíz cuadrada.
      */
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            int n4;
            double raizcuadrada;

            Console.WriteLine("Digite número ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite número ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite número ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite número ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4)
            {
                raizcuadrada = Math.Pow(n1, 1 / 2d);
                Console.WriteLine("El número " + n1 + " es el mayor de los cuatro números");
                Console.WriteLine("La raiz cuadrada del número es: " + raizcuadrada);
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4)
            {
                raizcuadrada = Math.Pow(n2, 1 / 2d);
                Console.WriteLine("El número " + n2 + " es el mayor de los cuatro números");
                Console.WriteLine("La raiz cuadrada del número es: " + raizcuadrada);
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4)
            {
                raizcuadrada = Math.Pow(n3, 1 / 2d);
                Console.WriteLine("El número " + n3 + " es el mayor de los cuatro números");
                Console.WriteLine("La raiz cuadrada del número es: " + raizcuadrada);
            }
            else
            {
                raizcuadrada = Math.Pow(n4, 1 / 2d);
                Console.WriteLine("El número " + n4 + " es el mayor de los cuatro números");
                Console.WriteLine("La raiz cuadrada del número es: " + raizcuadrada);
            }
        }
    }
}
