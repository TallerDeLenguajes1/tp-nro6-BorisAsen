using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA MEJORADA");
            Console.Write("\nIngrese un numero: ");
            double num = Convert.ToDouble( Console.ReadLine() );

            Console.Clear();

            Console.WriteLine("NUMERO: "+num);
            Console.WriteLine("\n   Valor absoluto: " + Math.Abs(num));
            Console.WriteLine("   Cuadrado: " + Math.Round( Math.Pow(num, 2),2) );
            Console.WriteLine("   Raiz cuadrada: " + Math.Round( Math.Sqrt(num),2 ) );
            Console.WriteLine("   Seno: " + Math.Round( Math.Sin(num),2 ) );
            Console.WriteLine("   Coseno: " + Math.Round( Math.Cos(num),2 ) );
            Console.WriteLine("   Parte entera: " + Math.Round( Math.Truncate(num),2 ) );

            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Ingrese dos numeros para saber cual es el minimo y el maximo");
            Console.Write("\nNumero 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nMayor: " + Math.Max(n1,n2));
            Console.WriteLine("Menor: " + Math.Min(n1, n2));


            Console.ReadKey();
        }
    }
}
