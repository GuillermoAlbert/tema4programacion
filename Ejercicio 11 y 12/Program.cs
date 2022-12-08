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
            bool diacorrecto = true;
            Console.WriteLine("Voy a solicitar una fecha. Para ello, introduce primero el día, luego el mes, y finalmente el año");
            Console.WriteLine("Te diré si esta fecha es correcta o no es válida");
            Console.WriteLine("Introduce un día");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un mes");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un año");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            Console.WriteLine("........................................");
            Console.WriteLine("........................................");
            bool res = bisiesto(año);
            if (res == true)
            {
                Console.WriteLine("El año es bisiesto");
                if (mes == 2)
                {
                    if (dia <= 28)
                        diacorrecto = true;
                    else
                        diacorrecto = false;
                }
            }
            else
            {
                if (mes == 2)
                {
                    if (dia <= 29)
                        diacorrecto = true;
                    else
                        diacorrecto = false;
                }
                Console.WriteLine("El año no es bisiesto");
                if (dia >= 1 && dia <= 31 && mes >= 1 && mes <= 12)
                {
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        if (dia <= 30)
                            diacorrecto = true;
                        else
                            diacorrecto = false;
                    }
                }
            }

            if (diacorrecto == true)
                Console.WriteLine("Fecha correcta");
            else
                Console.WriteLine("Fecha errónea");
            Console.ReadLine();
        }
    }
}
