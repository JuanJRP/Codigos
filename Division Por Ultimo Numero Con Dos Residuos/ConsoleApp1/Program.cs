using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese El Numero");
            n = int.Parse(Console.ReadLine());
            Console.Clear();
            int r = modulo(n,0);
            int r2 = modulo2(n,0);
            dividir(n, 0, r, r2);
        } 
        static int modulo(int n, int residuo)
        {
            if (n > 1)
            {
                residuo = (n % 10);
                n = (n / 10);
                modulo(n, residuo);
                return residuo;
            }
            return residuo;
        }
        static int modulo2(int n, int residuo)
        {
            if (n > 1)
            {
                residuo = (n % 10);
                n = (n / 10);
                residuo = (n % 10);
                return residuo;
            }
            return residuo;
        }
        static void dividir(int n, int resultado, int r, int r2)
        {
            if (n > 9)
            {
                if (r <= 1)
                {
                    r = (r + (r2 * 10));
                    resultado = n / r;
                    Console.WriteLine($"La divicion de: {n} / {r} = {resultado}");
                    n = resultado;
                    dividir(n, resultado, r, r2);
                }
                else
                {
                    resultado = n / r;
                    Console.WriteLine($"La divicion de: {n} / {r} = {resultado}");
                    n = resultado;
                    dividir(n, resultado, r, r2);
                }
            }
        }
    }
}