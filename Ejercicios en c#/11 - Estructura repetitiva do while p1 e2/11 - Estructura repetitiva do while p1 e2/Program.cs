using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Estructura_repetitiva_do_while_p1_e2
{
    //Escribir un programa que solicite la carga de números por teclado, obtener su promedio.
    //Finalizar la carga de valores cuando se cargue el valor 0.
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, num, suma, promedio;
            x = 0;
            suma = 0;

            do
            {
                Console.Write((x+1)+".- Ingrese número: ");
                num = Convert.ToDouble(Console.ReadLine());
                if (num != 0)
                {
                    x++;
                    suma = suma + num;
                }
                
            }
            while (num != 0);

                promedio = suma / x;
            
            if (promedio > 0)
            {
                Console.WriteLine("El promedio es: " + promedio);
            }  
            
            Console.ReadKey();
        }
    }
}
