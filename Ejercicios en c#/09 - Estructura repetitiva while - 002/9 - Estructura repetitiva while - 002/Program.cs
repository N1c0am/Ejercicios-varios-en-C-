using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Estructura_repetitiva_while___002
{
    /*Escribir un programa que solicite la carga de un valor positivo y nos muestre desde 1 hasta el valor ingresado de uno en uno.
    Ejemplo: Si ingresamos 30 se debe mostrar en pantalla los números del 1 al 30.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, i;
            string letra;

            Console.WriteLine("Ingrese un valor positivo: ");
            letra = Console.ReadLine();
            valor = int.Parse(letra);
            Console.WriteLine("***************************");

            if (valor > 0)
            {
                i = 1;
                while (i <= valor)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
           
            Console.ReadKey();
        }
    }
}
