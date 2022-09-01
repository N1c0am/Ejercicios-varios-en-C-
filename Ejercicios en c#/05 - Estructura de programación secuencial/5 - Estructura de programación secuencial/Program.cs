using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Estructura_de_programación_secuencial
{
    internal class Program
    {
        //Realizar la carga de dos números enteros por teclado e imprimir su suma y su producto.
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            string linea;

            Console.WriteLine("Ingrese el 1er número entero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el 2do número entero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            suma = num1 + num2;
            producto = num1 * num2;

            Console.WriteLine("La suma de "+num1+"+"+num2+"="+ suma);
            Console.WriteLine("El producto de " + num1 + "*" + num2 + "=" + producto);
            Console.ReadKey();
        }
    }
}
