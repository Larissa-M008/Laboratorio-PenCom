using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_DLMB_1142526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Larissa Méndez Bedoya, Carné 1142526
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("");
            string nombre = "Radissa2021";
            int niv = 34;
            float vida = 12.8f;
            bool jefe = false;

            Console.WriteLine("Su personaje se llama " + nombre + " es de nivel " + niv + " ,tiene " + vida + " puntos de vida" + " donde jefe final " + jefe);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Ejercicio 2");
            int NumeroEntero = 1500;
            long NumeroLargo = NumeroEntero;
            double NumDeci = NumeroLargo;
            Console.WriteLine("Su número es " + NumDeci);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Ejercicio 3");
            double PrecioExacto = 45.89;
            int PrecioRedondeado = (int)PrecioExacto;
            Console.WriteLine("El precio redondeado es: " + PrecioRedondeado);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Escriba un número");
            string EntradaUsuario = Console.ReadLine();
            int sum = int.Parse(EntradaUsuario) + 5;
            Console.WriteLine("Su número cambiado es " + sum);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Ejercicio 5");
            string valorBooleano = "true";
            Convert.ToBoolean(valorBooleano);
            string valorDecimal = "25.5";
            Convert.ToDouble(valorDecimal);
            Console.WriteLine("Su resultado es " + valorBooleano + " y " + valorDecimal);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Ejercicio 6");
            double pi = 3.14159265;
            string pi2 = pi.ToString("F2");
            Console.WriteLine("El valor de pi es " + pi2);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Ejercicio 7");
            Console.WriteLine("Ingrese el precio del producto:");
            string Precio = Console.ReadLine();
            Double IVA1 = (Double.Parse(Precio) * 0.21) + Double.Parse(Precio);
            Console.WriteLine("El valor del producto con IVA es "+IVA1);
            Console.WriteLine("Presione cualquier tecla para Terminar el proceso...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
