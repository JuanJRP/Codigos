using System;

namespace Calculadora 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ans;
            do
            {
                Console.Write("Ingrese el numero 1: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero 2: ");
                float num2 = float.Parse(Console.ReadLine());
                Console.Clear();

                switch ((ans = Menu()))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"La suma de {num1} + {num2} = {suma(num1, num2)}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"La resta de {num1} - {num2} = {resta(num1, num2)}");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"La division de {num1} / {num2} = {division(num1, num2)}");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"La multiplicacion de {num1} x {num2} = {multiplicacion(num1, num2)}");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("El programa finalizo...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("El numero ingresado no esta en el menu");
                        break;
                }

            } while (ans != 5);
        }
        static int Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 Para suma");
            Console.WriteLine("2 Para resta");
            Console.WriteLine("3 Para division");
            Console.WriteLine("4 Para multiplicacion");
            Console.WriteLine("5 Para Salir");
            int ans = int.Parse(Console.ReadLine());
            return ans;
        }
        static float suma(float num1, float num2) => num1 + num2;
        static float resta(float num1, float num2) => num1 - num2;
        static float division(float num1, float num2) => num1 * num2;
        static float multiplicacion(float num1, float num2) => num1 / num2;
    }
}