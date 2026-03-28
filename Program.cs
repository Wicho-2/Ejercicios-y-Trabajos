using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLJM_Tabla_de_Multiplicacion__While_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1;

            Console.Write("Ingresa un número (1-9): ");
            num = int.Parse(Console.ReadLine());

            while (i <= 10)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
                i++;
            }
        }
    }
}
