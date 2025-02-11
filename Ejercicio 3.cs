using System;

namespace Ejercicio_3_lol
{
    internal class Program
    {
        static void Main(string[] args) // mtriz 5 row y 4 columns con 3 grades y promedio, 5 alumnos
        {
            // xrows  ycolumns
            float[,] gradeslol = new float[5, 4];

            Console.WriteLine("Ingrese las calificaciones de los 3 parciales de cada alumno:");

            for (int row = 0; row < 5; row++)
            {
                float suma = 0; 

                Console.WriteLine($"\nAlumno {row + 1}:");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"Ingrese la calificación {col + 1}: ");
                    gradeslol[row, col] = float.Parse(Console.ReadLine()); 
                    suma += gradeslol[row, col]; 
                }

                gradeslol[row, 3] = suma / 3;
            }

            Console.WriteLine("\nLas calificaciones y los promedios son:");
            for (int row = 0; row < 5; row++)
            {
                Console.Write($"Alumno {row + 1}: ");
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(gradeslol[row, col] + "\t"); 
                }
                Console.WriteLine(); 
            }
        }
    }
}

