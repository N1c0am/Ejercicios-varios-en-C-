using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Condiciones_compuestas_con_operadores_lógicos_p1
{
//Confeccionar un programa que lea por teclado tres números distintos y nos muestre el mayor.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Ingrese 1er número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese 2do número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese 3er número: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + " es el mayor");
            }
            else if (n2 > n3)
            {
                Console.WriteLine(n2 + " es el mayor");
            }
            else
            {
                Console.WriteLine(n3 + " es el mayor");
            }

            Console.ReadKey();
        }
    }
}
