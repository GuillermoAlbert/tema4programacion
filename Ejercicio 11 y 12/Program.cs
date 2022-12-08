using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11_y_12
{
    internal class Program
    {
        public static bool bisiesto(int año)
        {
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un año y te diré si es bisiesto o no");
            int año = int.Parse(Console.ReadLine());
            bool res = bisiesto(año);
            if (res == true)
                Console.WriteLine("El año es bisiesto");
            else
                Console.WriteLine("El año no es bisiesto");
            Console.ReadLine();
        }
    }
}
