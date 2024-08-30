using System;

namespace temperatura
{
    class Program
    {/* Utilizando un método se necesita saber: una temperatura en grados 
        centígrados permita devolver el resultado si tiene fiebre o alta NOTA: 
        se considera que tiene fiebre si es mayor a los 37°.
      */

        static void Main(string[] args)
        {
            double temperatura;

            Console.WriteLine("Digite la temperatura en grados centrigrados");
            temperatura = double.Parse(Console.ReadLine());

            if (temperatura >= 41)
            {
                Console.WriteLine("Temperatura demasiada alta tiene HIPERTERMIA");
            }
            else if (temperatura <= 40.9 && temperatura >= 39.6)
            {
                Console.WriteLine("Temperatura alta tiene FIEBRE ALTA");
            }
            else if (temperatura <=39.5 && temperatura >= 37)
            {
                Console.WriteLine("Temperatura alta tiene FIEBRE");
            }
            else if (temperatura <= 36.9 && temperatura >= 35)
            {
                Console.WriteLine("Temperatura NORMAL");
            }
           else
            {
                Console.WriteLine("Temperatura demasiada BAJA tiene HIPOTERMIA");
            }
        }
    }
}
