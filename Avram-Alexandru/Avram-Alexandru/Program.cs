﻿using System;

namespace Avram_Alexandru
{
    class Program
    {
        int x = 5;
        static void Main(string[] args)
        {
            int i = 9;
            while (i >= 0)
            {
                int k = i;
                while (k >= 0)
                {
                    Console.Write($"{ k } ");
                    k--;
                }
                Console.WriteLine();
                i--;
            }
        }
    }
}
