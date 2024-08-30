using System;

namespace Notas
{
    class Program
    {/* Desarrolle una solución básica de programación que pida por teclado
        tres (3) notas de un estudiante, se debe validar mediante un método
        que la nota esté entre 0 y 5 por tanto en caso de que se ingresen otros 
        valores dar un mensaje que diga valor no valido.
        Debe tener en cuenta que la nota puede ser un valor real, ejemplo 2.5 
        una vez obtenidas las tres (3) notas se debe calcular el promedio de 
        estas e imprima por pantalla alguno de los siguientes mensajes:
            • Si el promedio es >=4.6 mostrar "Excelente"
            • Si el promedio es >=4.0 y =<4.5 mostrar "Muy bueno"
            • Si el promedio es >=3.5 y =<3.9 mostrar "Bueno"
            • Si el promedio es >=3.0 y =<3.4 mostrar "Satisfactorio"
            • Si el promedio es <3 mostrar "Deficiente"
     */
        static void Main(string[] args)
        {
            double nota;
            double notas = 0;
            double promedio;

            for (int i = 1; i <= 3;)
            {
                Console.WriteLine("Digite la calificacion numero " + i);
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 5)
                {
                    notas = notas + nota;
                    i = i + 1;
                }
                else
                {
                    Console.WriteLine("VALOR NO VALIDO");
                }
            }
            promedio = notas / 3;
            if (promedio >= 4.6)
            {
                Console.WriteLine("Su promedio es: " + promedio + " ¡¡EXCELENTE!!");
            }
            else if (promedio >= 4 && promedio <= 4.5)
            {
                Console.WriteLine("Su promedio es: " + promedio + " ¡MUY BUENO!");
            }
            else if (promedio >= 3.5 && promedio <= 3.9)
            {
                Console.WriteLine("Su promedio es: " + promedio + " ¡BUENO!");
            }
            else if (promedio >= 3 && promedio <= 3.4)
            {
                Console.WriteLine("Su promedio es: " + promedio + " ¡SATISFACTORIO!");
            }
            else
            {
                Console.WriteLine("Su promedio es: " + promedio + " ¡DEFICIENTE!");
            }
        } 
    } 
}
