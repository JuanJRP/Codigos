using System;

namespace cerosFactoriales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo del Factorial de un número entre (0 y 2^31).");
            Console.WriteLine("---------------------------------------------------------------------------");
            numeros();
        }
        static decimal numeros(decimal num = 0)
        {
            Console.Write("Ingrese el numero: ");
            num = decimal.Parse(Console.ReadLine());
            if (num < 0 || num > 2147483648)
            {
                Console.WriteLine("El numero ingresado esta fuera de los parametros.");
                numeros();
            }
            return factorial(num);
        }
        static decimal factorial(decimal num, decimal fact = 1, int i = 2)
        { 
            if (i <= num)
            {
                fact *= i;
                i += 1;
                factorial(num, fact, i);
            }
            return modulo(fact, fact, num);
        }
        static decimal modulo(decimal fact, decimal num, decimal numero, decimal residuo = 0, decimal cont = 0)
        {
            if (residuo == 0)
            {
                residuo = (num % 10);
                num = (num / 10);
                cont += 1;
                modulo(fact, num, numero, residuo, cont);
            }
            cont -= 1;
            Console.WriteLine($"El factorial de {numero} es: {fact} contiene {cont} ceros");
            Console.WriteLine("---------------------------------------------------------------------------");
            return numeros();
        }
    }
}