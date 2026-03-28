using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLJM_Factorial__For_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial: " + factorial);
        }
    }
}
