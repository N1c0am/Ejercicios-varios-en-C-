using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Cadenas_de_caracteres_p1_e2
{
    //Solicitar el ingreso de dos apellidos. Mostrar un mensaje si son iguales o distintos.
    internal class Program
    {
        static void Main(string[] args)
        {
            string apellido1, apellido2;

            Console.Write("Ingrese apellido: ");
            apellido1 = Console.ReadLine();
            Console.Write("Ingrese otro apellido: ");
            apellido2 = Console.ReadLine();

            if (apellido1 != apellido2)
            {
                Console.WriteLine("Los apellidos no son iguales");
            }
            else
            {
                Console.WriteLine("Los apellidos son iguales");
            }
            Console.ReadKey();
        }
    }
}
