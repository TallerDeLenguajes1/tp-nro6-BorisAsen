using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_Asen_Boris_Yamir
{
    class Program
    {
        static void Main(string[] args)
        {
            int vble;
            vble = int.Parse(Console.ReadLine());
            Console.Write(vble);

            if (vble < 50)
            {
                Console.Write(" es menor de 50");
            }
            else
            {
                Console.Write(" es mayor de 50");
            }

            Console.ReadKey();
        }
    }
}
