using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dig;
            Console.Write("Ingrese un numero entero: ");
            num = Convert.ToInt16(Console.ReadLine());

            Console.Write("\nEl numero invertido queda: ");
            while (num>0)
            {
                Console.Write(num % 10);
                num = num / 10;
            }

            Console.ReadKey();

        }
    }
}
