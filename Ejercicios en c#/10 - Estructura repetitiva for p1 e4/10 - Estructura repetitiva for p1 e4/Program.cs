using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Estructura_repetitiva_for_p1_e4
{
    /*Escribir un programa que lea 10 números enteros y luego muestre cuántos valores ingresados fueron múltiplos de 3 y 
     * cuántos de 5. Debemos tener en cuenta que hay números que son múltiplos de 3 y de 5 a la vez.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, mulTres, mulCinco;
            mulTres = 0;
            mulCinco = 0;

            for (i=0; i<10; i++)
            {
                Console.Write((i+1)+".- Ingrese número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num%3==0)
                {
                    mulTres++;
                }
                if (num%5==0)
                {
                    mulCinco++;
                }
            }
            Console.WriteLine("Cantidad números que son múltiplos de tres: "+mulTres);
            Console.WriteLine("Cantidad números que son múltiplos de cinco: " + mulCinco);
            Console.ReadKey();
        }
    }
}
