using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Codificación_del_diagrama_de_flujo_en_C_gato
{
    //El programa completo para el calculo del sueldo de un operario conociendo la cantidad de horas trabajadas y el costo por hora es:
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo, hrs_Trabajadas;
            int costo_Horas;
            string linea;

            Console.WriteLine("Ingrese la cantidad de horas trabajadas");
            linea = Console.ReadLine();
            hrs_Trabajadas = double.Parse(linea);
            Console.WriteLine("Ingrese el costo por hora");
            linea = Console.ReadLine();
            costo_Horas = int.Parse(linea);

            sueldo = hrs_Trabajadas * costo_Horas;
            Console.WriteLine("El sueldo del trabajador es de: $" + sueldo);
            Console.ReadKey();
        }
    }
}
