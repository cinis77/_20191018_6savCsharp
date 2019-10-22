using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191022_fortrecia
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite zekla");
            char zenklas = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(zenklas);
                }
                Console.WriteLine();
            }
        }
    }
}