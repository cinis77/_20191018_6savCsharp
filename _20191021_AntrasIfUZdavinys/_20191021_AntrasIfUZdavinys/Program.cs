using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191021_AntrasIfUZdavinys
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int trecias = Convert.ToInt32(Console.ReadLine());
            if (pirmas > antras && pirmas < 100)
            {
                Console.WriteLine("Pirma salyga yra ispildoma");
            }
            else if (antras > 0 && antras > pirmas)
            {
                Console.WriteLine("Antra salyga yra ispildoma");
            }
            else if (pirmas > antras && pirmas > trecias || pirmas > 0)
            {
                Console.WriteLine("Trecia salyga yra ispildoma");
            }
            else if (trecias >= 5
                && trecias <= 10
                || trecias > pirmas
                || trecias > antras)
            {
                Console.WriteLine("Ketvirta salyga yra ispildoma");
            }
        }
    }
}