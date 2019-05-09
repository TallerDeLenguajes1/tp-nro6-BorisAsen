using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            int digito;
            Console.Write("Ingrese un numero a invertir: ");
            nro = int.Parse(Console.ReadLine());
            Console.Write("\nEl numero ivertido queda: ");

            while (nro > 0)
            {
                digito = nro % 10;
                Console.Write(digito);
                nro = nro / 10;
            }

            Console.ReadKey();
        }
    }
}
