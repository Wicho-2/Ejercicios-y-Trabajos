using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLJM_Numero_del_1_al_10_y_del_10_al_1__While_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
}
