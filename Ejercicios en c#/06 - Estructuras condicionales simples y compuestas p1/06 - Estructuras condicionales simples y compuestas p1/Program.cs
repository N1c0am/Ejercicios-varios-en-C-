using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Estructuras_condicionales_simples_y_compuestas_p1
{
//Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar un mensaje en pantalla indicando que debe abonar impuestos.
    internal class Program
    {
        static void Main(string[] args)
        {
            int sueldo;
            Console.WriteLine("Ingrese sueldo: ");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("Debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("No debe abonar impuestos");
            }

            Console.ReadKey();
        }
    }
}
