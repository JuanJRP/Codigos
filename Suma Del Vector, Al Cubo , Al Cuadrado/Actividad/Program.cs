using System;

namespace Actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            int suma = 0;
            int cuadrado = 2;
            int Cubo = 3;
            int[] v = new int[10];
            int i;
            var seed = Environment.TickCount;
            var ramdom = new Random(seed);

            for (i = 0; i < 10; i++)
            {
                var value = ramdom.Next(1, 9);
                v[i] = value;
                Console.WriteLine("Vector En La Posicion " + i + " Es " + v[i]);
            }

            for (i = 0; i < 10; i++)
            {
                suma = suma + v[i];
            }

            Console.WriteLine("La Suma Total De Los Vector Es: " + suma);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Vector Elevado Al Cuadrado");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Vector En La Posicion " + i + " Es " + Math.Pow(v[i], cuadrado));
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Vector Elevado Al Cubo");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Vector En La Posicion " + i + " Es " + Math.Pow(v[i], Cubo));
            }
        }
    }
}