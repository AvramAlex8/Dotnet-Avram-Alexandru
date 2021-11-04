using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 5, 10 };
            grades.Add(5);
            grades.Add(10);
            Console.WriteLine($"{ grades[0] } { grades[1] } ");
        }
    }
}
