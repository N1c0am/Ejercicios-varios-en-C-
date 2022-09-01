using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Estructura_repetitiva_while_p1_e4
{
/*Una planta que fabrica perfiles de hierro posee un lote de n piezas.
Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y luego ingrese la longitud de cada perfil;
sabiendo que la pieza cuya longitud esté comprendida en el rango de 1,20 y 1,30 son aptas. Imprimir por pantalla la cantidad de 
piezas aptas que hay en el lote.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad, x, aptas;
            double longitud;
            x = 1;
            aptas = 0;

            Console.Write("Ingrese cantidad de piezas: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (x <= cantidad)
            {
                Console.WriteLine(x+".- Ingrese longitud de la pieza (rango de 1,20 y 1,30 son aptas): ");
                longitud = Convert.ToDouble(Console.ReadLine());
                x++;
                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    aptas++;
                }
            }
            Console.WriteLine("cantidad de piezas aptas que hay en el lote: " + aptas);
            Console.ReadKey();
        }
    }
}
