using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191018_skaiciavimoMasinele
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite zenkla");
            char zenklas = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            if (zenklas == '+')
            {
                Console.WriteLine("sudetis yra " + (sk + sk1));
            }
            else if (zenklas == '-')
            {
                Console.WriteLine("atimtis yra " + (sk - sk1));
            }
            else if (zenklas == '*')
            {
                Console.WriteLine("sandauga yra " + (sk * sk1));
            }
            else if (zenklas == '/')
            {
                if (sk1 != 0)
                {
                    Console.WriteLine("dalyba yra " + ((double)sk / sk1));
                }
                else
                {
                    Console.WriteLine("Dalyba is nulio negalima");
                }
            }
            else
            {
                Console.WriteLine("Neatpazintas zenklas");
            }
        }
    }
}