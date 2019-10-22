using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191022_Zaidimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Sugalvokite skaiciu nuo 1 iki 3000");
            Console.WriteLine("Noredami pradedi zadima spauskite Enter klavisa");
            Console.ReadLine();

            int min = 1;
            int max = 3000;
            string atsakymas = string.Empty;
            while (atsakymas.ToLower() != "atspejai")
            {
                int spejimas = (min + max) / 2;
                Console.WriteLine("Ar jusu sugalvotas skacius yra : {0}?", spejimas);
                Console.WriteLine("Vesti daugiau, maziau arba atspejai");
                atsakymas = Console.ReadLine();
                if (atsakymas.ToLower() == "daugiau")
                {
                    min = spejimas;
                }
                else if (atsakymas.ToLower() == "maziau")
                {
                    max = spejimas;
                }
            }
            Console.WriteLine("Atspejau!!!!!!!!");
        }
    }
}