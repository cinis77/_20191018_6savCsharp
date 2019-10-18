using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191018_antraUzduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kiek klaseje yra mokiniu?");
            int mokiniuSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek lapu sudaro konspektas?");
            int konspektoLapuSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mokiniams reikes : {0} konspektu lapu",
                mokiniuSkaicius * konspektoLapuSkaicius);
        }
    }
}