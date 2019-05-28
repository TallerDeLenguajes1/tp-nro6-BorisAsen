using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("CALCULADORA BASICA\n");
            Console.Write("\nOperaciones disponibles:");
            Console.Write("\n\tSUMA (S)\n\tRESTA (R)\n\tMULTIPLICACION (M)\n\tDIVISION (D)\n\n");


            int seguir=1;
            while (seguir==1)
            {
                Console.Write("Elija una operacion: ");
                string operacion = Console.ReadLine();
                Console.Write("Ingrese el primer operando: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo operando: ");
                double b = Convert.ToDouble(Console.ReadLine());

                switch (operacion)
                {
                    case ("S"):
                        Console.Write("\nSUMA = ");
                        Console.Write(a + b);
                        break;
                    case ("R"):
                        Console.Write("\nRESTA = ");
                        Console.Write(a - b);
                        break;
                    case ("M"):
                        Console.Write("\nMULTIPLICACION = ");
                        Console.Write(a * b);
                        break;
                    case ("D"):
                        Console.Write("\nDIVISION = ");
                        Console.Write(a / b);
                        break;
                    default:
                        break;
                }

                Console.Write("\n\nDesea realizar otra operacion? SI(1) NO(0): ");
                seguir = Convert.ToInt16(Console.ReadLine());

                Console.Clear();

            }

            Console.ReadKey();
        }
    }
}
