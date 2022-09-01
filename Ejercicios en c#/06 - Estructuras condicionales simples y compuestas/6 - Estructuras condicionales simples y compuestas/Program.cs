using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Estructuras_condicionales_simples_y_compuestas
{
    internal class Program
    {
        //Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar un mensaje en pantalla indicando que debe abonar impuestos.
        static void Main(string[] args)
        {
            int sueldo;
            string linea;

            Console.WriteLine("Ingrese el sueldo de la persona correspondiente: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);

            if (sueldo > 3000)
                Console.WriteLine("La persona debe abonar impuestos");
            else
                Console.WriteLine("La persona no debe abonar impuestos");
            Console.ReadKey();
        }
    }
}
