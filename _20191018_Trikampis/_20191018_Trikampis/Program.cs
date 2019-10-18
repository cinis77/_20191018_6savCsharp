using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191018_Trikampis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int c = Convert.ToInt32(Console.ReadLine());
            // && => reiskia ir
            // || => reiskia arba
            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Sudaryti trikampi galima");
            }
            else
            {
                Console.WriteLine("Sudaryti trikampio negalima");
            }
        }
    }
}