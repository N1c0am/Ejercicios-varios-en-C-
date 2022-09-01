using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Estructura_repetitiva_while_p1_e3
{
/*Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre posteriormente la suma de los valores 
* ingresados y su promedio.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, x, suma, promedio;
            x = 1;
            suma = 0;

            while (x <= 10)
            {
                Console.Write(x+".- Ingrese número: ");
                num = Convert.ToInt32(Console.ReadLine());
                x++;
                suma += num;
            }
            Console.WriteLine("La suma es: "+suma);
            promedio = suma/10;
            Console.WriteLine("El promedio es: "+promedio);
            Console.ReadKey();
        }
    }
}
