using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 5, 10, 26, 34, 26, 26, 26, 2, 23, 26, 200 };
            foreach (int grade in grades.ToArray())
            {
                Console.Write($"{ grade } ");
            }
        }
    }
}
