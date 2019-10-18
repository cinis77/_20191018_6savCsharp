using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191018_ketvirtaUzduotisApskritimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite z");
            int z = Convert.ToInt32(Console.ReadLine());

            int xc = 5;
            int yc = 2;
            int zc = 1;

            double R = Math.Sqrt(Math.Pow(x - xc, 2) + Math.Pow(y - yc, 2)
                + Math.Pow(z - zc, 2));
            Console.WriteLine("Gautas apskritimo spindulys yra " + R.ToString("F2"));
        }
    }
}