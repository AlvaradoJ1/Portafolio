using System;

namespace primo_o_no
{
    class Program
    {/* Utilizando un método se necesita saber: si un número es primo o no. 
        Un número es primo solo si es divisible entre 1 y sí mismo (por 
        ejemplo: 2, 3, …,13, 17, 19…).
     */

        static void Main(string[] args)
        {
            int n1;
            int C = 0;

            Console.WriteLine("Digite número ");
            n1 = int.Parse(Console.ReadLine());

            for (int i = 2; i < n1;i++)
            {
                if (n1 % i == 0)
                {
                    C = C + 1;
                }
            }
            if (C == 0)
            {
                Console.WriteLine(n1 + " !ES PRIMO!");
            }
            else
            {
                Console.WriteLine(n1 + " !NO ES PRIMO!");
            }
        }
    }
}
