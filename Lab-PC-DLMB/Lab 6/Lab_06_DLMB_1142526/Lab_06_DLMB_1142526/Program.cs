using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_DLMB_1142526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 6 Larissa Méndez");
            Console.WriteLine("Pensamiento Computacional");
            Console.WriteLine();
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese el número de la conversión a realizar:");
            Console.WriteLine("1. Celsius -> Fahrenheit");
            Console.WriteLine("2. Fahrenheit -> Celsius");
            Console.WriteLine("3. Celsius -> Kelvin");
            int conver = int.Parse(Console.ReadLine());
            switch (conver)
            {
                case 1:
                    Console.WriteLine("Celsius -> Fahrenheit");
                    Console.WriteLine("Ingrese sus grados en Celsius:");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahren = (1.8 * celsius) + 32;
                    Console.WriteLine("Los grados en Fahrenheit son: " + fahren);
                    break;

                case 2:
                    Console.WriteLine("Fahrenheit -> Celsius");
                    Console.WriteLine("Ingrese sus grados en Fahrenheit:");
                    fahren = double.Parse(Console.ReadLine());
                    celsius = (fahren - 32) / 1.8;
                    Console.WriteLine("Los grados en Fahrenheit son: " + celsius);
                    break;
                case 3:
                    Console.WriteLine("Celsius -> Kelvin");
                    Console.WriteLine("Ingrese sus grados en Celsius:");
                    celsius = double.Parse(Console.ReadLine());
                    double Kelvin = celsius - 273.15;
                    Console.WriteLine("Los grados en Fahrenheit son: " + Kelvin);
                    break;
                default:
                    Console.WriteLine("Esa opción no es válida.");
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese qué tipo de cliente es:");
            Console.WriteLine("1. Cliente Regular");
            Console.WriteLine("2. Cliente VIP");
            int cliente = int.Parse(Console.ReadLine());
            double total = 0;
            switch (cliente)
            {
                case 1:
                    Console.WriteLine("¿Qué cantidad de productos comprará?");
                    int cantidad = int.Parse(Console.ReadLine());
                    if (cantidad >= 100)
                    { 
                        Console.WriteLine("Se le aplicará un descuento del 15%");
                        Console.WriteLine("Ingrese el precio del producto que desea: ");
                        double precio = double.Parse(Console.ReadLine());
                        total = (precio * cantidad) * 0.15;
                        Console.WriteLine("Su total es de " + total);
                    }
                    else
                    {
                        Console.WriteLine("Se le aplicará un descuento del 5%");
                        Console.WriteLine("Ingrese el precio del producto que desea: ");
                        double precio1 = double.Parse(Console.ReadLine());
                        total = (precio1 * cantidad) * 0.05;
                        Console.WriteLine("Su total es de " + total);
                    }
                    break;
                case 2:
                    Console.WriteLine("¿Qué cantidad de productos comprará?");
                    int cantidad1 = int.Parse(Console.ReadLine());
                    if (cantidad1 >= 100)
                    {
                        Console.WriteLine("Se le aplicará un descuento del 15%");
                        Console.WriteLine("Ingrese el precio del producto que desea: ");
                        double precio = double.Parse(Console.ReadLine());
                        total = (precio * cantidad1) * 0.15;
                        Console.WriteLine("Su total es de " + total);
                    }
                    else
                    {
                        Console.WriteLine("Se le aplicará un descuento del 10%");
                        Console.WriteLine("Ingrese el precio del producto que desea: ");
                        double precio1 = double.Parse(Console.ReadLine());
                        total = (precio1 * cantidad1) * 0.1;
                        Console.WriteLine("Su total es de " + total);
                    }
                    break;
                default:
                    Console.WriteLine("¿Qué cantidad de productos comprará?");
                    int cantidad3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el precio del producto que desea: ");
                    double precio2 = double.Parse(Console.ReadLine());
                    if (cantidad3 >= 100)
                    { 
                        Console.WriteLine("Se le aplicará un descuento del 15%");
                        total = (precio2 * cantidad3) * 0.15;
                        Console.WriteLine("Su total es de " + total);
                    }
                    else
                    { 
                        Console.WriteLine("No tiene ningún descuento");
                        total = precio2 * cantidad3;
                        Console.WriteLine("Su total es de " + total);
                    }
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Ejercicio 3");
            int pago = 0;
            Console.WriteLine("Ingrese las horas que estuvo estacionado:");
            int horas = int.Parse(Console.ReadLine());
            if (horas < 2)
            {
                pago = horas * 5;
                Console.WriteLine("Su total a pagar es de $" + pago);
            }
            else if (horas >= 2 && horas <= 5)
            {
                pago = horas * 4;
                Console.WriteLine("Su total a pagar es de $" + pago);
            }
            else
            {
                pago = horas * 3;
                Console.WriteLine("Su total a pagar es de $" + pago);
            }
            Console.WriteLine();
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Ingrese su puntuación de rendimiento:");
            double puntos = double.Parse(Console.ReadLine());
            double bono = puntos * 2400;
            switch (puntos)
            {
                case 0.0:
                    Console.WriteLine("Ese puntaje es: Inaceptable");
                    Console.WriteLine("Su puntuación es de " + puntos + " y recibirá " + bono + "EUR");
                    break;
                case 0.4:
                    Console.WriteLine("Ese puntaje es: Aceptable");
                    Console.WriteLine("Su puntuación es de " + puntos + " y recibirá " + bono + "EUR");
                    break;
                default:
                    if (puntos >= 0.6)
                    { 
                        Console.WriteLine("Ese puntaje es: Meritorio");
                        Console.WriteLine("Su puntuación es de " + puntos + " y recibirá " + bono + "EUR");
                    }
                    else
                    {
                        Console.WriteLine("Ese puntaje no está dentro de los parámetros.");
                    }
                   
                    break;
            }
        }
    }
}
