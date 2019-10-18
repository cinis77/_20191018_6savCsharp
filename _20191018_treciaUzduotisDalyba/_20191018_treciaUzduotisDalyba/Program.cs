using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191018_treciaUzduotisDalyba
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaicius");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaicius");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            double dalyba = (double)sk / sk1;
            Console.WriteLine("Dalybos atsakymas yra {0:0.000}", dalyba);
            Console.WriteLine("Dalybos atsakymas yra " + dalyba.ToString("F3"));
        }
    }
}