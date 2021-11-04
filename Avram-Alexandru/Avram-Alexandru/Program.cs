using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades1 = new List<int>() { 5, 10, 26, 34, 26, 26, 26, 2, 23, 26, 200 };
            List<int> grades2 = new List<int>() { 5, 10, 26, 34, 26, 26, 26, 2, 23, 26, 200 };
            if (grades1.SequenceEqual(grades2))
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
