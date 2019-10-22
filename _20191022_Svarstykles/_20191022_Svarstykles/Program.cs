using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191022_Svarstykles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sk1 = 2;
            int sk2 = 2;
            int sk3 = 2;
            int sk4 = 1;
            int sk5 = 2;
            int sk6 = 2;
            int sk7 = 2;
            int sk8 = 2;
            if (sk1 + sk2 + sk3 < sk4 + sk5 + sk6)
            {
                if (sk1 < sk2)
                {
                    Console.WriteLine("Brokuotas yra pirmas kamuoliukas");
                }
                else if (sk1 > sk2)
                {
                    Console.WriteLine("Brokuotas yra antras kamuoliukas");
                }
                else
                {
                    Console.WriteLine("Brokuotas yra trecias kamuoliukas");
                }
            }
            else if (sk1 + sk2 + sk3 > sk4 + sk5 + sk6)
            {
                if (sk4 < sk5)
                {
                    Console.WriteLine("Brokuotas yra ketvirtas kamuoliukas");
                }
                else if (sk4 > sk5)
                {
                    Console.WriteLine("Brokuotas yra penktas kamuoliukas");
                }
                else
                {
                    Console.WriteLine("Brokuotas yra sestas kamuoliukas");
                }
            }
            else
            {
                if (sk7 < sk8)
                {
                    Console.WriteLine("Brokuotas yra septintas kamuoliukas");
                }
                else
                {
                    Console.WriteLine("Brokuotas yra astuntas kamuoliukas");
                }
            }
        }
    }
}