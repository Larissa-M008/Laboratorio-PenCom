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
            bool RespuestaMulta;
            double ValorBoleto = 0;
           

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
            string anio = Console.ReadLine();
            int anio1 = int.Parse(anio);
            if ((anio1 % 4 == 0 && anio1 % 100 != 0) || (anio1 % 400 == 0))
            {
                Console.WriteLine("El año " + anio + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + anio + " no es bisiesto");
            }

            Console.WriteLine("");
            Console.WriteLine("Desafío 3");
            Console.WriteLine("Ingrese su salario: ");
            string salario = Console.ReadLine();
            double salario1 = double.Parse(salario);
            Console.WriteLine("Si tiene multa Sí=0/No=1");
            string multa1 = Console.ReadLine();
            int multa2 = int.Parse(multa1); 
            RespuestaMulta = (multa2 == 0); 
            if ((salario1 >= 500.01 && salario1 <= 1000.00)) {
                ValorBoleto = 10;
                if (RespuestaMulta) 
                {
                    ValorBoleto = ValorBoleto * 2;
                }
                Console.WriteLine("Debe pagar:" + ValorBoleto+" Si multa es "+RespuestaMulta);
            }
            else if ((salario1 >= 1000.01 && salario1 <= 3000.00))
            { ValorBoleto = 15;
                if (RespuestaMulta)
                {

                    ValorBoleto = ValorBoleto * 2;
                }
                Console.WriteLine("Debe pagar:" + ValorBoleto + " Si multa es " + RespuestaMulta);
            }
            else if (salario1 >= 3000.01 && salario1 <= 6000.00)
            {
                ValorBoleto = 50;
                if (RespuestaMulta)
                {

                    ValorBoleto = ValorBoleto * 2;
                }
                Console.WriteLine("Debe pagar:" + ValorBoleto + " Si multa es " + RespuestaMulta);
            }
            else if (salario1 >= 6000.01 && salario1 <= 9000.00)
            {
                ValorBoleto = 75;
                if (RespuestaMulta)
                {
                    ValorBoleto = ValorBoleto * 2;
                }
                Console.WriteLine("Debe pagar:" + ValorBoleto + " Si multa es " + RespuestaMulta);
            }
            else if (salario1 >= 9000.01 && salario1 <= 12000.00)
            {
                ValorBoleto= 100;
                if (RespuestaMulta)
                {
                    ValorBoleto = ValorBoleto * 2;
                }
                Console.WriteLine("Debe pagar:" + ValorBoleto + " Si multa es " + RespuestaMulta);
            }
            else
            {
                ValorBoleto = 150;
                if (RespuestaMulta)
                {
                    ValorBoleto = ValorBoleto * 2;
                }
                Console.WriteLine("Debe pagar:" + ValorBoleto + " Si multa es " + RespuestaMulta);
            }

            Console.WriteLine("");
            Console.WriteLine("Desafío 4");
            Console.WriteLine("Ingrese cuántas horas estuvo estacionado: ");
            string horas1 = Console.ReadLine();
            int horas = int.Parse(horas1);
            int horasTotales = horas * 10;
            Console.WriteLine("Su total es de: "+horasTotales);
            Console.WriteLine("Ingrese el total a pagar: ");
            string pago1 = Console.ReadLine();
            int pago = int.Parse(pago1);
            int vuelto = pago - horasTotales;
            if (pago < horasTotales)
            {
                Console.WriteLine("Error, los fondos no son suficientes");
            }
            else if (pago == horasTotales)
            {
                Console.WriteLine("No se requiere cambio ¡Feliz día!");
            }
            else
            {
                Console.WriteLine("Su vuelto es de: "+vuelto);
                int billetes = vuelto / 100;
                Console.WriteLine("Billetes de Q100: " + billetes);
                vuelto = vuelto - (billetes*100);
                billetes = vuelto/ 50;
                Console.WriteLine("Billetes de Q50: " + billetes);
                vuelto = vuelto - (billetes*50);
                billetes = vuelto / 20;
                Console.WriteLine("Billetes de Q20: " + billetes);
                vuelto = vuelto - (billetes*20);
                billetes = vuelto / 10;
                Console.WriteLine("Billetes de Q10: " + billetes);
                vuelto = vuelto - (billetes*10);
                billetes = vuelto / 5;
                Console.WriteLine("Billetes de Q5: " + billetes);
                vuelto = vuelto - (billetes*5);
                billetes = vuelto / 1;
                Console.WriteLine("Billetes de Q1: " + billetes);
            }
        }
    }
}
