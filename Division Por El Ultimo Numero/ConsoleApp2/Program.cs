using System;

namespace dividirNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            Console.WriteLine("Ingrese el numero");
            int k = int.Parse(Console.ReadLine());
            int s = 10;
            dividir(k,s,p);
        }

        static int modulo(int a, int c)
        {
            int s = 0, p= 0;
            if (a > 1)
            {
                modulo2(a,c);
                s = s + (a % 10);
                a = a / 10;
                c = c + 1;
                modulo(a, c);
                Console.WriteLine(s);
                
                return s;
                
            }
           return c;
        }
        static int modulo2(int a, int c)
        {
            int s = 0;
            if (a > 1)
            {
                s = s + (a % 10);
                a = a / 10;
 
                if (c == c +1)
                {
                    s = s;
                    Console.WriteLine("is"+s);

                }

                modulo2(a,s);
                return s;
            }
            else return s;
        }

        static void dividir(int a, int s, int p)
        {
            
            if (s >= 10)
            {
                s = modulo(a, 0);
            }
            if (a > 10)
            {
                if (s <= 1)
                {
                    s = (p * 10) + s;
                }

                int r = a / s;
                Console.WriteLine($"El numero {a} / {s} = {r}");
                a = r;
                dividir(r,s,p);
            }
        }
    }
}