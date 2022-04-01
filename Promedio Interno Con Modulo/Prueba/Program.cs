using System;

namespace ConsoleApp1 
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            float suma = 0, contador = 0;

            Console.WriteLine("Ingrese un numero minimo de 2 y maximo de 8 cifras");
            num = int.Parse(Console.ReadLine());

            if (num > 9 & num < 100000000)
            {
                while (num >= 1)
                {
                    suma = suma + (num % 10);
                    num = num / 10;
                    contador = contador + 1;
                }
                Console.WriteLine("El Promedio interno es Suma/contador = " + suma/contador);
            }
            else 
            {
                Console.WriteLine("Este numero no es valido");
            }
        }
    }
}


