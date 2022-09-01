using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Estructura_repetitiva_while_p1_e2
{
/*Escribir un programa que solicite la carga de un valor positivo y nos muestre desde 1 hasta el valor ingresado de uno en uno.
Ejemplo: Si ingresamos 30 se debe mostrar en pantalla los números del 1 al 30.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, x;
            x = 1;
            Console.Write("Ingrese número positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (x <= num) 
            { 
                Console.WriteLine(x.ToString());
                x++;
            }
            Console.ReadKey();
        }
    }
}
