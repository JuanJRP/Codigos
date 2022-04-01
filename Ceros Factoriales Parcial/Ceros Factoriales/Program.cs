using System;

namespace cerosFactoriales
{
    class Program
    {
        static void Main(string[] args)
        {
            numero();
        }
        static decimal numero(decimal num=0)
        {
            Console.Write("Por favor Digite un número entero: ");
            num = decimal.Parse(Console.ReadLine());
            return Factorial(num);
        }
        static decimal Factorial(decimal num = 0,decimal i = 2, decimal fact = 1)
        {
            if (i <= num)
            {
                fact *= i;
                i += 1;
                Factorial(num,i,fact);
            }
            return modulo(fact, 0, 0,num,fact);
        }
        static decimal modulo(decimal n, decimal residuo, decimal cont, decimal num, decimal fact)
        {
            if (residuo == 0)
            {
                residuo = (n % 10); 
                n = (n / 10); 
                cont += 1;
                modulo(n, residuo, cont, num, fact);
            }
            cont -= 1;
            Console.WriteLine($"El factorial de {num} es: {fact} contiene {cont} ceros");
            return numero();
        }
    }
}
