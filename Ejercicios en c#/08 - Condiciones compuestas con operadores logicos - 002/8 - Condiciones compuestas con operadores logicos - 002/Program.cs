using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condiciones_compuestas_con_operadores_logicos___002
{
    /*Se carga una fecha (día, mes y año) por teclado. Mostrar un mensaje si corresponde al primer trimestre del año (enero, febrero o marzo) 
     * Cargar por teclado el valor numérico del día, mes y año.
    Ejemplo: dia:10 mes:1 año:2019.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            string letra;

            Console.WriteLine("Ingrese el día: ");
            letra = Console.ReadLine();
            dia = int.Parse(letra);
            Console.WriteLine("Ingrese el mes: ");
            letra = Console.ReadLine();
            mes = int.Parse(letra);
            Console.WriteLine("Ingrese el año: ");
            letra = Console.ReadLine();
            año = int.Parse(letra);

            if (mes == 1 || mes == 2 || mes == 3)
            {
                Console.WriteLine("La fecha ingresada corresponde al 1er trimestre del año: ");
            }
            else
            {
                Console.WriteLine("La fecha ingresada NO corresponde al 1er trimestre del año: ");
            }
            Console.ReadKey();
        }
    }
}
