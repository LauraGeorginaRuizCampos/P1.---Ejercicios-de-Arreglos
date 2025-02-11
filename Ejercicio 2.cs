using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_lol
{
    internal class Program
    {
        static void Main(string[] args) // array 1y2 grupos de 5, array 3 orden +-
        {
            float[] grades1 = new float[5]; //grupo 1

            Console.WriteLine("Favor de ingresar las calificaciones del primer grupo: ");

            for (int i = 0; i < grades1.Length; i++)
            {
                grades1[i] = float.Parse(Console.ReadLine());

            }


            float[] grades2 = new float[5]; //grupo 2

            Console.WriteLine("\nFavor de ingresar las calificaciones del segundo grupo: ");

            for (int i = 0; i < grades2.Length; i++)
            {
                grades2[i] = float.Parse(Console.ReadLine());

            }

            float[] gradesfinal = new float[grades1.Length + grades2.Length]; // total organizado

            grades1.CopyTo(gradesfinal, 0);
            grades2.CopyTo(gradesfinal, grades1.Length);

            gradesfinal = gradesfinal.OrderByDescending(x => x).ToArray();

            Console.WriteLine("\nLas calificaciones totales de mayor a menor: ");
            for (int i = 0; i < gradesfinal.Length; i++) 
            {
                Console.WriteLine("Calificación " + (i + 1) + ": " + gradesfinal[i]);
            }

        }
    }
}
