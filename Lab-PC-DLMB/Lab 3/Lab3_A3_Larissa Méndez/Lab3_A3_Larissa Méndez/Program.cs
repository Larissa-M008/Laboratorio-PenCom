using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_A3_Larissa_Méndez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3, Pensamiento Computacional, Larissa Méndez");
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de su curso");
            string curso = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("eres estudiante del curso de " + curso);
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}

