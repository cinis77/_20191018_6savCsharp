using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191022_KeliamiejiMetai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i < DateTime.Today.Year; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}