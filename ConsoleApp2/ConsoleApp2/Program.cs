using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int factorialas = 1;
            int sand = 1;

            while (sand < skaicius)
            {
                sand *= ++factorialas;
            }
            if (sand == skaicius)
            {
                Console.WriteLine("Factorialas yra " + factorialas + "!");
            }
            else
            {
                Console.WriteLine("Factorialo nera");
            }
        }
    }
}