using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Estructura_repetitiva_do_while_p1_e1
{
    //Escribir un programa que solicite la carga de un número entre 0 y 999, y nos muestre un mensaje de cuántos dígitos
    //tiene el mismo. Finalizar el programa cuando se cargue el valor 0.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.Write("Ingrese número entre 0 y 999 digitos: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 1000 && num >= 100)
                {
                    Console.WriteLine("El número tiene 3 dígitos");
                }
                else
                    if(num < 100 && num >= 10)
                    {
                    Console.WriteLine("El número tiene 2 dígitos");
                    }
                else
                    if (num < 10 && num >= 0)
                {
                    Console.WriteLine("El número tiene 1 dígito");
                }
            } 
            while (num != 0);
            Console.ReadKey();
        }
    }
}
