using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {

        static void Main(string[] args) //sumatoria de 100 ventas
        {
            float suma = 0;

            Random sales = new Random();

            float[] clients = new float[100];

            for (int i = 0; i < clients.Length; i++)
            {
                clients[i] = sales.Next(100, 110);
                suma += clients[i];
                Console.WriteLine("El total del cliente número " + i + " es de " + clients[i]);

            }

            Console.WriteLine("Los ingresos del día de hoy son: " + suma);
        }
    }
}
