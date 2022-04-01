using System;

namespace Multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numeros a ingresar: ");
            int final = int.Parse(Console.ReadLine());
            multiplos(final);   
        }
        static void multiplos(int final)
        {
            int contador = 0;

            for (int i = 0; i < final; i++)
            {
                Console.Write("Ingrese el numero: ");
                int num = int.Parse(Console.ReadLine());

                int modulo = num % 3;

                if (modulo == 0)
                {
                   contador = contador + 1;
                }
            }
            Console.WriteLine($"Cantidad de numeros multiplos de tres ingresados es: {contador}");
        }
    }
}