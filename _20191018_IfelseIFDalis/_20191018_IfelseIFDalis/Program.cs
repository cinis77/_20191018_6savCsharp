using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191018_IfelseIFDalis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sk1 = 50;
            int sk2 = 20;
            Console.WriteLine("Iveskite studento amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius > sk1)
            {
                Console.WriteLine("Amzius yra didesnis nei pirmas skaicius");
            }
            else if (amzius > sk2)
            {
                Console.WriteLine("Amzius yra didesnis nei antras skaicius");
            }
            else
            {
                Console.WriteLine("Amzius nera didesnis nei uz viena skaiciu");
            }
        }
    }
}