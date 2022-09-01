using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Estructuras_condicionales_anidadas
{
    /*Confeccionar un programa que pida por teclado tres notas de un alumno, calcule el promedio e imprima alguno de estos mensajes:
    Si el promedio es >=7 mostrar "Promocionado".
    Si el promedio es >=4 y <7 mostrar "Regular".
    Si el promedio es <4 mostrar "Reprobado".*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, promedio;
            string linea;

            Console.WriteLine("Ingrese la primera nota del alumno");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese la segunda nota del alumno");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("Ingrese la tercera nota del alumno");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            promedio = (num1 + num2 + num3) / 3;

            Console.WriteLine("***********Según las notas obtenidas: *************");

            if (promedio >= 7)
                Console.WriteLine("Promocionado");
            else
                if (promedio >= 4)
                Console.WriteLine("Regular");
            else
                Console.WriteLine("Reprobado");
            Console.ReadKey();
        }
    }
}
