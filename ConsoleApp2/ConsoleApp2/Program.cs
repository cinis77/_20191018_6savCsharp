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
            int sandauga = 1;

            while (sandauga < skaicius)
            {
                sandauga *= ++factorialas;
            }
            if (sandauga == skaicius)
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