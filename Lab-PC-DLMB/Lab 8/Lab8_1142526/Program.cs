using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Laboratorio {
   class Pensamiento {
      static void Main(string[] args) {
          Console.WriteLine("Darlene Larissa Méndez Bedoya");
          Console.WriteLine("1142526. Pensamieto Computacional");
          Console.WriteLine("Ejercicio 1");
          int contador = 1;
          double suma = 0;
          int a = 0;
          int b =0;
          for (contador = 1; contador <=20; contador++)
          {
             Console.WriteLine("Ingrese un número: ");
             int num = int.Parse(Console.ReadLine());
             if (num > a)
             {
                a=num;
             }
             else if (num < b)
             {
                b=num;
             } 
             suma = suma + num;
            }
          Console.WriteLine("El número mayor es: "+a);
          Console.WriteLine("El número menor es: "+b);
          Console.WriteLine("el promedio es: " +(suma/20));
          Console.WriteLine("");

          Console.WriteLine("Ejercicio 2");
          int numero = 1;
          while (numero <=100)
          {
              if (numero % 2==0 && numero % 7 == 0)
             {
                Console.Write(numero+" ParSiete, ");
             }
              else if (numero % 2 == 0)
             {
                Console.Write(numero+" Par, ");
             }
              else if (numero % 7 == 0)
             {
                 Console.Write(numero+" Siete, ");
             }
              else
             {
                 Console.WriteLine(numero+", ");
             }
              numero++;
          } 
          Console.WriteLine("");

          Console.WriteLine("Ejercicio 3");
          double descuento;
          double total_Pagar;
          double totalVen = 0;
          int clientesDes = 0;
          for (int i = 1; i <= 10; i++)
          {
             Console.WriteLine("Usted es el Cliente No."+i+", ingrese su monto a pagar:");
             double monto = double.Parse(Console.ReadLine());
             if (monto > 700)
             {
                descuento = monto * 0.12;
                clientesDes++;
             }
             else if (monto > 300)
             {
                descuento = monto * 0.05;
                clientesDes++;
             }
             else
             {
                descuento=0; 
             }
             total_Pagar = monto - descuento;
             totalVen = totalVen + total_Pagar;

             Console.WriteLine("Total pagado por el cliente " + i + ": " + total_Pagar);
           }
          Console.WriteLine("Clientes que recibieron descuento: " + clientesDes);
          Console.WriteLine("Total de ventas del día: " + totalVen);
          Console.WriteLine("");

          Console.WriteLine("Ejercicio 4");
          int w=0;
          int mul3=1;
          int mul5=1;
          Console.WriteLine("Ingrese un número:");
          int numej4 = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese lo que quiere hacer con el número:");
          Console.WriteLine("1. Mostrar los números desde el número ingresado hasta 1");
          Console.WriteLine("2. Mostrar los múltiplos de 3 hasta el número ingresado");
          Console.WriteLine("3. Mostrar los múltiplos de 5 hasta el número ingresado");
          int opcion = int.Parse(Console.ReadLine());
          switch (opcion)
          {
            case 1:
            for (w = numej4; w>=1; w--)
               {
                  Console.WriteLine(w);
               }
            break;
            case 2:
            do
               {
                  if (mul3 % 3 == 0)
                  {
                     Console.WriteLine(mul3);
                  }
                  mul3++;
               }while (mul3<=numej4);
            break;
            case 3:
            do
               {
                  if (mul5 % 5 == 0)
                  {
                     Console.WriteLine(mul5);
                  }
                  mul5++;
               }while (mul5<=numej4);
            break;
            default:
             Console.WriteLine("No existe esa opción.");
            break;
          }
          Console.WriteLine("");

          Console.WriteLine("Ejercicio 5");
          int filas;
          Console.Write("Ingrese el número de filas: ");
          filas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= filas; i++)
          {
             for (int j = 1; j <= i; j++)
             {
                Console.Write("*");
             }

             Console.WriteLine();
           }
           
      }
   }
}