using System;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {

                Triangulo miTriangulo = new Triangulo(); //Declaración e instancia de la clase triangulo            
                Console.WriteLine("Digite la base del triángulo: ");
                double b,a;
                b = double.Parse(Console.ReadLine());
                miTriangulo.setBase(b); //Se envía con set el valor de la base a la clase

                Console.WriteLine("Digite la altura del triángulo: ");
                a = double.Parse(Console.ReadLine()); //Se envía con set el valor de la altura a la clase
                miTriangulo.setAltura(a);

                Console.WriteLine("El área del triángulo es: ");
                double area = miTriangulo.HallarArea(miTriangulo.getBase(), miTriangulo.getAltura()); //Con get se obtiene la base y la altura de la clase tríangulo
                Console.WriteLine(area);

                if (area > 1000) //uso de condicional SI para validar si el área es mayor a 1000
                {
                    Console.WriteLine("El area es mayor a una hectarea y puede contruir");
                }

                else { // Si no cumple la condición con el SI NO quiere decir que es menor de 1000
                    Console.WriteLine("El area es menor a una hectarea y NO puede contruir");
                }
            }       
        }
    }

    class Triangulo { 
        private double baseT=0;        
        public double altura=0;
        public double areat=0;

        public double HallarArea(double baseT, double altura) //método para hallar el área
        {
            areat = (baseT * altura) / 2;
            return areat;
        }
        public double getBase()  //método get base
        {
            return baseT;
        }
        public void setBase(double b) { //método set de la base
            baseT = b;
        }

        public double getAltura()    //método get de la altuta
        {
            return altura;
        }
        public void setAltura(double a)   //método set de la altura
        {
            altura= a;
        }
    }   

}
