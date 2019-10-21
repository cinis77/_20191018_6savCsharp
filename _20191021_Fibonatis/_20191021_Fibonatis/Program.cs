using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191021_Fibonatis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kiek norite matyti fibonacio sekos skaiciu");
            int kiekis = Convert.ToInt32(Console.ReadLine());
            int sk1 = 1;
            int sk2 = 1;
            int sk3 = 0;
            Console.WriteLine(sk1);
            Console.WriteLine(sk2);
            for (int i = 2; i < kiekis; i++)
            {
                sk3 = sk1 + sk2;
                Console.WriteLine(sk3);
                sk1 = sk2;
                sk2 = sk3;
            }
        }
    }
}