using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Estructura_repetitiva_do_while_p1_e3
{
/*Realizar un programa que permita ingresar el peso (en kilogramos) de piezas. El proceso termina cuando ingresamos el valor 0. 
 * Se debe informar:
a) Cuántas piezas tienen un peso entre 9.8 Kg. y 10.2 Kg.?, cuántas con más de 10.2 Kg.? y cuántas con menos de 9.8 Kg.?
b) La cantidad total de piezas procesadas.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double cant, num, cantMenor, cantMedio, cantMayor;
            cant = 0;
            cantMenor = 0;
            cantMedio = 0;
            cantMayor = 0;

            do
            {
                
                Console.Write((cant+1) + ".- Ingrese peso en kg de las piezas: ");
                num = Convert.ToDouble(Console.ReadLine());

                if (num > 0)
                {
                    cant++;

                    if (num > 10.2)
                    {
                        cantMayor++;
                    }
                    else if (num >= 9.8)
                    {
                        cantMedio++;
                    }
                    else
                    {
                        cantMenor++;
                    }
                }
                
            }
            while (num != 0);

            Console.WriteLine("Cantidad de piezas con más de 10.2 Kg: "+cantMayor);
            Console.WriteLine("Cantidad de piezas entre 9.8 Kg. y 10.2 Kg: " + cantMedio);
            Console.WriteLine("Cantidad de piezas con menos de 9.8 Kg: " + cantMenor);

            Console.ReadKey();
        }
    }
}
