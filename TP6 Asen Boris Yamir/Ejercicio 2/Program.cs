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
            int a, b, seguir=1;
            float res;
            char operacion;
            Console.Write("**** Calculadora ****");
            Console.Write("\n\nSUMA(S)\nRESTA(R)\nMULTIPLICACION(M)\nDIVISION(D)");
            
            while (seguir==1) {
                Console.Write("\n\nElija una operacion: ");
                operacion = char.Parse(Console.ReadLine());
                Console.Write("\nIngrese el primer numero: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("\nIngrese el segundo numero: ");
                b = Convert.ToInt32(Console.ReadLine());

                switch (operacion)
                {
                    case 'S':
                        Console.Write("\n\ta+b=");
                        res = a + b;
                        Console.Write(res);
                        break;
                    case 'R':
                        Console.Write("\n\ta-b=");
                        res = a - b;
                        Console.Write(res);
                        break;
                    case 'M':
                        Console.Write("\n\ta*b=");
                        res = a * b;
                        Console.Write(res);
                        break;
                    case 'D':
                        Console.Write("\n\ta/b=");
                        res = (float)(a / b);
                        Console.Write(res);
                        break;
                }
                Console.Write("\n\nDesea realizar otro calculo? (SI=1, NO=0): ");
                seguir = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
