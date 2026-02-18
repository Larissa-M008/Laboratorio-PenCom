using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LarissaMéndez_1142526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Larissa Méndez Bedoya_1142526");
            Console.WriteLine("Laboratorio 5 PC");
            Console.WriteLine("");
            Console.WriteLine("Desafío 1");
            Console.WriteLine("Ingrese un número");
            string num1 = Console.ReadLine();
            int num2 = int.Parse(num1);
            if (num2 == 0) {
                Console.WriteLine("Su numero es cero."); }
            else if (num2 < 0) {
            Console.WriteLine("Su número es negativo"); } 
            else {
                Console.WriteLine("Su número es positivo");
            }

            Console.WriteLine("");
            Console.WriteLine("Desafío 2");
            Console.WriteLine("Ingrese el número del año");
            string anno = Console.ReadLine();
            int anno1 = int.Parse(anno);
            if ((anno1%4==0 & anno1 % 100 != 0) || (anno1 % 400 == 0))
            {
                Console.WriteLine("El año "+anno+" es bisiesto");
            }
            else
            {
                Console.WriteLine("El año "+anno+" no es bisiesto");
            }

            Console.WriteLine("");
            Console.WriteLine("Desafío 3");
        }
    }
}
