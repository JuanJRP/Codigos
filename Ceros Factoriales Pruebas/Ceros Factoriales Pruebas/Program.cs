using System;

namespace cerosFactoriales
{
    class Program
    {
        static void Main(string[] args)
        {
            int nump,temp,i;
            decimal num = 0, fact = 1;
            Console.WriteLine("Calculo del Factorial de un número entre (0 y 2^31).");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.Write("Ingrese el numero de pruebas: ");
            nump = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------");
            int[] vector = new int[nump];
            for ( i = 0; i <= nump - 1; i++)
            {
                Console.Write("Ingrese Los Numeros de prueba: ");
                temp = int.Parse(Console.ReadLine());
                if (temp < 0 || temp > 2147483648)
                {
                    Console.WriteLine("El numero Incumple los parametros, Digite nuevamente el numero.");
                    i = i - 1;
                }
                else
                {
                    vector[i] = temp;
                }
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            for (i = 0; i <= nump - 1; i++)
            {
                factorial(vector[i]);
            }
            Console.WriteLine("---------------------------------------------------------------------------");
        }
        static decimal factorial(decimal num, decimal fact = 1)
        {
            for (decimal i = 2; i <= num; i++)
            {
                fact *= i;
            }
            return modulo(fact, fact, num);
        }
        static decimal modulo(decimal fact, decimal num, decimal numero, decimal residuo = 0, decimal cont = 0)
        {
            do
            {
                residuo = (num % 10);
                num = (num / 10);
                cont += 1;
            } while (residuo == 0);
            cont -= 1;
            Console.WriteLine($"El factorial de {numero} es: {fact} contiene {cont} ceros");
            return cont -= 1;
        }
    }
}