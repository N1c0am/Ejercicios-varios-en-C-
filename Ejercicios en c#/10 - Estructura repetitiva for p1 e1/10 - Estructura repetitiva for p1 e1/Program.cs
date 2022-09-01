using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Estructura_repetitiva_for_p1_e1
{
    //Realizar un programa que imprima en pantalla los números del 1 al 100.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num=1; num<=100; num++)
            {
                Console.Write(num+", ");
            }
            Console.ReadKey();
        }
    }
}
