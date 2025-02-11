using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args) //20 num en 3 arrays , 1ero numero tecelado, 2do cuadraco, 3ero cubo
        {
            Random nums = new Random();

            int[] lol0 = new int[20];
            int[] lol2 = new int[20];
            int[] lol3 = new int[20];

            for (int i = 0; i < lol0.Length; i++)
            {
                lol0[i] = nums.Next(1, 200);
                lol2[i] = lol0[i] * lol0[i];
                lol3[i] = lol0[i] * lol0[i] * lol0[i];
            }

            Console.WriteLine("Número original\tAl cuadrado\tAl cubo ");
            for (int i = 0; i < lol0.Length; i++)
            {
                Console.WriteLine($"{lol0[i]}\t\t{lol2[i]}\t\t{lol3[i]}");
            }
        }
    }
}
