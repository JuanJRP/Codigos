using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_Arreglos_S_J_M
{
   public class Promedio
    {
        float[,] Notas; //Matriz
        string[] Codigo;
        float[] ResN;
        int i, j;


        public void posicionXY(int x, int y)
        {
                Console.SetCursorPosition(x,y);
        }
        public Promedio(int N)
        {
            Console.Clear();
            Notas = new float[N, 8];
            Codigo = new string[N];
            ResN = new float[N];
        }

        // ingreso de los codigos de los estudiantes alfanumerico
        public void IngresoN() 
        {
            posicionXY(10, 5);
            Console.WriteLine("===== Promedio de notas =====");

            Cuadro();
            for (i = 0; i < Codigo.Length; i++)
            {
                posicionXY(20, 8);
                Console.WriteLine("Ingrese el codigo del estudiante N°{0}", i + 1);
                posicionXY(21, 11);
                Codigo[i] = Console.ReadLine();
                Limpiar();
            }
        }

        public void Limpiar()
        {
            for (int j1 = 21; j1 <= 34; j1++)
            {
                posicionXY(j1, 11);
                Console.WriteLine(" ");
            }
        }

        public void IngresoNotas() // ingreso de notas de la materias 
        {
            Console.Clear();
            posicionXY(10, 5);
            Console.WriteLine("===== Tabla de notas =====");
            Cuadro();

            posicionXY(20, 14);
            Console.WriteLine("Codigo");
            posicionXY(30, 14);
            Console.WriteLine("Español");
            posicionXY(40, 14);
            Console.WriteLine("Matematicas");
            posicionXY(55, 14);
            Console.WriteLine("Quimica");
            posicionXY(66, 14);
            Console.WriteLine("Sociales");
            posicionXY(78, 14);
            Console.WriteLine("Ciencias");
            posicionXY(88, 14);
            Console.WriteLine("Filosofia");
            posicionXY(102, 14);
            Console.WriteLine("Ingles");
            posicionXY(115, 14);
            Console.WriteLine("Arte");
           


            for (i = 0; i < Notas.GetLength(0); i++)
            {
                posicionXY(20, 15 + i);
                Console.WriteLine(Codigo[i]);
                posicionXY(20, 8);
                Console.WriteLine(Codigo[i]);
                for (j = 0; j < Notas.GetLength(1); j++)
                {
                    posicionXY(20, 9);
                    Console.WriteLine("Nota en {0}", j + 1);
                    posicionXY(21, 11);
                    float aux;

                    aux = float.Parse(Console.ReadLine());

                    if (aux > 5 || aux < 0) // condicional para que no ingresen notas incorrectas
                    {
                        posicionXY(30, 9);
                        Console.WriteLine("El numero no cumple con los parametros");
                        j -= 1;
                    }
                    else
                    {

                        Notas[i, j] = aux;
                    }

                    Limpiar();
                    posicionXY(33 + j * 12, 15 + i);
                    Console.WriteLine(Notas[i, j]);
                }
            }
        }
        public void Cuadro() // diseño del cuadro principal
        {
            for (i = 20; i <= 35; i++)
            {
                posicionXY(i, 10);
                Console.WriteLine("¦");
                posicionXY(i, 12);
                Console.WriteLine("¦");

            }
            posicionXY(20, 11);
            Console.WriteLine("¦");
            posicionXY(35, 11);
            Console.WriteLine("¦");

        }

        public void Resultados() // rsultado del promedio
        {
            for (i = 0; i < Notas.GetLength(0); i++)
            {
                for (j = 0; j < Notas.GetLength(1); j++)
                {
                    ResN[i] += Notas[i, j];//suma de filas
                }
                ResN[i] /= 8; //Divicion por cantidad
            }
        }
        public void Ordenar() // ordenar en forma ascendente 
        {
            float aux;
            string auxN;

            for (i = 0; i < Notas.GetLength(0); i++)
            {
                for (j = 0; j < Notas.GetLength(0) - 1; j++)
                {
                    if (ResN[j] > ResN[j + 1])
                    {
                        aux = ResN[j];
                        ResN[j] = ResN[j + 1];
                        ResN[j + 1] = aux;

                        auxN = Codigo[j];
                        Codigo[j] = Codigo[j + 1];
                        Codigo[j + 1] = auxN;
                    }
                }

            }
        }

        public void Imprimir()
        {
            Console.Clear();
            posicionXY(10, 5);
            Console.WriteLine("===== Promedios de notas =====");
            posicionXY(10, 8);
            Console.WriteLine("Posición");
            posicionXY(20, 8);
            Console.WriteLine("Codigo");
            posicionXY(30, 8);
            Console.WriteLine("Promedio de nota");

            for (i = 0; i < Notas.GetLength(0); i++)
            {
                posicionXY(10, 9 + i);
                Console.WriteLine("{0}", i + 1);
                posicionXY(20, 9 + i);
                Console.WriteLine(Codigo[i]);
                posicionXY(30, 9 + i);
                Console.WriteLine(ResN[i]);

                if (i == Notas.GetLength(0) - 1)
                {
                   
                    posicionXY(10, 10 + i);
                    Console.WriteLine("El codigo ");
                    posicionXY(20, 10 + i);
                    Console.WriteLine(Codigo[i] + " tiene el promedio mas alto: ");
                    posicionXY(60, 10 + i);
                    Console.WriteLine(ResN[i]);
                    Console.ReadKey();
                }
            }

            
        }
    }
}
