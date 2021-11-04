using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            grades.Add(5);
            Console.WriteLine(grades[0]);
            Console.WriteLine(grades.Count);
        }
    }
}
