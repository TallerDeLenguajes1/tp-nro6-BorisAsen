using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesConStrings();

            Console.Write("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            int seguir = 1;
            while (seguir==1)
            {
                Console.Write("Ingrese una operacion basica como cadena de caracteres: ");
                string op = Console.ReadLine();
                Console.WriteLine("\nEl resultado de la operacion es: " + RealizarOperacion(op));

                Console.Write("\n\nIngrese 1 si desea realizar otra operacion, de lo contrario el 0: ");
                seguir =Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }

            Console.ReadKey();
        }

        public static double RealizarOperacion(string op)
        {
            string operador = "o";
            if (op.Contains("+"))
            {
                operador = op.Substring(op.IndexOf("+"), 1);
            }
            else
            {
                if (op.Contains("-"))
                {
                    operador = op.Substring(op.IndexOf("-"), 1);
                }
                else
                {
                    if (op.Contains("*"))
                    {
                        operador = op.Substring(op.IndexOf("*"), 1);
                    }
                    else
                    {
                        if (op.Contains("/"))
                        {
                            operador = op.Substring(op.IndexOf("/"), 1);
                        }
                    }
                }
            }

            string o1 = op.Substring(0, op.IndexOf(operador));
            double operando1 = Convert.ToInt32(o1);
            Console.WriteLine("\nEl primer operando es: " + operando1);
            Console.WriteLine("El operador es: " + operador);
            string o2 = op.Substring(op.IndexOf(operador) + 1);
            double operando2 = Convert.ToInt32(o2);
            Console.WriteLine("El segundo operando es: " + operando2);

            double res = 0;
            switch (operador)
            {
                case "+":
                    res = operando1 + operando2;
                    break;
                case "-":
                    res = operando1 - operando2;
                    break;
                case "*":
                    res = operando1 * operando2;
                    break;
                case "/":
                    res = operando1 / operando2;
                    break;
                default:
                    break;
            }

            return res;
        }

        public static void OperacionesConStrings()
        {
            Console.Write("Ingrese una cadena de caracteres: ");
            string cad = Console.ReadLine();


            Console.WriteLine("\nLa cadena ingresada es: " + cad);
            Console.WriteLine("\nLa longitud de la cadena es: " + cad.Length);
            Console.WriteLine("\nSubcadena formada por los 4 primeros caracteres: " + cad.Substring(0, 4));

            //Suma entre A y B
            int a = 2;
            int b = 3;
            string suma = Convert.ToString(a + b);
            string A = Convert.ToString(a);
            string B = Convert.ToString(b);
            string operacion = "\nLa suma entre A y B es SUM";
            string salida = operacion.Replace("A", A).Replace("B", B).Replace("SUM", suma);
            Console.WriteLine(salida);

            Console.Write("\nCadena mostrada con foreach: ");
            foreach (char c in cad)
            {
                Console.Write(c);
            }

            Console.Write("\n\nIngrese una cadena para verificar si forma parte de la cadena original: ");
            string aux_cad = Console.ReadLine();
            Console.WriteLine("\nExistencia de la nueva cadena en la cadena original: " + cad.Contains(aux_cad));

            string concat = String.Concat(cad, aux_cad);
            Console.WriteLine("\nResultado ambas cadenas concatenadas: " + concat);

            string UpCad = concat.ToUpper();
            Console.WriteLine("\nCadena a mayusculas: " + UpCad);

            string LowCad = UpCad.ToLower();
            Console.WriteLine("\nCadena a minusculas: " + LowCad);

            Console.Write("\nIngrese una cadena y se comparara si es igual a la cadena original: ");
            string toCompare = Console.ReadLine();
            Console.WriteLine("\nIgualdad de las dos cadenas: " + String.Equals(cad, toCompare));
        }

    }

}
