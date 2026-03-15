using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_LM_1142526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Darlene Larissa Méndez Bedoya";
            int carnet = 1142526;
            int indice = 1;
            Console.WriteLine("Nombre: "+nombre+" Carnet: "+carnet.ToString()); 
            while (indice <= 20)
            {
                if (indice % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(indice);
                indice = indice + 1;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese un número positivo");
            int num = int.Parse(Console.ReadLine());
            int x = 1;
            Console.WriteLine("Sus divisores son:  ");
            do {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
                x = x + 1;
            } while (x<=num);

            Console.WriteLine();
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Ingrese la posición del número de la secuencia de Fibonacci: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int c = 1;
            int b = 0;
            for (int i = 0; i < num2; i++)
            {
                Console.WriteLine(b +" ");
                int resultado = b;
                b = c;
                c = resultado + c;
            }
            Console.WriteLine();
            Console.WriteLine("Ejercicio 4");
            for (int y = 1; y<=12 ; y++)
            {
                Console.WriteLine("Tabla del " + y);
                for (int j = 1; j <=10 ; j++)
                {
                    Console.WriteLine(y + " * " + j + " = " + (y * j));
                }
                Console.WriteLine("");
            }
        }
    }
}
