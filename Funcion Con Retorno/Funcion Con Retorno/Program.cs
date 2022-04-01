using System;

namespace Prueba
{

    class Program
    {
        static int suma(int num1, int num2) => num1 + num2;

        static void Main(string[] args)
        {
            Console.WriteLine("Suma De Numeros");
            Console.Write("Ingrese El Primer Numero A Sumar: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese El Segundo Numero A Sumar: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"La Suma De Los Numeros {a} + {b} Es: {suma(a, b)}");
        }
    }
}