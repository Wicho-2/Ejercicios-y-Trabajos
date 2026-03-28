using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLJM_Promedio_de_alumnos__While_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            int suma = 0;

            Console.Write("Ingresa la cantidad de alumnos: ");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                Console.Write("Ingresa la calificación del alumno " + i + ": ");
                int cal = int.Parse(Console.ReadLine());

                suma += cal;
                i++;
            }

            double promedio = (double)suma / n;

            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
