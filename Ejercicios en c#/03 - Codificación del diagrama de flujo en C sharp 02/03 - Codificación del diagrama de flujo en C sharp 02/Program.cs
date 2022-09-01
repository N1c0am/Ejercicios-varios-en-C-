using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Codificación_del_diagrama_de_flujo_en_C_sharp_02
{
//El programa completo para el calculo del sueldo de un operario conociendo la cantidad de horas trabajadas y el costo por hora es:
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, costo;
            Console.WriteLine("Ingrese horas trabajadas: ");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese costo por hora: ");
            costo = Convert.ToInt32(Console.ReadLine());

            int sueldo = horas * costo;
            Console.WriteLine("El sueldo del operario es: $" + sueldo);
            Console.ReadKey();
        }
    }
}
