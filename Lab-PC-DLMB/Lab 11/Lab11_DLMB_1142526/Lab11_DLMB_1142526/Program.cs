using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Lab11_DLMB_1142526 {
     class Pensamiento {
          static void Main(string[] args)
        {
            Console.WriteLine("===================================== ");  
            Console.WriteLine("Laboratorio 11 de Larissa Méndez, 1142526");
            int opcion=0;
            int respuesta=0;
            do{
                Console.WriteLine("===================================== ");    
                Console.WriteLine("Ingrese qué ejercicio quiere realizar: ");
                Console.WriteLine("1. Ejercicio Palíndromos ");
                Console.WriteLine("2. Ejercicio Colores ");
                Console.WriteLine("3. Ejercicio Calificaciones ");
                Console.WriteLine("4. Ejercicio Registro ");
                Console.WriteLine("5. SALIR ");
                respuesta=int.Parse(Console.ReadLine());
            
                switch (respuesta)
                {
                    case 1:
                        palabra:
                        Console.WriteLine("Ingrese su palabra: ");
                        string pal_or = Console.ReadLine();
                        char [] palabra1 = pal_or.ToCharArray();
                        Console.WriteLine(Palindromo(palabra1));
                        Console.WriteLine("¿Desea ingresar otra palabra?");
                        Console.WriteLine("Si=1 / No=0");
                        opcion = int.Parse(Console.ReadLine());
                        if (opcion ==1){goto palabra;}
                        if (opcion ==0){;Console.WriteLine();}
                    break;
                    case 2:
                        colores:
                        Console.WriteLine("Bienvenido a la Lección de hoy");
                        Console.WriteLine("Los colores a aprender hoy son...");
                        Console.WriteLine("rojo, azul, amarillo, blanco y verde");
                        Console.WriteLine("¿De cuál quieres aprender?");
                        string color = Console.ReadLine();
                        Console.WriteLine(ColoresIdiomas(color));

                        Console.WriteLine("¿Desea ingresar otro color?");
                        Console.WriteLine("Si=1 / No=0");
                        opcion = int.Parse(Console.ReadLine());
                        if (opcion ==1){goto colores;}
                        if (opcion ==0){;Console.WriteLine();}
                    break;
                    case 3:
                        estudiante:
                        double suma = 0;
                        double prom = 0;
                        Random rnd = new Random();
                        Console.WriteLine("Las notas del estudiante fueron: ");
                        int [] notas = new int[10];
                        for (int i=0; i < notas.Length;i++)
                        {
                            notas[i]=rnd.Next(0,100);
                            Console.WriteLine(notas[i]);
                            suma = suma + notas [i];
                        }
                        prom = suma / 10;
                        Console.WriteLine("El promedio es: "+prom);
                        Console.WriteLine(Estadistica(notas));
                        Console.WriteLine();
                        Console.WriteLine("¿Desea salir ver las notas de otro estudiante?");
                        Console.WriteLine("Si=1 / No=0");
                        opcion = int.Parse(Console.ReadLine());
                        if (opcion ==1){goto estudiante;}
                        if (opcion ==0){;Console.WriteLine();}
                    break;
                    case 4:
                        string [] nombres = {"Ana", "Mario", "Saul", "Karla", "Maria", "Jose"};
                        double [] salario_x_hora = [100, 125.50, 98.65, 125, 132.50, 102.50];
                        double [] horas_tra = new double [6];
                        Console.WriteLine("Bienvenido a la planilla.");  
                        for (int a=0; a < nombres.Length; a++)
                        {
                            
                            Console.WriteLine("Ingrese las horas trabajadas por: "+nombres[a]);
                            double horas = double.Parse(Console.ReadLine());
                            horas_tra[a]= horas;
                        }
                        Console.WriteLine(Pagos(nombres, salario_x_hora, horas_tra));
                    break;
                    case 5:
                        Console.WriteLine("Laboratorio 11 de Larissa Méndez se está cerrando...");
                    break;
                }
            } while (respuesta !=5);
        }
        static bool Palindromo (char[] palabra1)
        {
            char[] palindrome = new char[palabra1.Length];
            int incremento = 0;
            for (int x =palabra1.Length -1;x>=0;x--)
            {
                palindrome[incremento] = palabra1[x];
                incremento++;
            }
            string cadenaInv = new string(palindrome);
            string cadenaOri = new string(palabra1);
            Console.WriteLine(cadenaInv);
            if (cadenaInv == cadenaOri)
            {
                 Console.WriteLine("True");
                return true; 
            } 
            else{
                Console.WriteLine("False");
                return false;
            }
        }
        static string ColoresIdiomas(string color)
        {
            string [] espanol= {"rojo", "azul", "amarillo", "blanco", "verde"};
            string [] ingles= {"red", "blue", "yellow", "white", "green"};
            string [] italiano= {"rosso", "blu", "giallo", "bianco", "verde"};
            for (int i=0; i <espanol.Length; i++)
            {
                if (espanol[i]==color)
                {
                    Console.WriteLine("Su traducción al inglés es: "+ingles[i]);
                    Console.WriteLine("Su traducción al italiano es: "+italiano[i]);
                    return "";
                } 
            }
            Console.WriteLine("Ese color no existe en la lista");
            return "";
        }
        static int Estadistica(int[] notas)
        {
            for (int i=0; i < notas.Length; i++)
            {
                for(int j = i + 1; j < notas.Length; j++)
                {
                   if (notas[j] < notas[i])
                    {
                        int aux = notas[i];
                        notas[i]= notas[j];
                        notas[j] = aux;
                    } 
                } 
            }
           Console.WriteLine("El número menor es: "+notas[0]);
           Console.WriteLine("El número mayor es: "+notas[9]);
            return 0;
        }
        static string Pagos(string[] nombres, double[] salario_x_hora, double[]horas_tra)
        {
            for (int n=0; n<nombres.Length; n++)
            {
                if (horas_tra[n] > 40)
                {
                    double salario= salario_x_hora[n] * horas_tra[n]*1.5;
                    Console.WriteLine("El salario de esta semana de "+nombres[n]+" es de: Q"+salario);
                    
                }
                else
                {
                    double salario= salario_x_hora[n] * horas_tra[n];
                    Console.WriteLine("El salario de esta semana de "+nombres[n]+" es de: Q"+salario);
                }
            }
            return "";
        }    
     }
}
