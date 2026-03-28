using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DLJM_Números_impares_del_20_al_150__For_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 21; i <= 150; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
