using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Cadenas_de_caracteres_p1_e1
{
    //Solicitar el ingreso del nombre y edad de dos personas. Mostrar el nombre de la persona con mayor edad.
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2;
            int edad1, edad2;

            Console.Write("Ingrese nombre: ");
            nombre1 = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro nombre: ");
            nombre2 = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad2 = Convert.ToInt32(Console.ReadLine());

            if (edad1 > edad2)
            {
                Console.WriteLine(nombre1);
            }
            else
            {
                Console.WriteLine(nombre2);

            }
            Console.ReadLine();
        }
    }
}
