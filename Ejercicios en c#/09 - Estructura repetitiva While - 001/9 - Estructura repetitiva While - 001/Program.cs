using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Estructura_repetitiva_While___001
{
    //Realizar un programa que imprima en pantalla los números del 1 al 100.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i<=100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
