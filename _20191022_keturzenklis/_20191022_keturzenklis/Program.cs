using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191022_keturzenklis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite keturzenkli skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int naujasSkaicius = 0;
            int tukst = sk / 1000;
            int simtai = (sk / 100) % 10;
            int desimtys = (sk / 10) % 10;
            int vienetai = sk % 10;
            int skaicius = vienetai * 1000 + desimtys * 100 + simtai * 10 + tukst;
            for (int i = 4 - 1; i >= 0; i--)
            {
                naujasSkaicius += (sk % 10) * (int)Math.Pow(10, i);
                sk /= 10;
            }
            Console.WriteLine(naujasSkaicius);
            Console.WriteLine(skaicius);
        }
    }
}