using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = "11000";
            double num = 24;
            Numero n = new Numero();

            Console.WriteLine(n.BinarioDecimal(bin));
            Console.WriteLine(n.DecimalBinario(num));

            Console.ReadKey();
        }
    }
}
