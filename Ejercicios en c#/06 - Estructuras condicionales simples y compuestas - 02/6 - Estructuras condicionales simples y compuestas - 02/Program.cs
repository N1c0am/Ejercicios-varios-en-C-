using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Estructuras_condicionales_simples_y_compuestas___02
{
    //Realizar un programa que solicite ingresar dos números distintos y muestre por pantalla el mayor de ellos.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;

            Console.WriteLine("Ingrese el 1er número: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el 2do número");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
                Console.WriteLine("El N°" + num1 + " es mayor que el N°" + num2);
            else
                if (num1 < num2)
                Console.WriteLine("El N°" + num1 + " es menor que el N°" + num2);
            else
                Console.WriteLine("El N°" + num1 + " es igual que el N°" + num2);
            
            Console.ReadKey();
        }
    }
}
