using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Curso_C_Sharp___Practicando_con_un_ejemplo
{
    internal class Program
    {

        enum Color { amarillo, rojo, verde };

        public struct Calendario
        {
            int dia;
            int mes;
            int año;
            public Calendario(int dia, int mes, int año)
            {
                this.dia = dia;
                this.mes = mes;
                this.año = año;
            }

            public String SaberFecha()
            {
                String fecha;
                fecha = (dia + "/" + mes + "/" + año);
                return fecha;
            }
            

        }

        
       
        static void Main(string[] args)
        {
            /* 1) Defije dos números enteros y guardalos en dos variables.
             * Los sumamos, restamos, dividimos y hacemos la operación de resto
             * y asignamos su valor a otra variable decimal definida previamente.
             * Lo vamos mostrando por pantalla: */
            int num1, num2;
            num1 = 20;
            num2 = 3;

            decimal resultado;

            resultado = num1 + num2;
            Console.WriteLine(resultado);
            resultado = num1 - num2;
            Console.WriteLine(resultado);
            resultado = num1 / num2;
            Console.WriteLine(resultado);
            resultado = num1 % num2;
            Console.WriteLine(resultado);
            Console.ReadKey();


            /* 2) Define un enumerado y obtén el valor de color verde
             * Mostrar por pantalla */
            Color c = Color.verde;
            Console.WriteLine("El valor de "+c+" es "+(int)c);
            Console.ReadKey();

            /* 3) Define en una estructura de tipo calendario con un método que nos devuelva la fecha */
            Calendario cal = new Calendario(21, 1, 2017);
            Console.WriteLine(cal.SaberFecha());
            Console.ReadKey();

            //Fecha de Hoy
            DateTime fechaHoy = DateTime.Now;
            Console.WriteLine(fechaHoy.ToString());
            Console.ReadKey();

            /* 4) Utiliza los operadores && y || con dos cadenas de texto y mostrar por pantalla */
            string texto1, texto2;
            texto1 = "hola";
            texto2 = "HOLA";

            Console.WriteLine(texto1 == texto2 && texto1 == texto2);
            Console.WriteLine(texto1 == texto2 || texto1 == texto2);
            Console.WriteLine(texto1.Equals(texto2));
            Console.ReadKey();

            /* 5) Pedir 2 valores por pantalla, multiplicarlos y mostralos*/
            double n1, n2, multiplicacion;
            string texto;

            Console.WriteLine("Ingrese el 1er valor");
            texto = Console.ReadLine();
            n1 = double.Parse(texto);

            Console.WriteLine("Ingrese el 2do valor");
            n2 = Convert.ToDouble(Console.ReadLine());

            multiplicacion = n1 * n2;
            Console.WriteLine(n1 + "*" + n2 + "=" + multiplicacion.ToString());
            Console.ReadKey();

        }
    }
}
