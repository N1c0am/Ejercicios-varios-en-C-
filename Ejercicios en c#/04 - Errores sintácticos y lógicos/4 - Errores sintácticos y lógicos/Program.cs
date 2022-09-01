using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Errores_sintácticos_y_lógicos
{
    //Hallar la superficie de un cuadrado conociendo el valor de un lado.
    internal class Program
    {
        static void Main(string[] args)
        {
            float superficie, lado;
            string linea;

            Console.WriteLine("Ingrese el lado del cuadrado:");
            linea = Console.ReadLine();
            lado = float.Parse(linea);

            superficie = lado * lado;

            Console.WriteLine("La superficie del cuadrado es: " + superficie);
            Console.ReadKey();
        }
    }
}
