using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLJM_Números_impares_del_20_al_150__While_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 21;
            while (i <= 150)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
    }
}
