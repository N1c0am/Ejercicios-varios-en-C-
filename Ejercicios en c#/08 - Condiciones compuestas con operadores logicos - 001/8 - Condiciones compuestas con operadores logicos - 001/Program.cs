using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condiciones_compuestas_con_operadores_logicos___001
{
    internal class Program
    {
        //Confeccionar un programa que lea por teclado tres números distintos y nos muestre el mayor.
        static void Main(string[] args)
        {
            int n1, n2, n3;
            string letra;

            Console.WriteLine("Ingrese el 1er número");
            letra = Console.ReadLine();
            n1 = int.Parse(letra);
            Console.WriteLine("Ingrese el 2do número");
            letra = Console.ReadLine();
            n2 = int.Parse(letra);
            Console.WriteLine("Ingrese el 3er número");
            letra = Console.ReadLine();
            n3 = int.Parse(letra);

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + " es el mayor");
            }
            
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine(n2 + " es el mayor");
                }
                
            else
                {
                    Console.WriteLine(n3 + " es el mayor");
                }
                    
            }
                
            Console.ReadKey();
        }
    }
}
