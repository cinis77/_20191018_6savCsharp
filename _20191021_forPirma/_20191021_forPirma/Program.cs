﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191021_forPirma
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 0; i < 20; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}