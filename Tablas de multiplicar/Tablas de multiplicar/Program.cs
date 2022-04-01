using System;
namespace Actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int Multiplicar, i, u, F, resultado = 0;

            Console.WriteLine("Que Numero De Tabla Desea Ver");
            Multiplicar = int.Parse(Console.ReadLine());

            Console.WriteLine("Desde Que Numero Desea Que Inicie La Tabla De Multiplicar");
            u = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasta Que Numero Quiere Que Finalice La Tabla De Multiplicar");
            F = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Tabla Del " + Multiplicar);
            Console.WriteLine("-------------------------");

            for (i = u; i < F + 1 ; i++)
            {
                resultado = Multiplicar * i;
                Console.WriteLine(Multiplicar + (" x ") + i + (" = ") + resultado);
            }
        }
    }
}