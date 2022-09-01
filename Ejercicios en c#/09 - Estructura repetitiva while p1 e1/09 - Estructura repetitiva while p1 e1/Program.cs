using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Estructura_repetitiva_while_p1_e1
{
    //Realizar un programa que imprima en pantalla los números del 1 al 100.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num <= 100)
            {
                Console.Write(num + ", ");
                num++;
            }
            Console.ReadKey();
        }
    }
}
