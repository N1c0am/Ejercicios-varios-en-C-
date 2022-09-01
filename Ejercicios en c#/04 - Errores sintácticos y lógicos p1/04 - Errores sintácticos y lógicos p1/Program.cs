using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Errores_sintácticos_y_lógicos_p1
{
//Hallar la superficie de un cuadrado conociendo el valor de un lado.
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            Console.WriteLine("Ingrese el lado del cuadrado: ");
            lado = Convert.ToDouble(Console.ReadLine());

            double superficie = lado * lado;
            Console.WriteLine("La superficie es: "+superficie);

            Console.ReadKey();
        }
    }
}
