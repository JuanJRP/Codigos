using System;

namespace Actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0, i, n = 0;
            Console.WriteLine("Ingrese El Numero Que Desea Elevar");
            n = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("El Numero " + n + " Elevado Al Cuadrado (" + n + "^2) Es Igual A La Suma De:");
            Console.WriteLine("----------------------------------------------------------------------------");
            
            for (i = 1; i < n * 2 - 1; i++)
            {
                resultado = resultado + i;
                Console.Write(i);
                Console.Write(" + ");
                i = i + 1;
            }
            resultado = resultado + i;
            Console.Write( i + " = " + resultado);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
        }
        
    }
}