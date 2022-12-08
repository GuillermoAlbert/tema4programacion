using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double potencia(double n1, double n2)
            {
                return (Math.Pow(n1, n2));
            }

            Console.WriteLine("Ingresa el primer número: ");
            double num1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("Ingresa la potencia a la que quieres elevar el primer número: ");
            double num2 = double.Parse((Console.ReadLine()));
            double res = potencia(num1, num2);
            Console.WriteLine("El resultado es: " + res);
            Console.ReadLine();
        }
    }
}
