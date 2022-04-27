using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aplicación_Arreglos_S_J_M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEstudiantes;
            Console.Write("Ingrese el numero de estudiantes: ");
            numeroEstudiantes = int.Parse(Console.ReadLine());
            Promedio PM22 = new Promedio(numeroEstudiantes);
            PM22.IngresoN();
            PM22.IngresoNotas();
            PM22.Resultados();
            PM22.Ordenar();
            Thread.Sleep(1000);
            PM22.Imprimir();
            Console.ReadKey();


        }
    }
}
