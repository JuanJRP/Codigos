using System;

namespace cerosFactoriales
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num=0, fact = 1;
            Console.WriteLine("Calculo del Factorial de un número.");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Numeros Por Defecto: 3, 5, 10, 24.");
            factorial(3);
            factorial(5);
            factorial(10);
            factorial(24);
            Console.WriteLine("------------------------------------------------------------------");
            Console.Write("Si desea probar un numero por favor digitelo: ");
            num = decimal.Parse(Console.ReadLine());
            factorial(num);

        }
        static decimal factorial(decimal num, decimal fact = 1)
        {
            for (decimal i = 2; i <= num; i++)
            {
                fact *= i;
            }
            return modulo(fact,fact,num);
            Console.WriteLine($"El factorial de num es : {fact} contiene ceros");
        }
        static decimal modulo(decimal fact,decimal num,decimal numero, decimal residuo = 0, decimal cont = 0)
        {
            do 
            { 
                residuo = (num % 10); 
                num = (num / 10); 
                cont += 1; 
            } while (residuo == 0);
            cont -= 1;
            Console.WriteLine($"El factorial de {numero} es : {fact} contiene {cont} ceros");
            return cont -= 1;            
        }

    }
}
