using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args) //20 nums, pares o impares
        {
            Random nums = new Random();
            int[] num = new int[20];
            int par = 0;
            int impar = 0;

            for (int i = 0;  i < num.Length; i++)
            {
                num[i] = nums.Next(1, 21);
                Console.WriteLine(num[i]);

                if (num[i] % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1; 
                }
            }

            Console.WriteLine("Los números pares son: " + par + "\nLos números impares son: " + impar);
        }
    }
}
