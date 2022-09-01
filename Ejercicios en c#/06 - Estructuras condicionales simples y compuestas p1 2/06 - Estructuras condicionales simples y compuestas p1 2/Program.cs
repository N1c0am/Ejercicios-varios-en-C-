using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Estructuras_condicionales_simples_y_compuestas_p1_2
{
//Realizar un programa que solicite ingresar dos números distintos y muestre por pantalla el mayor de ellos.


    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Ingrese el 1er número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do número:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " es el mayor");
            }
            else
            {
                Console.WriteLine(n2 + " es el mayor");
            }

            Console.ReadKey();
        }
    }
}
