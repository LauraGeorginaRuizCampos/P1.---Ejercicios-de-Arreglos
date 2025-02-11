using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_100__real_no_fake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] grades = new float[6];


            Console.WriteLine("Favor de ingresar sus 5 calificaciones parciales: ");

            float suma = 0;

            for (int i = 0; i < 5; i++)
            {
                grades[i] = float.Parse(Console.ReadLine());
                suma += grades[i];
            }

            grades[5] = suma / 5;

            Console.WriteLine("La suma de sus calificaciones es de: " + suma);
            Console.WriteLine("Su promedio general es de: " + grades[5]);

            Console.ReadKey();
        }

    }
}

