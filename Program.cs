using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLJM_Promedio_de_alumnos__For_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                int cal = int.Parse(Console.ReadLine());
                suma += cal;
            }

            Console.WriteLine("Promedio: " + (suma / n));
        }
    }
}
