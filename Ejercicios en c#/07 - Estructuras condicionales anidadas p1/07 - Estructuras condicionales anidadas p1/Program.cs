using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Estructuras_condicionales_anidadas_p1
{
/*Confeccionar un programa que pida por teclado tres notas de un alumno, calcule el promedio e imprima alguno de estos mensajes:
Si el promedio es >=7 mostrar "Promocionado".
Si el promedio es >=4 y <7 mostrar "Regular".
Si el promedio es <4 mostrar "Reprobado".*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("Ingrese 1ra nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese 2da nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese 3ra nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            double promedio = (n1 + n2 + n3) / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else if (promedio >= 4)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
            Console.ReadKey();
        }
    }
}
