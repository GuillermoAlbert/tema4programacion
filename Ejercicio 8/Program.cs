using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validacion(double n1, double n2, double n3)
            {
                bool res;
                if (n1 <= 10 && n1 >=0 && n2 <= 10 && n2 >= 0 && n3 <= 10 && n3 >= 0)
                    res = true;
                else
                    res = false;
                return res;
            }

            double media(double n1, double n2, double n3)
            {
                double valormedio = (n1 + n2 + n3) / 3;
                return valormedio;
            }
            
            Console.WriteLine("Ingrese la nota del primer examen:");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo examen:");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del tercer examen:");
            double nota3 = double.Parse(Console.ReadLine());

            bool valido = validacion(nota1, nota2, nota3);
            if (valido == false)
                Console.WriteLine("Formato de notas erróneo");
            else
            {
                Console.WriteLine("Notas introducidas correctamente");
                Console.WriteLine("Calculando media");
                double mediaAlumno = media(nota1, nota2, nota3);
                Console.WriteLine("La nota media del alumno es: " + mediaAlumno);
                Console.ReadLine();
            }
        }
    }
}
