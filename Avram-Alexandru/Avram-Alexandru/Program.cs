using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stuff = new List<int>() { 5, 60, 3, 50 };
            stuff.Sort();
            stuff.Reverse();
            foreach (int i in stuff)
            {
                Console.Write($"{ i } ");
            }
        }
    }
}
