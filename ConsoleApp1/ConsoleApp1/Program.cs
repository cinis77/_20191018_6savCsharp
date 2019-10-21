using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Graza atiduota: ");
            if (g >= 100)
            {
                Console.Write("100 :" + (g / 100));
            }
            g %= 100; // g = g % 100
            if (g >= 50)
            {
                Console.WriteLine("50: " + (g / 50));
            }
            g %= 50;
            if (g >= 20)
            {
                Console.WriteLine("20: " + (g / 20));
            }
            g %= 20;
            if (g >= 10)
            {
                Console.WriteLine("10: " + (g / 10));
            }
            g %= 10;
            if (g >= 5)
            {
                Console.WriteLine("5: " + (g / 5));
            }
            g %= 2;
            if (g >= 2)
            {
                Console.WriteLine("2: " + (g / 2));
            }
            g %= 2;
            if (g >= 1)
            {
                Console.WriteLine("1: " + g);
            }
        }
    }
}