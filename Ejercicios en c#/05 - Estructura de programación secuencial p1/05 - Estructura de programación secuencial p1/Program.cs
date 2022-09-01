using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Estructura_de_programación_secuencial_p1
{
    //Realizar la carga de dos números enteros por teclado e imprimir su suma y su producto.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Ingrese número entero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número entero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            int suma = n1 + n2;
            int producto = n1 * n2;
            Console.WriteLine("Las suma es: " + suma);
            Console.WriteLine("El producto es: " + producto);

            Console.ReadKey();
        }
    }
}
