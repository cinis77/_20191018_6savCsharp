using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191022_WhilePirmaUZduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            while (skaicius > 0)
            {
                if (skaicius % 2 == 0)
                {
                    suma += skaicius;
                }
                Console.WriteLine(--skaicius);
            }
            Console.WriteLine("Visu lyginiu skaiciu suma yra: " + suma);
        }
    }
}