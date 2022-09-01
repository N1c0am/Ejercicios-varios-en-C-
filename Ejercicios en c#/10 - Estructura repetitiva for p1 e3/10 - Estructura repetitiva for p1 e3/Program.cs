using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Estructura_repetitiva_for_p1_e3
{
    //Escribir un programa que lea 10 notas de alumnos y nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota, mayor, menor;
            mayor = 0;
            menor = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write((i+1)+".- Ingrese nota: ");
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota >= 7)
                {
                    mayor++;
                }
                else
                {
                    menor++;
                }
            }
            Console.WriteLine("Cantidad de números mayores o iguales a siete: "+mayor);
            Console.WriteLine("Cantidad de números menores a siete: " + menor);
            Console.ReadKey();
        }
    }
}
