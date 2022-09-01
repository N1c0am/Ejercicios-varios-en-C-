using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Estructura_repetitiva_for_p1_e2
{
    /*Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre posteriormente
    *la suma de los valores ingresados y su promedio.
    Este problema ya lo desarrollamos, lo resolveremos empleando la estructura for.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, suma, promedio;
            suma = 0;

            for (int i=1; i<=10; i++)
            {
                Console.Write(i+".- Ingrese número: ");
                num = Convert.ToInt32(Console.ReadLine());
                suma += num;
            }
            Console.WriteLine("La suma es: "+suma);
            promedio = suma / 10;
            Console.WriteLine("El promedio es: "+promedio);
            Console.ReadKey();
        }
    }
}
