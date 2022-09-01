using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Estructura_repetitiva_for_p1_e5
{
    //Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, cantidad, num, mayor;
            mayor = 0;

            Console.WriteLine("Ingrese cantidad de números a ingresar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= cantidad; i++)
            {
                Console.Write(i+".- Ingrese número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 1000)
                {
                    mayor++;
                }
            }

            Console.WriteLine("La cantidad de números mayores o iguales a 1000: "+mayor);
            Console.ReadKey();
        }
    }
}
