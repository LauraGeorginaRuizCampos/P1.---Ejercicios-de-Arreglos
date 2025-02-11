using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args) // matriz 10rows y 3columns, rows 1y2 promedio
                                        // de 10añumnos en grupo a y b, row 3 promedio + de cada posición
        {
            float[,] gradeslol = new float[10, 3];

            Console.WriteLine("Ingrese los promedios de cada alumno: ");

            for (int row = 0; row < 10; row++)
            {
                Console.WriteLine($"\nAlumno {row + 1}: ");

                if (row < 5)
                {
                    Console.WriteLine("Ingrese el promedio del grupo A: ");
                    gradeslol[row, 0] = float.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ingrese el promedio del grupo B: ");
                    gradeslol[row, 1] = float.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < 10; row++)
            {
                gradeslol[row, 2] = Math.Max(gradeslol[row, 0], gradeslol[row, 1]);
            }

            Console.WriteLine("\nLos promedios de los alumnos son: ");

            for (int row = 0; row < 10; row++)
            {
                Console.WriteLine($"Alumno {row + 1}: Promedio grupo A: {gradeslol[row, 0]: 0.00} \tPromedio grupo B: {gradeslol[row, 1]:0.00} \tPromedio más alto: {gradeslol[row, 2]:0.00}");
            }
        }
    }
}
