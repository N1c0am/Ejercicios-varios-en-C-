using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Condiciones_compuestas_con_operadores_lógicos_p1_2
{
/*Se carga una fecha (día, mes y año) por teclado. Mostrar un mensaje si corresponde al primer trimestre del año 
 * (enero, febrero o marzo) Cargar por teclado el valor numérico del día, mes y año.
Ejemplo: dia:10 mes:1 año:2019.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            Console.WriteLine("Ingrese día: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese año: ");
            año = Convert.ToInt32(Console.ReadLine());

            if ((mes == 1) || (mes == 2) || (mes == 3))
            {
                Console.WriteLine("Corresponde al primer trimestre del año");
            }
            else
            {
                Console.WriteLine("NO Corresponde al primer trimestre del año");
            }
            Console.ReadKey();
        }
    }
}
