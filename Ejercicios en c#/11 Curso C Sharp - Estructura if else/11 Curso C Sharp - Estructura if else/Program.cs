using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Curso_C_Sharp___Estructura_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Pedir un número decimal por pantalla y guardarlo en una variable
             * Cuando el número decimal sea positivo y mayor que 15, pero menor que 1000 escribir "xxxxxxxxxx"
             * Cuando el número decimal sea negativo y este entre -15 y -30 escribir "zzzzzzzzz"
             * Si no cumple nunguna escribe "wwwwwwww" */

            decimal numero;
            Console.WriteLine("Ingrese número: ");
            numero = Convert.ToDecimal(Console.ReadLine());

            if (numero > 0 && (numero > 15 && numero < 1000))
            {
                Console.WriteLine("xxxxxxxxxx");
            }
            else if (numero < 0 && (numero < -15 && numero > -30))
            {
                Console.WriteLine("zzzzzzzzz");
            }
            else
                Console.WriteLine("wwwwwwww");

            Console.ReadKey();

        }
    }
}
