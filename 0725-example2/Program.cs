﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_example2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    Console.WriteLine("{0}X{1}={2}", b, a, a * b);
                }
                Console.WriteLine();
            }
        }
    }
}