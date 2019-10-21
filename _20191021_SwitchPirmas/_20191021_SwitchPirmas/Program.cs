using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191021_SwitchPirmas
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

            switch (pirmas)
            {
                case 1:
                    Console.WriteLine(pirmas + antras + trecias);
                    break;

                case 2:
                    Console.WriteLine(pirmas - trecias);
                    break;

                case 3:
                    Console.WriteLine(antras * trecias);
                    break;

                default:
                    Console.WriteLine("Neatpazinta komanda");
                    break;
            }
        }
    }
}