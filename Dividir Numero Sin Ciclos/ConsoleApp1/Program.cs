using System;

namespace dividirNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero");
            float a = float.Parse(Console.ReadLine());
            dividir(a);
        }

        static void dividir(float a)
        {
            if (a >= 1)
            {
                float r = a / 2;
                a = r;
                Console.WriteLine($"El numero {a} / 2 = {r}");
                dividir(r);
            } 
            
        }
    }
}